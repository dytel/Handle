using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HandleSettings.ExceptionFolder;
using HandleSettings;
using KompasProgram;

namespace HandleLance
{
    public partial class HandLanseForm : Form
    {
        /// <summary>
        /// Инициализация
        /// </summary>
        public HandLanseForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Объект program kompas
        /// </summary>
        private ProgramKompas programKompas = new ProgramKompas();

        /// <summary>
        /// Объект построения модели
        /// </summary>
        private HandleLanceSettings _handleLanceSetting =
            new HandleLanceSettings();

        /// <summary>
        /// Построение модели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                _handleLanceSetting.LengthOfHandle =
                    Convert.ToDouble(_LengthOfHandleTextBox.Text);
                _handleLanceSetting.ThicknessOfHendle =
                    Convert.ToDouble(_thicknessOfHandleTextBox.Text);
                _handleLanceSetting.HandleHeight = 
                    Convert.ToDouble(_handleHeightTextBox.Text);
                _handleLanceSetting.DiameterOfHoles =
                    Convert.ToDouble(_diameterOfHolesTextBox.Text);
                _handleLanceSetting.DepthOfHoles = 
                    Convert.ToDouble(_depthOfHolesTextBox.Text);
                programKompas.SetParametr(_handleLanceSetting);
                programKompas.Construct();
            }
            catch (FormatException)
            {
                MessageBox.Show("У вас остались пустые поля", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// шаблон валидации
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="message"></param>
        private void SelectedTextBox(TextBox textBox, string message)
        {
            textBox.Clear();
            MessageBox.Show(message, "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Валидация длины ручки Ланса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LengthOfHandleTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                _handleLanceSetting.LengthOfHandle
                    = Convert.ToDouble(_LengthOfHandleTextBox.Text);
            }
            catch (LengthException)
            {
                SelectedTextBox(_depthOfHolesTextBox,
                    "Неправильно задана длина");
            }
            catch (FormatException)
            {
                SelectedTextBox(_depthOfHolesTextBox,
                    "Вы не ввели значение длины");
            }
        }

        /// <summary>
        /// Валидация толщины ручки Ланса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThicknessOfHandleTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                _handleLanceSetting.ThicknessOfHendle
                    = Convert.ToDouble(_thicknessOfHandleTextBox.Text);
            }
            catch (ThicknessOfHandleException)
            {
                SelectedTextBox(_thicknessOfHandleTextBox, 
                    "Неправильно задана толщина");
            }
            catch (FormatException)
            {
                SelectedTextBox(_thicknessOfHandleTextBox,
                    "Вы не ввели значение толщиины");
            }
        }

        /// <summary>
        /// Валидация высоты ручки Ланса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleHeightTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                _handleLanceSetting.HandleHeight
                    = Convert.ToDouble(_handleHeightTextBox.Text);
            }
            catch (HandleHeightException)
            {
                SelectedTextBox(_handleHeightTextBox,
                    "Неправильно задана высота");
            }
            catch (FormatException)
            {
                SelectedTextBox(_handleHeightTextBox,
                    "Вы не ввели значение высоты");
            }
        }

        /// <summary>
        /// Валидация диаметра отверстий ручки Ланса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DiameterOfHolesTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                _handleLanceSetting.DiameterOfHoles
                    = Convert.ToDouble(_diameterOfHolesTextBox.Text);
            }
            catch (DiameterOfHolesException)
            {
                SelectedTextBox(_diameterOfHolesTextBox, 
                    "Неправильно задан диаметер");
            }
            catch (FormatException)
            {
                SelectedTextBox(_diameterOfHolesTextBox,
                    "Вы не ввели значение диаметра");
            }
        }

        /// <summary>
        /// Валидация глубины отверстий ручки Ланса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DepthOfHolesTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                _handleLanceSetting.DepthOfHoles
                    = Convert.ToDouble(_depthOfHolesTextBox.Text);
            }
            catch (DepthOfHolesException)
            {
                SelectedTextBox(_depthOfHolesTextBox,
                    "Неправильно задана глубина");
            }
            catch (FormatException)
            {
                SelectedTextBox(_depthOfHolesTextBox,
                    "Вы не ввели значение глубины");
            }
        }
    }
}
