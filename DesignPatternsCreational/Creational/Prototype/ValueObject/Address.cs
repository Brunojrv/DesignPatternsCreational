namespace DesignPatternsCreational.Creational.Prototype.ValueObject
{
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }

        public Address(string city, string street)
        {
            City = city;
            Street = street;
        }

        public Address Clone()
        {
            return new Address(City, Street);
        }
    }
}
