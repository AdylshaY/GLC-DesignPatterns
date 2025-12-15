namespace CompositeDP.API.CompositeEFCore
{
    public interface IOrganization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal GetSalary();
        public int GetCount();
        public void Print(int depth);
    }
}
