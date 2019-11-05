namespace LibraryDB2_try_millionth_
{
    partial class Teachers_cards
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DG_TeachersCars = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.cb_Book = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTecher = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_library_employees = new System.Windows.Forms.ComboBox();
            this.library_employees = new System.Windows.Forms.Label();
            this.tb_data_return = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_data_receiving = new System.Windows.Forms.TextBox();
            this.lbl_Lastname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_TeachersCars)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_TeachersCars
            // 
            this.DG_TeachersCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_TeachersCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DG_TeachersCars.Location = new System.Drawing.Point(24, 274);
            this.DG_TeachersCars.Name = "DG_TeachersCars";
            this.DG_TeachersCars.RowHeadersWidth = 51;
            this.DG_TeachersCars.RowTemplate.Height = 24;
            this.DG_TeachersCars.Size = new System.Drawing.Size(858, 251);
            this.DG_TeachersCars.TabIndex = 66;
            this.DG_TeachersCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_TeachersCars_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Data_receiving";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Data_return";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Books";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Techers";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Library_employees";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Delete.Location = new System.Drawing.Point(493, 203);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(166, 37);
            this.btn_Delete.TabIndex = 65;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(493, 139);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(166, 37);
            this.btn_Update.TabIndex = 64;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(493, 70);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(166, 37);
            this.btn_Insert.TabIndex = 63;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click);
            // 
            // cb_Book
            // 
            this.cb_Book.FormattingEnabled = true;
            this.cb_Book.Location = new System.Drawing.Point(213, 77);
            this.cb_Book.Name = "cb_Book";
            this.cb_Book.Size = new System.Drawing.Size(186, 24);
            this.cb_Book.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(24, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 61;
            this.label5.Text = "Books";
            // 
            // cbTecher
            // 
            this.cbTecher.FormattingEnabled = true;
            this.cbTecher.Location = new System.Drawing.Point(213, 139);
            this.cbTecher.Name = "cbTecher";
            this.cbTecher.Size = new System.Drawing.Size(186, 24);
            this.cbTecher.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 59;
            this.label4.Text = "Teacher";
            // 
            // cb_library_employees
            // 
            this.cb_library_employees.FormattingEnabled = true;
            this.cb_library_employees.Location = new System.Drawing.Point(213, 203);
            this.cb_library_employees.Name = "cb_library_employees";
            this.cb_library_employees.Size = new System.Drawing.Size(186, 24);
            this.cb_library_employees.TabIndex = 58;
            // 
            // library_employees
            // 
            this.library_employees.AutoSize = true;
            this.library_employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.library_employees.Location = new System.Drawing.Point(24, 201);
            this.library_employees.Name = "library_employees";
            this.library_employees.Size = new System.Drawing.Size(163, 24);
            this.library_employees.TabIndex = 57;
            this.library_employees.Text = "library_employees";
            // 
            // tb_data_return
            // 
            this.tb_data_return.Location = new System.Drawing.Point(493, 11);
            this.tb_data_return.Multiline = true;
            this.tb_data_return.Name = "tb_data_return";
            this.tb_data_return.Size = new System.Drawing.Size(136, 25);
            this.tb_data_return.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(384, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 55;
            this.label2.Text = "data_return";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "ID";
            // 
            // tb_data_receiving
            // 
            this.tb_data_receiving.Location = new System.Drawing.Point(213, 11);
            this.tb_data_receiving.Multiline = true;
            this.tb_data_receiving.Name = "tb_data_receiving";
            this.tb_data_receiving.Size = new System.Drawing.Size(136, 25);
            this.tb_data_receiving.TabIndex = 52;
            // 
            // lbl_Lastname
            // 
            this.lbl_Lastname.AutoSize = true;
            this.lbl_Lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Lastname.Location = new System.Drawing.Point(61, 10);
            this.lbl_Lastname.Name = "lbl_Lastname";
            this.lbl_Lastname.Size = new System.Drawing.Size(132, 24);
            this.lbl_Lastname.TabIndex = 51;
            this.lbl_Lastname.Text = "data_receiving";
            // 
            // Teachers_cards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 542);
            this.Controls.Add(this.DG_TeachersCars);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.cb_Book);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTecher);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_library_employees);
            this.Controls.Add(this.library_employees);
            this.Controls.Add(this.tb_data_return);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_data_receiving);
            this.Controls.Add(this.lbl_Lastname);
            this.Name = "Teachers_cards";
            this.Text = "Teachers_cards";
            ((System.ComponentModel.ISupportInitialize)(this.DG_TeachersCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_TeachersCars;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.ComboBox cb_Book;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTecher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_library_employees;
        private System.Windows.Forms.Label library_employees;
        private System.Windows.Forms.TextBox tb_data_return;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_data_receiving;
        private System.Windows.Forms.Label lbl_Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}