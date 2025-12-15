namespace CompositeDP.API.CompositeEFCore
{
    public static class SeedData
    {
        public static void Seed(AppDbContext context)
        {
            var ceo = new Employee { Id = 1, Name = "Alice", Salary = 120000, DepartmentId = 1 };
            var headOfEngineering = new Employee { Id = 2, Name = "John", Salary = 110000, DepartmentId = 2 };

            var engineer1 = new Employee { Id = 3, Name = "Charlie", Salary = 80000, DepartmentId = 2 };
            var engineer2 = new Employee { Id = 4, Name = "Diana", Salary = 85000, DepartmentId = 2 };

            var headOfSales = new Employee { Id = 5, Name = "Eve", Salary = 100000, DepartmentId = 3 };

            var salesRep1 = new Employee { Id = 6, Name = "Frank", Salary = 60000, DepartmentId = 3 };
            var salesRep2 = new Employee { Id = 7, Name = "Grace", Salary = 62000, DepartmentId = 3 };

            context.Employees.AddRange(ceo, headOfEngineering, engineer1, engineer2, headOfSales, salesRep1, salesRep2);

            var rootDept = new Department { Id = 1, Name = "Corporate", ParentDepartmentId = null, ManagerId = ceo.Id };
            var engineeringDept = new Department { Id = 2, Name = "Engineering", ParentDepartmentId = 1, ManagerId = headOfEngineering.Id };
            var salesDept = new Department { Id = 3, Name = "Sales", ParentDepartmentId = 1, ManagerId = headOfSales.Id };

            context.Departments.AddRange(rootDept, engineeringDept, salesDept);

            context.SaveChanges();
        }
    }
}
