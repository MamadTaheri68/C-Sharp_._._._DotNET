namespace EFCore_TestProject.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<BookCategory> BookCategories { get; set; }
    }
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookCategory> BookCategories { get; set; }
    }
    public class BookCategory
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
