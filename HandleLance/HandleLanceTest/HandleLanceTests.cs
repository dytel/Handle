using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using HandleSettings.ExceptionFolder;
using HandleSettings;
namespace HandleLanceTest
{
    [TestFixture]
    public class HandleLanceTests
    {
        [Test]
        #region Тесты на длину ручки ланса
        [TestCase(100,TestName ="Тест длины ручки Ланса правильно заданной длины")]
        public void SetLengthHandleLancePositiveTest(double Length)
        {
            var handleLance = new HandleLanceSettings();
            handleLance.LengthOfHandle = Length;
        }

        [TestCase(99, TestName = "Тест длины ручки Ланса меньше заданной длины")]
        [TestCase(1501, TestName = "Тест длины ручки Ланса больше заданной длины")]
        public void SetLengthHandleLanceNegativeTest(double Length)
        {
            var handleLance = new HandleLanceSettings();
            Assert.Throws<LengthException>(() => handleLance.LengthOfHandle = Length);
        }
        #endregion
        #region Тесты на толщину ручки ланса
        [TestCase(13, TestName = "Тест толщины ручки Ланса правильно заданной длины")]
        public void SetThicknesshHandleLancePositiveTest(double Thickness)
        {
            var handleLance = new HandleLanceSettings();
            handleLance.ThicknessOfHendle = Thickness;
        }

        [TestCase(6, TestName = "Тест толщины ручки Ланса меньше заданной толщины")]
        [TestCase(14, TestName = "Тест толщины ручки Ланса больше заданной толщины")]
        public void SetThicknessHandleLanceNegativeTest(double Thickness)
        {
            var handleLance = new HandleLanceSettings();
            Assert.Throws<ThicknessOfHandleException>(() => handleLance.ThicknessOfHendle = Thickness);
        }
        #endregion
        #region Тесты на длину ручки ланса
        [TestCase(65, TestName ="Тест высоты ручки Ланса правильно заданной высоты")]
        public void SetHeightHandleLancePositiveTest(double Height)
        {
            var handleLance = new HandleLanceSettings();
            handleLance.HandleHeight = Height;
        }

        [TestCase(49, TestName = "Тест высоты ручки Ланса меньше заданной высоты")]
        [TestCase(66, TestName = "Тест высоты ручки Ланса больше заданной высоты")]
        public void SetHeightHandleLanceNegativeTest(double Height)
        {
            var handleLance = new HandleLanceSettings();
            Assert.Throws<HandleHeightException>(() => handleLance.HandleHeight = Height);
        }
        #endregion
        #region Тесты на диаметр отверствий ручки ланса
        [TestCase(3.55, TestName = "Тест диаметра правильно заданного диаметра")]
        public void SetDiameterOfHolesPositiveTest(double diameter)
        {
            var handleLance = new HandleLanceSettings();
            handleLance.DiameterOfHoles = diameter;
        }

        [TestCase(3.49, TestName = "Тест диаметра отверстий меньше заданной длины")]
        [TestCase(6, TestName = "Тест диаметра отверстий больше заданной длины")]
        public void SetDiameterOfHolesNegativeTest(double diameter)
        {
            var handleLance = new HandleLanceSettings();
            Assert.Throws<DiameterOfHolesException>(() => handleLance.DiameterOfHoles = diameter);
        }
        #endregion
        #region Тесты на глубину отверствий ручки ланса
        [TestCase(25, TestName = "Тест глубины отверстий правильно заданной глубины")]
        public void SetDepthOfHolesPositiveTest(double diameter)
        {
            var handleLance = new HandleLanceSettings();
            handleLance.DepthOfHoles = diameter;
        }

        [TestCase(24, TestName = "Тест глубины отверстий меньше заданной глубины")]
        [TestCase(46, TestName = "Тест глубины отверстий больше заданной глубины")]
        public void SetDepthOfHolesNegativeTest(double diameter)
        {
            var handleLance = new HandleLanceSettings();
            Assert.Throws<DepthOfHolesException>(() => handleLance.DepthOfHoles = diameter);
        }
        #endregion
    }
}
