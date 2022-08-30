namespace API_Workshop
{
    public class Studio
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EmployeeCount { get; set; }
        public virtual List<VideoGame> VideoGames { get; set; }
    }
}