namespace PetHouseProject.Data
{
    public class Aplied
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Pet> Pets { get; set; }
    }
}