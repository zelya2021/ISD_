namespace Exam_Score_Entity_
{
    partial class Form1
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
            this.grBox_Search = new System.Windows.Forms.GroupBox();
            this.cb_price = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_name = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_addTObasket = new System.Windows.Forms.Button();
            this.grBox_Search.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // grBox_Search
            // 
            this.grBox_Search.Controls.Add(this.cb_price);
            this.grBox_Search.Controls.Add(this.panel1);
            this.grBox_Search.Controls.Add(this.label4);
            this.grBox_Search.Controls.Add(this.cb_name);
            this.grBox_Search.Controls.Add(this.label3);
            this.grBox_Search.Controls.Add(this.cb_category);
            this.grBox_Search.Controls.Add(this.label2);
            this.grBox_Search.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grBox_Search.Location = new System.Drawing.Point(12, 72);
            this.grBox_Search.Name = "grBox_Search";
            this.grBox_Search.Size = new System.Drawing.Size(717, 190);
            this.grBox_Search.TabIndex = 2;
            this.grBox_Search.TabStop = false;
            this.grBox_Search.Text = "Search";
            // 
            // cb_price
            // 
            this.cb_price.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cb_price.FormattingEnabled = true;
            this.cb_price.Location = new System.Drawing.Point(126, 138);
            this.cb_price.Name = "cb_price";
            this.cb_price.Size = new System.Drawing.Size(121, 34);
            this.cb_price.TabIndex = 5;
            this.cb_price.SelectedIndexChanged += new System.EventHandler(this.Cb_price_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(277, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 158);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView.Location = new System.Drawing.Point(18, 5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(416, 150);
            this.dataGridView.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Autor";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Category";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "by price";
            // 
            // cb_name
            // 
            this.cb_name.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cb_name.FormattingEnabled = true;
            this.cb_name.Location = new System.Drawing.Point(126, 88);
            this.cb_name.Name = "cb_name";
            this.cb_name.Size = new System.Drawing.Size(121, 34);
            this.cb_name.TabIndex = 3;
            this.cb_name.SelectedIndexChanged += new System.EventHandler(this.Cb_name_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "by name";
            // 
            // cb_category
            // 
            this.cb_category.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(126, 35);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(121, 34);
            this.cb_category.TabIndex = 1;
            this.cb_category.SelectedIndexChanged += new System.EventHandler(this.Cb_category_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "by category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to the \"Bookstore\"";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(604, 392);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(125, 94);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_admin.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_admin.Location = new System.Drawing.Point(469, 448);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(114, 38);
            this.btn_admin.TabIndex = 8;
            this.btn_admin.Text = "Admin";
            this.btn_admin.UseVisualStyleBackColor = false;
            this.btn_admin.Click += new System.EventHandler(this.Btn_admin_Click);
            // 
            // btn_addTObasket
            // 
            this.btn_addTObasket.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_addTObasket.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_addTObasket.Location = new System.Drawing.Point(549, 268);
            this.btn_addTObasket.Name = "btn_addTObasket";
            this.btn_addTObasket.Size = new System.Drawing.Size(180, 38);
            this.btn_addTObasket.TabIndex = 9;
            this.btn_addTObasket.Text = "Add to basket";
            this.btn_addTObasket.UseVisualStyleBackColor = false;
            this.btn_addTObasket.Click += new System.EventHandler(this.Btn_addTObasket_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(751, 512);
            this.Controls.Add(this.btn_addTObasket);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grBox_Search);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grBox_Search.ResumeLayout(false);
            this.grBox_Search.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grBox_Search;
        private System.Windows.Forms.ComboBox cb_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btn_addTObasket;
    }
}

