namespace Restaurant.Domain.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public string? Name { get; set; }
        public bool Status { get; set; }
        public DateTime DateInsert { get; set; }
        public DateTime DateUpdate { get; set; }
    }
}
