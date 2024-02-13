namespace PetHouseProject.Data
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientsId { get; set; }
        public Client Clients { get; set; }
        public int PetId { get; set; }
        public Pet Pets { get; set; }
        public string Quantity { get; set; }
        public DateTime DateUpdate { get; set; }
    }
}