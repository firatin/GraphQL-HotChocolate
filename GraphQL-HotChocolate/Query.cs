using GraphQL_HotChocolate.Types;

namespace GraphQL_HotChocolate
{
    public class Query
    {
        public Book GetBook() =>
            new Book
            {
                Title = "C# in depth.",
                Price = 10,
                Category= "Computer Programming",
                Author = new Author
                {
                    Name = "Jon",
                    Surname= "Skeet",
                    Pronoun= "jawn skeet"
                }
            };
    }

}
