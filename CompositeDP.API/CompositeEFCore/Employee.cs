namespace CompositeDP.API.CompositeEFCore
{
    public class Employee : IOrganization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public virtual Department Department { get; set; } = null!;
        public int DepartmentId { get; set; }

        public decimal GetSalary()
        {
            return Salary;
        }

        public int GetCount()
        {
            return 1;
        }

        public void Print(int depth = 0)
        {
            string indent = new string(' ', depth * 4);
            Console.WriteLine($"{indent}- {Name} ({Department.Name}) - Salary: {Salary:C}");
        }
    }
}
