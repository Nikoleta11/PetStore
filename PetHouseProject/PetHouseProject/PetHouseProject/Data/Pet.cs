namespace PetHouseProject.Data
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PetCategoriesId { get; set; }
        public PetCategory PetCategories { get; set; }
        public int Size { get; set; }
        public string Description { get; set; }
        public string Quantity { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public ICollection<Order> Orders { get; set; }
        public int DateRegister { get; set; }
        public DateTime DateUpdate { get; set; }
        public int ApliedId { get; set; }
        public Aplied Aplieds { get; set; }
    }
}
