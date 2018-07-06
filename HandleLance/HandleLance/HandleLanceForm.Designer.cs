namespace HandleLance
{
    partial class HandLanseForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this._LengthOfHandleTextBox = new System.Windows.Forms.TextBox();
            this._thicknessOfHandleTextBox = new System.Windows.Forms.TextBox();
            this._handleHeightTextBox = new System.Windows.Forms.TextBox();
            this._diameterOfHolesTextBox = new System.Windows.Forms.TextBox();
            this._depthOfHolesTextBox = new System.Windows.Forms.TextBox();
            this._creatButonn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _LengthOfHandleTextBox
            // 
            this._LengthOfHandleTextBox.Location = new System.Drawing.Point(172, 12);
            this._LengthOfHandleTextBox.Name = "_LengthOfHandleTextBox";
            this._LengthOfHandleTextBox.Size = new System.Drawing.Size(100, 20);
            this._LengthOfHandleTextBox.TabIndex = 0;
            this._LengthOfHandleTextBox.Leave += new System.EventHandler(this.LengthOfHandleTextBox_Leave);
            // 
            // _thicknessOfHandleTextBox
            // 
            this._thicknessOfHandleTextBox.Location = new System.Drawing.Point(172, 38);
            this._thicknessOfHandleTextBox.Name = "_thicknessOfHandleTextBox";
            this._thicknessOfHandleTextBox.Size = new System.Drawing.Size(100, 20);
            this._thicknessOfHandleTextBox.TabIndex = 1;
            this._thicknessOfHandleTextBox.Leave += new System.EventHandler(this.ThicknessOfHandleTextBox_Leave);
            // 
            // _handleHeightTextBox
            // 
            this._handleHeightTextBox.Location = new System.Drawing.Point(172, 64);
            this._handleHeightTextBox.Name = "_handleHeightTextBox";
            this._handleHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this._handleHeightTextBox.TabIndex = 2;
            this._handleHeightTextBox.Leave += new System.EventHandler(this.HandleHeightTextBox_Leave);
            // 
            // _diameterOfHolesTextBox
            // 
            this._diameterOfHolesTextBox.Location = new System.Drawing.Point(172, 90);
            this._diameterOfHolesTextBox.Name = "_diameterOfHolesTextBox";
            this._diameterOfHolesTextBox.Size = new System.Drawing.Size(100, 20);
            this._diameterOfHolesTextBox.TabIndex = 3;
            this._diameterOfHolesTextBox.Leave += new System.EventHandler(this.DiameterOfHolesTextBox_Leave);
            // 
            // _depthOfHolesTextBox
            // 
            this._depthOfHolesTextBox.Location = new System.Drawing.Point(172, 116);
            this._depthOfHolesTextBox.Name = "_depthOfHolesTextBox";
            this._depthOfHolesTextBox.Size = new System.Drawing.Size(100, 20);
            this._depthOfHolesTextBox.TabIndex = 4;
            this._depthOfHolesTextBox.Leave += new System.EventHandler(this.DepthOfHolesTextBox_Leave);
            // 
            // _creatButonn
            // 
            this._creatButonn.Location = new System.Drawing.Point(197, 156);
            this._creatButonn.Name = "_creatButonn";
            this._creatButonn.Size = new System.Drawing.Size(75, 23);
            this._creatButonn.TabIndex = 5;
            this._creatButonn.Text = "Построить";
            this._creatButonn.UseVisualStyleBackColor = true;
            this._creatButonn.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Длина ручки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Толщина ручки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Высота ручки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Диаметр отверстий";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Глубина отверстий";
            // 
            // HandLanseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 191);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._creatButonn);
            this.Controls.Add(this._depthOfHolesTextBox);
            this.Controls.Add(this._diameterOfHolesTextBox);
            this.Controls.Add(this._handleHeightTextBox);
            this.Controls.Add(this._thicknessOfHandleTextBox);
            this.Controls.Add(this._LengthOfHandleTextBox);
            this.Name = "HandLanseForm";
            this.Text = "Ручка Ланса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _LengthOfHandleTextBox;
        private System.Windows.Forms.TextBox _thicknessOfHandleTextBox;
        private System.Windows.Forms.TextBox _handleHeightTextBox;
        private System.Windows.Forms.TextBox _diameterOfHolesTextBox;
        private System.Windows.Forms.TextBox _depthOfHolesTextBox;
        private System.Windows.Forms.Button _creatButonn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}

