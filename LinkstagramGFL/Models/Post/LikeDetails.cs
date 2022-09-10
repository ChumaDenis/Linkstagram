namespace LinkstagramGFL.Models.Post
{
    public class LikeDetails
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string IdOfPost { get; set; }

        public string IdOfUser { get; set; }

        public DateTime DateTime { get; set; }= DateTime.Now;
    }
}
