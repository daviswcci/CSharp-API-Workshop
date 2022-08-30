namespace API_Workshop
{
    public class MainCharacter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual VideoGame VideoGame { get; set; }
    }
}