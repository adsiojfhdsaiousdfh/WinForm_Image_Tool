namespace BookManager
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView_disk = new System.Windows.Forms.TreeView();
            this.listView_file = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_compress = new System.Windows.Forms.Button();
            this.pictureBox_preview = new System.Windows.Forms.PictureBox();
            this.txt_isbn = new System.Windows.Forms.TextBox();
            this.txt_bookName = new System.Windows.Forms.TextBox();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_bookList = new System.Windows.Forms.DataGridView();
            this.btn_addBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bookList)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView_disk
            // 
            this.treeView_disk.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView_disk.Location = new System.Drawing.Point(0, 0);
            this.treeView_disk.Name = "treeView_disk";
            this.treeView_disk.Size = new System.Drawing.Size(121, 796);
            this.treeView_disk.TabIndex = 0;
            // 
            // listView_file
            // 
            this.listView_file.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_file.HideSelection = false;
            this.listView_file.Location = new System.Drawing.Point(149, 0);
            this.listView_file.Name = "listView_file";
            this.listView_file.Size = new System.Drawing.Size(260, 380);
            this.listView_file.TabIndex = 1;
            this.listView_file.UseCompatibleStateImageBehavior = false;
            this.listView_file.SelectedIndexChanged += new System.EventHandler(this.listView_file_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "文件名";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "大小";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "修改时间";
            // 
            // btn_compress
            // 
            this.btn_compress.Location = new System.Drawing.Point(344, 401);
            this.btn_compress.Name = "btn_compress";
            this.btn_compress.Size = new System.Drawing.Size(166, 23);
            this.btn_compress.TabIndex = 2;
            this.btn_compress.Text = "批量压缩选中图片";
            this.btn_compress.UseVisualStyleBackColor = true;
            this.btn_compress.Click += new System.EventHandler(this.btn_compress_Click);
            // 
            // pictureBox_preview
            // 
            this.pictureBox_preview.Location = new System.Drawing.Point(436, 0);
            this.pictureBox_preview.Name = "pictureBox_preview";
            this.pictureBox_preview.Size = new System.Drawing.Size(320, 240);
            this.pictureBox_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_preview.TabIndex = 3;
            this.pictureBox_preview.TabStop = false;
            this.pictureBox_preview.Click += new System.EventHandler(this.pictureBox_preview_Click);
            // 
            // txt_isbn
            // 
            this.txt_isbn.Location = new System.Drawing.Point(588, 258);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.Size = new System.Drawing.Size(153, 25);
            this.txt_isbn.TabIndex = 8;
            // 
            // txt_bookName
            // 
            this.txt_bookName.Location = new System.Drawing.Point(588, 298);
            this.txt_bookName.Name = "txt_bookName";
            this.txt_bookName.Size = new System.Drawing.Size(153, 25);
            this.txt_bookName.TabIndex = 9;
            this.txt_bookName.TextChanged += new System.EventHandler(this.txt_bookName_TextChanged);
            // 
            // txt_author
            // 
            this.txt_author.Location = new System.Drawing.Point(588, 329);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(153, 25);
            this.txt_author.TabIndex = 10;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(588, 364);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(153, 25);
            this.txt_price.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "ISBN ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "书名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = " 作者";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "价格";
            // 
            // dgv_bookList
            // 
            this.dgv_bookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bookList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_bookList.Location = new System.Drawing.Point(121, 646);
            this.dgv_bookList.Name = "dgv_bookList";
            this.dgv_bookList.RowHeadersWidth = 51;
            this.dgv_bookList.RowTemplate.Height = 27;
            this.dgv_bookList.Size = new System.Drawing.Size(679, 150);
            this.dgv_bookList.TabIndex = 16;
            // 
            // btn_addBook
            // 
            this.btn_addBook.Location = new System.Drawing.Point(556, 401);
            this.btn_addBook.Name = "btn_addBook";
            this.btn_addBook.Size = new System.Drawing.Size(157, 23);
            this.btn_addBook.TabIndex = 17;
            this.btn_addBook.Text = "新增图书";
            this.btn_addBook.UseVisualStyleBackColor = true;
            this.btn_addBook.Click += new System.EventHandler(this.btn_addBook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 796);
            this.Controls.Add(this.btn_addBook);
            this.Controls.Add(this.dgv_bookList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.txt_bookName);
            this.Controls.Add(this.txt_isbn);
            this.Controls.Add(this.pictureBox_preview);
            this.Controls.Add(this.btn_compress);
            this.Controls.Add(this.listView_file);
            this.Controls.Add(this.treeView_disk);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView_disk;
        private System.Windows.Forms.ListView listView_file;
        private System.Windows.Forms.Button btn_compress;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.PictureBox pictureBox_preview;
        private System.Windows.Forms.TextBox txt_isbn;
        private System.Windows.Forms.TextBox txt_bookName;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_bookList;
        private System.Windows.Forms.Button btn_addBook;
    }
}

