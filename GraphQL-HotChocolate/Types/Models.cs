namespace GraphQL_HotChocolate.Types
{
    public class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }
        public string Category { get; set; }

        public Author Author { get; set; }
    }

    public class Author
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pronoun { get; set; }

    }

}
