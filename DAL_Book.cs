using System.Data.SQLite;
using System.Data;
using System.Data.SQLite;

namespace BookManager
{
    /// <summary>
    /// 数据库操作层，封装SQLite所有增删查逻辑
    /// </summary>
    public class DAL_Book
    {
        // 本地SQLite数据库连接字符串，db文件和程序exe同目录
        private readonly string dbConnectStr = "Data Source=bookData.db;Version=3;";

        /// <summary>
        /// 新增图书记录，参数化SQL防止注入，捕获ISBN主键重复异常
        /// </summary>
        /// <param name="bookData">图书实体对象</param>
        /// <returns>true新增成功，false编号重复无法新增</returns>
        public bool CreateNewBookRecord(BookEntity bookData)
        {
            string insertSqlText = @"INSERT INTO BookInfo(ISBN,BookName,Author,Price,CoverImgPath)
                         VALUES(@isbn,@bookName,@author,@price,@coverPath)";
            using (SQLiteConnection dbConn = new SQLiteConnection(dbConnectStr))
            {
                SQLiteCommand sqlCommand = new SQLiteCommand(insertSqlText, dbConn);
                // 绑定参数，杜绝字符串拼接注入漏洞
                sqlCommand.Parameters.AddWithValue("@isbn", bookData.ISBN);
                sqlCommand.Parameters.AddWithValue("@bookName", bookData.BookName);
                sqlCommand.Parameters.AddWithValue("@author", bookData.Author);
                sqlCommand.Parameters.AddWithValue("@price", bookData.BookPrice);
                sqlCommand.Parameters.AddWithValue("@coverPath", bookData.CoverImg);
                try
                {
                    dbConn.Open();
                    int affectDataRows = sqlCommand.ExecuteNonQuery();
                    // 受影响行数大于0代表插入成功
                    return affectDataRows > 0;
                }
                catch (SQLiteException errorInfo)
                {
                    // 捕获主键唯一约束冲突（重复ISBN）
                    if (errorInfo.ResultCode == SQLiteErrorCode.Constraint)
                        return false;
                    // 其他数据库异常向上抛出，窗口弹窗提示用户
                    throw;
                }
            }
        }

        #region 论文AI审核对比代码（原始漏洞代码+修复后代码）
        /// <summary>
        /// AI原始生成漏洞代码：直接拼接字符串，存在SQL注入风险
        /// </summary>
        public DataTable SearchBook_AIOriginal(string bookName, SQLiteConnection conn)
        {
            string searchSql = "SELECT * FROM BookInfo WHERE BookName='" + bookName + "'";
            SQLiteCommand cmd = new SQLiteCommand(searchSql, conn);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        /// <summary>
        /// 人工修复后安全代码：参数化绑定输入文本
        /// </summary>
        public DataTable SearchBook_Fixed(string bookName, SQLiteConnection conn)
        {
            string searchSql = "SELECT * FROM BookInfo WHERE BookName=@targetName";
            SQLiteCommand cmd = new SQLiteCommand(searchSql, conn);
            cmd.Parameters.AddWithValue("@targetName", bookName);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        #endregion

        /// <summary>
        /// 程序首次运行自动创建图书数据表
        /// </summary>
        public void CreateTable()
        {
            string sql = @"CREATE TABLE IF NOT EXISTS BookInfo(
                ISBN TEXT PRIMARY KEY,
                BookName TEXT,
                Author TEXT,
                Price REAL,
                CoverImgPath TEXT
            )";
            using (SQLiteConnection conn = new SQLiteConnection(dbConnectStr))
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }
    }
}