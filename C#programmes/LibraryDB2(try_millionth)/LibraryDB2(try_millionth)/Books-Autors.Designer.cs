namespace LibraryDB2_try_millionth_
{
    partial class Books_Autors
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
            this.label1 = new System.Windows.Forms.Label();
            this.DG_Books_Autors = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Books = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.CB_BooksBA = new System.Windows.Forms.ComboBox();
            this.CB_AutorsBA = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Books_Autors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID";
            // 
            // DG_Books_Autors
            // 
            this.DG_Books_Autors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Books_Autors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2});
            this.DG_Books_Autors.Location = new System.Drawing.Point(12, 187);
            this.DG_Books_Autors.Name = "DG_Books_Autors";
            this.DG_Books_Autors.RowHeadersWidth = 51;
            this.DG_Books_Autors.RowTemplate.Height = 24;
            this.DG_Books_Autors.Size = new System.Drawing.Size(562, 251);
            this.DG_Books_Autors.TabIndex = 21;
            this.DG_Books_Autors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Books_Autors_CellClick_1);
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
            this.Column3.HeaderText = "Autors";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Books";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Books
            // 
            this.Books.AutoSize = true;
            this.Books.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Books.Location = new System.Drawing.Point(57, 84);
            this.Books.Name = "Books";
            this.Books.Size = new System.Drawing.Size(62, 24);
            this.Books.TabIndex = 30;
            this.Books.Text = "Books";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(55, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "Autors";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Delete.Location = new System.Drawing.Point(367, 123);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(130, 30);
            this.btn_Delete.TabIndex = 36;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click_1);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(367, 67);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(130, 30);
            this.btn_Update.TabIndex = 35;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(367, 12);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(130, 30);
            this.btn_Insert.TabIndex = 34;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click);
            // 
            // CB_BooksBA
            // 
            this.CB_BooksBA.FormattingEnabled = true;
            this.CB_BooksBA.Location = new System.Drawing.Point(144, 83);
            this.CB_BooksBA.Name = "CB_BooksBA";
            this.CB_BooksBA.Size = new System.Drawing.Size(186, 24);
            this.CB_BooksBA.TabIndex = 39;
            // 
            // CB_AutorsBA
            // 
            this.CB_AutorsBA.FormattingEnabled = true;
            this.CB_AutorsBA.Location = new System.Drawing.Point(144, 12);
            this.CB_AutorsBA.Name = "CB_AutorsBA";
            this.CB_AutorsBA.Size = new System.Drawing.Size(186, 24);
            this.CB_AutorsBA.TabIndex = 40;
            // 
            // Books_Autors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 469);
            this.Controls.Add(this.CB_AutorsBA);
            this.Controls.Add(this.CB_BooksBA);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Books);
            this.Controls.Add(this.DG_Books_Autors);
            this.Controls.Add(this.label1);
            this.Name = "Books_Autors";
            this.Text = "Books_Autors";
            ((System.ComponentModel.ISupportInitialize)(this.DG_Books_Autors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DG_Books_Autors;
        private System.Windows.Forms.Label Books;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.ComboBox CB_BooksBA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ComboBox CB_AutorsBA;
    }
}