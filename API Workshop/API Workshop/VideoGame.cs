namespace API_Workshop
{
    public class VideoGame
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int StudioId { get; set; }
        public virtual Studio Studio { get; set; }
        public int MainCharacterId { get; set; }
        public virtual MainCharacter MainCharacter { get; set; }
        public virtual List<GameTag> Tags { get; set; }
    }
}
