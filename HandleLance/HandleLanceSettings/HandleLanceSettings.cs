using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandleSettings.ExceptionFolder;

namespace HandleSettings
{
    /// <summary>
    /// Класс параметров ручки Ланса
    /// </summary>
    public class HandleLanceSettings
    {
        /// <summary>
        /// Длина ручки Ланса
        /// </summary>
        private double _lengthOfHandle;

        /// <summary>
        /// Толщина ручки Ланса
        /// </summary>
        private double _thicknessOfHandle;

        /// <summary>
        /// Высота ручки Ланса
        /// </summary>
        private double _handleHeight;

        /// <summary>
        /// Диаметр отверстий ручки Ланса
        /// </summary>
        private double _diameterOfHoles;

        /// <summary>
        /// Глубина отверстий ручек Ланса
        /// </summary>
        private double _depthOfHeloes;

        /// <summary>
        /// Свойства для длины ручки ланса
        /// </summary>
        public double LengthOfHandle
        {
            get
            {
                return _lengthOfHandle;
            }
            set
            {
                if (value < 100 || value > 1500)
                {
                    throw new LengthException();
                }
                _lengthOfHandle = value;
            }
        }

        /// <summary>
        /// Свойства для толщины ручки Ланса
        /// </summary>
        public double ThicknessOfHendle
        {
            get
            {
                return _thicknessOfHandle;
            }
            set
            {
                if (value > 13 || value < 7)
                {
                    throw new ThicknessOfHandleException();
                }
                _thicknessOfHandle = value;
            }
        }

        /// <summary>
        /// Свойства высоты ручки 
        /// </summary>
        public double HandleHeight
        {
            get
            {
                return _handleHeight;
            }
            set
            {
                if (value < 50 || value > 65)
                {
                    throw new HandleHeightException();
                }
                _handleHeight = value;
            }
        }

        /// <summary>
        /// Свойства диаметра отверстий
        /// </summary>
        public double DiameterOfHoles
        {
            get
            {
                return _diameterOfHoles;
            }
            set
            {
                if (value > 5 || value < 3.55)
                {
                    throw new DiameterOfHolesException();
                }
                _diameterOfHoles = value;
            }
        }

        /// <summary>
        /// Свойства глубины отверстий
        /// </summary>
        public double DepthOfHoles
        {
            get
            {
                return _depthOfHeloes;
            }
            set
            {
                if (value < 25 || value > 41)
                {
                    throw new DepthOfHolesException();
                }
                _depthOfHeloes = value;
            }
        }
    }
}
