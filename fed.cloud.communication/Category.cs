namespace fed.cloud.communication
{
    public class Category
    {
        public Category()
        {
            Name = string.Empty;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public Category? ParentCategory { get; set; }
    }
}
