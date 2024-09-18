namespace RestWithASPNETUdemy.Model
{
    public class Person
    {
        public long Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Adress { get; set; }
        public required string Gender { get; set; }
    }
}
