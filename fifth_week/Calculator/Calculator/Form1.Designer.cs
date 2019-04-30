namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.button1 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn_def = new System.Windows.Forms.Button();
            this.btn_mult = new System.Windows.Forms.Button();
            this.btn_Min = new System.Windows.Forms.Button();
            this.btn_CE = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_qually = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn_point = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.lbl_Operation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.btn1, "btn1");
            this.btn1.Name = "btn1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.button_click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.btn4, "btn4");
            this.btn4.Name = "btn4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.button_click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.btn7, "btn7");
            this.btn7.Name = "btn7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.button_click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.btn8, "btn8");
            this.btn8.Name = "btn8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.button_click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.btn5, "btn5");
            this.btn5.Name = "btn5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.button_click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.btn2, "btn2");
            this.btn2.Name = "btn2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.button_click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.btn9, "btn9");
            this.btn9.Name = "btn9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.button_click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.btn6, "btn6");
            this.btn6.Name = "btn6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.button_click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.btn3, "btn3");
            this.btn3.Name = "btn3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.button_click);
            // 
            // btn_def
            // 
            this.btn_def.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.btn_def, "btn_def");
            this.btn_def.Name = "btn_def";
            this.btn_def.UseVisualStyleBackColor = false;
            this.btn_def.Click += new System.EventHandler(this.operator_click);
            // 
            // btn_mult
            // 
            this.btn_mult.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.btn_mult, "btn_mult");
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.UseVisualStyleBackColor = false;
            this.btn_mult.Click += new System.EventHandler(this.operator_click);
            // 
            // btn_Min
            // 
            this.btn_Min.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.btn_Min, "btn_Min");
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.UseVisualStyleBackColor = false;
            this.btn_Min.Click += new System.EventHandler(this.operator_click);
            // 
            // btn_CE
            // 
            this.btn_CE.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.btn_CE, "btn_CE");
            this.btn_CE.Name = "btn_CE";
            this.btn_CE.UseVisualStyleBackColor = false;
            this.btn_CE.Click += new System.EventHandler(this.btn_CE_Click);
            // 
            // btn_C
            // 
            this.btn_C.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.btn_C, "btn_C");
            this.btn_C.Name = "btn_C";
            this.btn_C.UseVisualStyleBackColor = false;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_qually
            // 
            this.btn_qually.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.btn_qually, "btn_qually");
            this.btn_qually.Name = "btn_qually";
            this.btn_qually.UseVisualStyleBackColor = false;
            this.btn_qually.Click += new System.EventHandler(this.btn_qually_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.btn0, "btn0");
            this.btn0.Name = "btn0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.button_click);
            // 
            // btn_point
            // 
            this.btn_point.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.btn_point, "btn_point");
            this.btn_point.Name = "btn_point";
            this.btn_point.UseVisualStyleBackColor = false;
            this.btn_point.Click += new System.EventHandler(this.button_click);
            // 
            // btn_plus
            // 
            this.btn_plus.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.btn_plus, "btn_plus");
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.UseVisualStyleBackColor = false;
            this.btn_plus.Click += new System.EventHandler(this.operator_click);
            // 
            // textBox_Result
            // 
            resources.ApplyResources(this.textBox_Result, "textBox_Result");
            this.textBox_Result.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox_Result.Name = "textBox_Result";
            // 
            // lbl_Operation
            // 
            resources.ApplyResources(this.lbl_Operation, "lbl_Operation");
            this.lbl_Operation.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_Operation.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Operation.Name = "lbl_Operation";
            // 
            // Calculator
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.lbl_Operation);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_point);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn_CE);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_qually);
            this.Controls.Add(this.btn_def);
            this.Controls.Add(this.btn_mult);
            this.Controls.Add(this.btn_Min);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Calculator";
            this.Click += new System.EventHandler(this.button_click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn_def;
        private System.Windows.Forms.Button btn_mult;
        private System.Windows.Forms.Button btn_Min;
        private System.Windows.Forms.Button btn_CE;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_qually;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn_point;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label label_operation1;
        private System.Windows.Forms.Label lbl_Operation;
    }
}

