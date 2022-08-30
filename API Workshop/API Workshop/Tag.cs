namespace API_Workshop
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<GameTag> VideoGames { get; set; }
    }
}