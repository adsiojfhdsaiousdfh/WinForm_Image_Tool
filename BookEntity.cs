namespace BookManager
{
    /// <summary>
    /// 图书实体类，存储单本书籍所有字段信息
    /// </summary>
    public class BookEntity
    {
        // 图书唯一编号，主键
        public string ISBN { get; set; }
        // 图书名称
        public string BookName { get; set; }
        // 作者名称
        public string Author { get; set; }
        // 图书定价
        public double BookPrice { get; set; }
        // 封面图片本地存储路径
        public string CoverImg { get; set; }
    }
}