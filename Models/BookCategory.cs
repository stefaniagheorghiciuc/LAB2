namespace Gheorghiciuc_Stefania_Lab2.Models
{
    public class BookCategory
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}
