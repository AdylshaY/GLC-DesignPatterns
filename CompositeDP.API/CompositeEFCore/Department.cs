namespace CompositeDP.API.CompositeEFCore
{
    public class Department : IOrganization
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? ParentDepartmentId { get; set; }
        public virtual Department? ParentDepartment { get; set; }

        public int ManagerId { get; set; }
        public virtual Employee Manager { get; set; } = null!;

        public virtual List<Employee> Employees { get; set; } = [];
        public virtual List<Department> SubDepartments { get; set; } = [];

        public decimal GetSalary()
        {
            decimal totalSalary = Employees.Sum(e => e.GetSalary());
            totalSalary += SubDepartments.Sum(d => d.GetSalary());
            return totalSalary;
        }

        public int GetCount()
        {
            return Employees.Count + SubDepartments.Sum(d => d.GetCount());
        }

        public void Print(int depth = 0)
        {
            string indent = new string(' ', depth * 4);

            Console.WriteLine($"{indent}- Department: {Name}");
            Console.WriteLine($"{indent}   └─ Manager: {Manager.Name} ({Manager.Department}) - Salary: {Manager.Salary:C}");
            Console.WriteLine($"{indent}   └─ Total Salary: {GetSalary():C}");
            Console.WriteLine($"{indent}   └─ Total Members: {GetCount()}");

            if (Employees.Count > 0)
            {
                Console.WriteLine($"{indent}   └─ Employees:");
                foreach (var employee in Employees)
                {
                    employee.Print(depth + 2);
                }
            }

            if (SubDepartments.Count > 0)
            {
                Console.WriteLine($"{indent}   └─ Sub-Departments:");
                foreach (var subDept in SubDepartments)
                {
                    subDept.Print(depth + 2);
                }
            }

            if (depth == 0)
            {
                Console.WriteLine(new string('═', 60));
            }
        }
    }
}
