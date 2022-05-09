namespace ContosoRecipies.Models
{
    public class MongoDatabaseOptions
    {
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
        public string MyProperty { get; set; } = null!;
    }
}
