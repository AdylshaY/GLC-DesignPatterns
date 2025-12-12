namespace PrototypeDP.Models
{
    public class Employee : IClonable<Employee>
    {
        public required string Name { get; set; }
        public int Age { get; set; }
        public required Address Address { get; set; }

        public Employee ShallowCopy()
        {
            return (Employee)this.MemberwiseClone();
        }

        public Employee DeepCopy()
        {
            Employee clone = (Employee)this.MemberwiseClone();
            clone.Address = new Address
            {
                Street = this.Address.Street,
                City = this.Address.City
            };
            return clone;
        }

        public override string ToString()
        {
            return $"{Name}, {Age}, {Address.City}, {Address.Street}";
        }
    }
}