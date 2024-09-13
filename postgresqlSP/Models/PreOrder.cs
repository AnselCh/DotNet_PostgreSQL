namespace Postgresql_API.Models
{
    public class PreOrder
    {
        public int Id { get; set; } // 主鍵屬性

        public string Email { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Contact { get; set; } = string.Empty;
        public string Product { get; set; } = string.Empty;
        public int Count { get; set; } = 0;
        public string Remark { get; set; } = string.Empty;
        public bool IsCheck { get; set; } = false;
    }
}
