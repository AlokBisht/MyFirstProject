namespace AspNetMvcHelloWorld.Models
{
    public class InMemoryRepository : IRepository
    {
        public Message GetMessage()
        {
            return new Message { Greet = "Hello, World!" };
        }
    }
}
