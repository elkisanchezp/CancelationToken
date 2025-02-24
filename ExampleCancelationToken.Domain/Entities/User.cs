namespace ExampleCancelationToken.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public DateTime CreateOn { get; set; }

        public DateTime UpdateOn { get; set; }
    }
}
