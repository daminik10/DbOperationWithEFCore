namespace DbOperationWithEFCore.Data
{
    public class Language
    {
        public int id { get; set; }
        public int Title { get; set; }
        public int Description { get; set; }

        public ICollection<Book> Book { get; set;}

    }
}
