namespace API_Workshop
{
    public class GameTag
    {
        public int Id { get; set; }
        public int VideoGameId { get; set; }
        public virtual VideoGame VideoGame { get; set; }
        public int TagId { get; set; }
        public virtual Tag Tag { get; set; }
    }
}