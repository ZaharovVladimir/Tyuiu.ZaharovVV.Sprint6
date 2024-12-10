namespace Tyuiu.ZaharovVV.Sprint5.Task0.V22
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask__ZVV = new GroupBox();
            textBoxTask_ZVV = new TextBox();
            pictureBoxFormula_ZVV = new PictureBox();
            groupBoxInputData_ZVV = new GroupBox();
            labelVarX_ZVV = new Label();
            textBoxVarX_ZVV = new TextBox();
            groupBoxOutputData_ZVV = new GroupBox();
            textBoxOutput_ZVV = new TextBox();
            labelOutput_ZVV = new Label();
            buttonCalc_ZVV = new Button();
            buttonInfo_ZVV = new Button();
            groupBoxTask__ZVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_ZVV).BeginInit();
            groupBoxInputData_ZVV.SuspendLayout();
            groupBoxOutputData_ZVV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask__ZVV
            // 
            groupBoxTask__ZVV.Controls.Add(textBoxTask_ZVV);
            groupBoxTask__ZVV.Location = new Point(19, 13);
            groupBoxTask__ZVV.Name = "groupBoxTask__ZVV";
            groupBoxTask__ZVV.Size = new Size(498, 236);
            groupBoxTask__ZVV.TabIndex = 0;
            groupBoxTask__ZVV.TabStop = false;
            groupBoxTask__ZVV.Text = "Условие";
            groupBoxTask__ZVV.Enter += groupBox1_Enter;
            // 
            // textBoxTask_ZVV
            // 
            textBoxTask_ZVV.BackColor = SystemColors.Control;
            textBoxTask_ZVV.BorderStyle = BorderStyle.None;
            textBoxTask_ZVV.Cursor = Cursors.IBeam;
            textBoxTask_ZVV.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_ZVV.Location = new Point(7, 19);
            textBoxTask_ZVV.Name = "textBoxTask_ZVV";
            textBoxTask_ZVV.ReadOnly = true;
            textBoxTask_ZVV.Size = new Size(423, 19);
            textBoxTask_ZVV.TabIndex = 0;
            textBoxTask_ZVV.Text = "Вычислить значение по формуле";
            textBoxTask_ZVV.TextChanged += textBox1_TextChanged;
            // 
            // pictureBoxFormula_ZVV
            // 
            pictureBoxFormula_ZVV.Image = (Image)resources.GetObject("pictureBoxFormula_ZVV.Image");
            pictureBoxFormula_ZVV.Location = new Point(547, 76);
            pictureBoxFormula_ZVV.Name = "pictureBoxFormula_ZVV";
            pictureBoxFormula_ZVV.Size = new Size(225, 51);
            pictureBoxFormula_ZVV.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFormula_ZVV.TabIndex = 0;
            pictureBoxFormula_ZVV.TabStop = false;
            // 
            // groupBoxInputData_ZVV
            // 
            groupBoxInputData_ZVV.Controls.Add(labelVarX_ZVV);
            groupBoxInputData_ZVV.Controls.Add(textBoxVarX_ZVV);
            groupBoxInputData_ZVV.Location = new Point(19, 280);
            groupBoxInputData_ZVV.Name = "groupBoxInputData_ZVV";
            groupBoxInputData_ZVV.Size = new Size(498, 83);
            groupBoxInputData_ZVV.TabIndex = 1;
            groupBoxInputData_ZVV.TabStop = false;
            groupBoxInputData_ZVV.Text = "Ввод данных";
            // 
            // labelVarX_ZVV
            // 
            labelVarX_ZVV.AutoSize = true;
            labelVarX_ZVV.Location = new Point(16, 29);
            labelVarX_ZVV.Name = "labelVarX_ZVV";
            labelVarX_ZVV.Size = new Size(86, 15);
            labelVarX_ZVV.TabIndex = 2;
            labelVarX_ZVV.Text = "Переменная X";
            labelVarX_ZVV.Click += label1_Click;
            // 
            // textBoxVarX_ZVV
            // 
            textBoxVarX_ZVV.BorderStyle = BorderStyle.FixedSingle;
            textBoxVarX_ZVV.Location = new Point(16, 47);
            textBoxVarX_ZVV.Name = "textBoxVarX_ZVV";
            textBoxVarX_ZVV.Size = new Size(86, 23);
            textBoxVarX_ZVV.TabIndex = 1;
            // 
            // groupBoxOutputData_ZVV
            // 
            groupBoxOutputData_ZVV.Controls.Add(textBoxOutput_ZVV);
            groupBoxOutputData_ZVV.Controls.Add(labelOutput_ZVV);
            groupBoxOutputData_ZVV.Location = new Point(549, 280);
            groupBoxOutputData_ZVV.Name = "groupBoxOutputData_ZVV";
            groupBoxOutputData_ZVV.Size = new Size(239, 83);
            groupBoxOutputData_ZVV.TabIndex = 2;
            groupBoxOutputData_ZVV.TabStop = false;
            groupBoxOutputData_ZVV.Text = "Вывод данных";
            // 
            // textBoxOutput_ZVV
            // 
            textBoxOutput_ZVV.BackColor = SystemColors.Control;
            textBoxOutput_ZVV.BorderStyle = BorderStyle.FixedSingle;
            textBoxOutput_ZVV.Cursor = Cursors.IBeam;
            textBoxOutput_ZVV.Location = new Point(15, 47);
            textBoxOutput_ZVV.Name = "textBoxOutput_ZVV";
            textBoxOutput_ZVV.ReadOnly = true;
            textBoxOutput_ZVV.Size = new Size(110, 23);
            textBoxOutput_ZVV.TabIndex = 1;
            // 
            // labelOutput_ZVV
            // 
            labelOutput_ZVV.AutoSize = true;
            labelOutput_ZVV.Location = new Point(15, 25);
            labelOutput_ZVV.Name = "labelOutput_ZVV";
            labelOutput_ZVV.Size = new Size(60, 15);
            labelOutput_ZVV.TabIndex = 0;
            labelOutput_ZVV.Text = "Результат";
            // 
            // buttonCalc_ZVV
            // 
            buttonCalc_ZVV.BackColor = SystemColors.Control;
            buttonCalc_ZVV.Location = new Point(639, 384);
            buttonCalc_ZVV.Name = "buttonCalc_ZVV";
            buttonCalc_ZVV.Size = new Size(151, 57);
            buttonCalc_ZVV.TabIndex = 3;
            buttonCalc_ZVV.Text = "Выполнить";
            buttonCalc_ZVV.UseVisualStyleBackColor = false;
            // 
            // buttonInfo_ZVV
            // 
            buttonInfo_ZVV.BackColor = SystemColors.Window;
            buttonInfo_ZVV.FlatStyle = FlatStyle.Popup;
            buttonInfo_ZVV.Location = new Point(564, 384);
            buttonInfo_ZVV.Name = "buttonInfo_ZVV";
            buttonInfo_ZVV.Size = new Size(57, 57);
            buttonInfo_ZVV.TabIndex = 4;
            buttonInfo_ZVV.Text = "?";
            buttonInfo_ZVV.UseVisualStyleBackColor = false;
            buttonInfo_ZVV.Click += button1_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonInfo_ZVV);
            Controls.Add(buttonCalc_ZVV);
            Controls.Add(groupBoxOutputData_ZVV);
            Controls.Add(groupBoxInputData_ZVV);
            Controls.Add(pictureBoxFormula_ZVV);
            Controls.Add(groupBoxTask__ZVV);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            groupBoxTask__ZVV.ResumeLayout(false);
            groupBoxTask__ZVV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_ZVV).EndInit();
            groupBoxInputData_ZVV.ResumeLayout(false);
            groupBoxInputData_ZVV.PerformLayout();
            groupBoxOutputData_ZVV.ResumeLayout(false);
            groupBoxOutputData_ZVV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask__ZVV;
        private TextBox textBoxTask_ZVV;
        private PictureBox pictureBoxFormula_ZVV;
        private GroupBox groupBoxInputData_ZVV;
        private Label labelVarX_ZVV;
        private TextBox textBoxVarX_ZVV;
        private GroupBox groupBoxOutputData_ZVV;
        private TextBox textBoxOutput_ZVV;
        private Label labelOutput_ZVV;
        private Button buttonCalc_ZVV;
        private Button buttonInfo_ZVV;
    }
}
