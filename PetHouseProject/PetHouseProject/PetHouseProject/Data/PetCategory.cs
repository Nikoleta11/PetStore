namespace PetHouseProject.Data
{
    public class PetCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateUpdate { get; set; } = DateTime.Now;
        public ICollection<Pet> Pets { get; set; }
    }
}