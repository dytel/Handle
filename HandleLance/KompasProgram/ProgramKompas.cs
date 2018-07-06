using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandleSettings;
using Kompas6API5;
using Kompas6Constants;
using Kompas6Constants3D;

namespace KompasProgram
{
    /// <summary>
    /// Класс создающий 3Д модель ручка Ланса
    /// </summary>
    public class ProgramKompas
    {
        /// <summary>
        /// Параметры ручки Ланса
        /// </summary>
        private HandleLanceSettings _handleLanceSettings;

        /// <summary>
        /// Объект компаса
        /// </summary>
        private KompasObject _kompasObject;

        /// <summary>
        /// Объект 3Д документа
        /// </summary>
        private ksDocument3D _ksDocument3D;

        /// <summary>
        /// Объект детали
        /// </summary>
        private ksPart _ksPart;

        /// <summary>
        /// Запуск компаса
        /// </summary>
        private void RunningTheCompas()
        {
            if (_kompasObject != null)
            {
                _kompasObject.ActivateControllerAPI();
            }
            if (_kompasObject == null)
            {
                Type type = 
                    Type.GetTypeFromProgID("KOMPAS.Application.5");
                _kompasObject =
                    (KompasObject)Activator.CreateInstance(type);
            }
        }

        /// <summary>
        /// Инициализация параметров
        /// </summary>
        /// <param name="settings">параметры ручки</param>
        public void SetParametr(HandleLanceSettings settings)
        {
            _handleLanceSettings = settings;
        }

        /// <summary>
        /// Создание Нового 3Д документа
        /// </summary>
        private void CreateANewDocument()
        {
            _ksDocument3D = (ksDocument3D)_kompasObject.Document3D();
            _ksDocument3D.Create();
        }

        /// <summary>
        /// Получение интерфеса компонента
        /// </summary>
        private void GetTheComponentInterface()
        {
            const int pTop_Part = -1;
            _ksPart = (ksPart)_ksDocument3D.GetPart(pTop_Part);
        }

        /// <summary>
        /// Создание эскиза окружности
        /// </summary>
        /// <param name="part"></param>
        /// <param name="ksEntityHandleLance">Интерфейс элемента
        /// Модели </param>
        private void CreathSkecth(
            ksEntity ksEntityHandleLance, double x, double y,
            double radius, int style,short axis)
        {
            ksDocument2D ksDocument2D;
            ksEntity plane;
            ksSketchDefinition sketchDefinition;
            sketchDefinition =
                (ksSketchDefinition)
                ksEntityHandleLance.GetDefinition();
            plane = (ksEntity)_ksPart.GetDefaultEntity(
                axis);
            sketchDefinition.SetPlane(plane);
            ksEntityHandleLance.Create();
            ksDocument2D =
                (ksDocument2D)sketchDefinition.BeginEdit();
            ksDocument2D.ksCircle(x, y, radius, style);
            sketchDefinition.EndEdit();
        }

        private void CreathSkecthFormPlanOfSet(
    ksEntity ksEntityHandleLance, double x, double y,
    double radius, int style, short axis,ksEntity planeOfSet)
        {
            ksDocument2D ksDocument2D;
            ksEntity plane;
            ksSketchDefinition sketchDefinition;
            sketchDefinition =
                (ksSketchDefinition)
                ksEntityHandleLance.GetDefinition();
            plane = (ksEntity)_ksPart.GetDefaultEntity(
                axis);
            sketchDefinition.SetPlane(planeOfSet);
            ksEntityHandleLance.Create();
            ksDocument2D =
                (ksDocument2D)sketchDefinition.BeginEdit();
            ksDocument2D.ksCircle(x, y, radius, style);
            sketchDefinition.EndEdit();
        }

        /// <summary>
        /// Выдавливание эскиза
        /// </summary>
        /// <param name="name"></param>
        /// <param name="length"></param>
        /// <param name="ksEntity"></param>
        private void ExtrusionSkecth(string name,double length,
            ksEntity ksEntity,short typeExstrusion,bool fillet)
        {
            const int grayColor = 16777215;
           ksEntity ksEntityExtrusion = (ksEntity)_ksPart.NewEntity(
               typeExstrusion);
            ksBossExtrusionDefinition ksBaseExtrusionDefinition =
                (ksBossExtrusionDefinition)
                ksEntityExtrusion.GetDefinition();
            ksBaseExtrusionDefinition.SetSideParam(true, 
                (short)End_Type.etBlind,
                length, 0, true);
            ksBaseExtrusionDefinition.SetSketch(ksEntity);
            ksEntityExtrusion.name = name;
            ksEntityExtrusion.useColor = 0;
            ksEntityExtrusion.SetAdvancedColor(grayColor, 0.9, 0.8, 
                0.7,0.6, 1, 0.4);
            ksEntityExtrusion.Create();
            if(fillet == true )
            {
                Filled(ksEntityExtrusion);
            }
        }

        /// <summary>
        /// Выдавливание эскиза
        /// </summary>
        /// <param name="name"></param>
        /// <param name="length"></param>
        /// <param name="ksEntity"></param>
        private void ExtrusionCutSkecth(string name, double length,
            ksEntity ksEntity)
        {
            const int grayColor = 460551;
            ksEntity ksEntityExtrusion = 
                (ksEntity)_ksPart.NewEntity(
                    (short)Obj3dType.o3d_cutExtrusion);
            ksCutExtrusionDefinition ksCutExtrusionDefinition =
                (ksCutExtrusionDefinition)
                ksEntityExtrusion.GetDefinition();
            ksCutExtrusionDefinition.cut = true;
            ksCutExtrusionDefinition.directionType = 0;
            ksCutExtrusionDefinition.SetSideParam(true,
                (short)End_Type.etBlind,
                length, 0, false);
            ksCutExtrusionDefinition.SetSketch(ksEntity);
            ksEntityExtrusion.name = name;
            ksEntityExtrusion.useColor = 0;
            ksEntityExtrusion.SetAdvancedColor(grayColor, 0.9, 0.8,
                0.7, 0.6, 1, 0.4);
            ksEntityExtrusion.Create();
        }

        /// <summary>
        /// Смещение плоскости
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="plane"></param>
        /// <param name="ksEntityPlaneOffset"></param>
        private void CreatPlaneOffset(double offset, short plane,
            ksEntity ksEntityPlaneOffset)
        {
            ksEntity ksEntityPlaneXOY = 
                (ksEntity)_ksPart.GetDefaultEntity(plane);
            ksPlaneOffsetDefinition ksPlaneOffsetDefinition =
                (ksPlaneOffsetDefinition)
                ksEntityPlaneOffset.GetDefinition();
            ksPlaneOffsetDefinition.SetPlane(ksEntityPlaneXOY);
            ksPlaneOffsetDefinition.direction = true;
            ksPlaneOffsetDefinition.offset = offset;
            ksEntityPlaneOffset.Create();
        }

        /// <summary>
        /// Скругление
        /// </summary>
        private void Filled(ksEntity ksEntity)
        {
            const int grayColor = 16777215;
            ksEntity ksEntityFilled = (ksEntity)_ksPart.NewEntity(
                (short)Obj3dType.o3d_fillet);
            ksFilletDefinition ksFilletDefinition =
                (ksFilletDefinition)ksEntityFilled.GetDefinition();
            ksFilletDefinition.radius = 2;
            ksFilletDefinition.tangent = false;
            ksEntityCollection ksEntityCollectionPart =
                (ksEntityCollection)_ksPart.EntityCollection(
                    (short)Obj3dType.o3d_edge);
            ksEntityCollection ksEntityCollectionFillet =
                (ksEntityCollection)ksFilletDefinition.array();
            ksEntityCollectionFillet.Clear();
            ksEntityCollectionFillet.Add(ksEntityCollectionPart.GetByIndex(1));
            ksEntityCollectionFillet.Add(ksEntityCollectionPart.GetByIndex(0));
            ksEntityFilled.useColor = 0;
            ksEntityFilled.SetAdvancedColor(grayColor, 0.9, 0.8,
                0.7, 0.6, 1, 0.4);
            ksEntityFilled.Create();
        }

        /// <summary>
        /// для присвоения скетча
        /// </summary>
        /// <returns></returns>
        ksEntity Skecht()
        {
            return (ksEntity)_ksPart.NewEntity(
                (short)Obj3dType.o3d_sketch);
        }

        /// <summary>
        /// Построение детали в компас3D
        /// </summary>
        public void Construct()
        {
            double half = 2;
            RunningTheCompas();
            CreateANewDocument();
            GetTheComponentInterface();
            _kompasObject.Visible = true;
            ksEntity ksEntityHandleLance = Skecht();
            ksEntity ksEntityMountingsHandleLanceOne = Skecht();
            ksEntity ksEntityMountingsHandleLanceTwo = Skecht();
            ksEntity ksEntityHolesOne = Skecht();
            ksEntity ksEntityHolesTwo = Skecht();
            ksEntity ksEntityPlaneOffset 
                = (ksEntity)_ksPart.NewEntity(
                (short)Obj3dType.o3d_planeOffset);
            CreathSkecth(ksEntityHandleLance, 0, 0,
                _handleLanceSettings.ThicknessOfHendle / half, 1,
                (short)Obj3dType.o3d_planeYOZ);
            ExtrusionSkecth("Выдавливание ручки",
                _handleLanceSettings.LengthOfHandle,
                ksEntityHandleLance,
                (short)Obj3dType.o3d_bossExtrusion,true);
            CreathSkecth(ksEntityMountingsHandleLanceOne, -25, 0,
                _handleLanceSettings.ThicknessOfHendle / half, 1,
                (short)Obj3dType.o3d_planeXOY);
            CreathSkecth(ksEntityMountingsHandleLanceTwo, 
                -_handleLanceSettings.LengthOfHandle + 25, 0,
                _handleLanceSettings.ThicknessOfHendle / half, 1,
                (short)Obj3dType.o3d_planeXOY);
            ExtrusionSkecth("Выдавливание крепления ручки",
                _handleLanceSettings.HandleHeight,
                ksEntityMountingsHandleLanceOne,
                (short)Obj3dType.o3d_bossExtrusion,false);
            ExtrusionSkecth("Выдавливание крепления ручки",
                _handleLanceSettings.HandleHeight,
                ksEntityMountingsHandleLanceTwo,
                (short)Obj3dType.o3d_bossExtrusion,false);
            CreatPlaneOffset(_handleLanceSettings.HandleHeight,
                (short)Obj3dType.o3d_planeXOY, ksEntityPlaneOffset);
            CreathSkecthFormPlanOfSet(
                ksEntityHolesOne, -25, 0,
                _handleLanceSettings.DiameterOfHoles / half, 1,
                (short)Obj3dType.o3d_planeXOY,ksEntityPlaneOffset);
            CreathSkecthFormPlanOfSet(
                ksEntityHolesTwo,
                -_handleLanceSettings.LengthOfHandle + 25, 0,
                _handleLanceSettings.DiameterOfHoles / half, 1,
                (short)Obj3dType.o3d_planeXOY,ksEntityPlaneOffset);
            ExtrusionCutSkecth("Вырезание отверстия ручки",
                _handleLanceSettings.DepthOfHoles,ksEntityHolesOne);
            ExtrusionCutSkecth("Вырезание отверстия ручки",
                _handleLanceSettings.DepthOfHoles,ksEntityHolesTwo);      
        }
    }
}
