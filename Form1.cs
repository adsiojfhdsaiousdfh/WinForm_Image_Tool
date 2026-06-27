using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView_file.View = View.Details;
            listView_file.Columns.Add("文件名", 200);
            listView_file.Columns.Add("大小", 80);
            listView_file.Columns.Add("修改时间", 150);
            ListViewItem testImg = new ListViewItem("test.jpg");
            testImg.SubItems.Add("2048KB");
            testImg.SubItems.Add("2026-06-28 10:00");
            testImg.Tag = Application.StartupPath + "\\test.jpg";
            listView_file.Items.Add(testImg);
        }

        /// <summary>
        /// 加载指定文件夹内所有文件到ListView列表
        /// </summary>
        private void RefreshFileList(string targetFolderPath)
        {
            listView_file.Items.Clear();
            DirectoryInfo dirInfo = new DirectoryInfo(targetFolderPath);
            FileInfo[] fileArray = dirInfo.GetFiles();
            foreach (FileInfo singleFile in fileArray)
            {
                ListViewItem item = new ListViewItem(singleFile.Name);
                item.SubItems.Add((singleFile.Length / 1024).ToString() + "KB");
                item.SubItems.Add(singleFile.LastWriteTime.ToString("yyyy-MM-dd HH:mm"));
                item.Tag = singleFile.FullName;
                listView_file.Items.Add(item);
            }
        }
        private void pictureBox_preview_Click(object sender, EventArgs e)
        {

        }

        private void listView_file_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_file.SelectedItems.Count == 0) return;
            string fullFilePath = listView_file.SelectedItems[0].Tag.ToString();
            string[] allowedImgSuffix = { ".jpg", ".png", ".jpeg", ".bmp" };
            string fileSuffix = Path.GetExtension(fullFilePath).ToLower();
            if (allowedImgSuffix.Contains(fileSuffix))
            {
                // 释放上一张图片内存，防止内存泄漏
                pictureBox_preview.Image?.Dispose();
                pictureBox_preview.Image = Image.FromFile(fullFilePath);
            }
        }

        private void btn_compress_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_file.SelectedItems)
            {
                string fileSourcePath = item.Tag.ToString();
                string suffix = Path.GetExtension(fileSourcePath).ToLower();
                // 只处理jpg/png图片
                if (!new[] { ".jpg", ".png" }.Contains(suffix)) continue;
                Image sourcePicture = Image.FromFile(fileSourcePath);
                Bitmap compressedBitmap = new Bitmap(800, (int)(sourcePicture.Height * 800.0 / sourcePicture.Width));
                Graphics drawCanvas = Graphics.FromImage(compressedBitmap);
                drawCanvas.DrawImage(sourcePicture, 0, 0, 800, compressedBitmap.Height);
                string saveFolder = Path.GetDirectoryName(fileSourcePath);
                string saveFileName = $"compress_{Path.GetFileName(fileSourcePath)}";
                compressedBitmap.Save(Path.Combine(saveFolder, saveFileName));
                // 释放绘图资源
                drawCanvas.Dispose();
                sourcePicture.Dispose();
                compressedBitmap.Dispose();
            }
            MessageBox.Show("选中图片批量压缩操作已全部完成！");
        }

        private void btn_addBook_Click(object sender, EventArgs e)
        {
            DAL_Book dal = new DAL_Book();
            // 第一次运行自动建表
            dal.CreateTable();
            // 封装界面输入数据到实体类
            BookEntity book = new BookEntity()
            {
                ISBN = txt_isbn.Text.Trim(),
                BookName = txt_bookName.Text.Trim(),
                Author = txt_author.Text.Trim(),
                BookPrice = Convert.ToDouble(txt_price.Text.Trim()),
                CoverImg = ""
            };
            // 调用新增方法，判断是否重复ISBN
            bool res = dal.CreateNewBookRecord(book);
            if (res)
                MessageBox.Show("图书新增成功！");
            else
                MessageBox.Show("该ISBN编号已存在，无法重复新增！");
        }

        private void txt_bookName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
