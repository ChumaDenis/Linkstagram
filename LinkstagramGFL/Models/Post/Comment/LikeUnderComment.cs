namespace LinkstagramGFL.Models.Post.Comment
{
    public class LikeUnderComment
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string IdOfComment { get; set; }

        public string IdOfUser { get; set; }

        public DateTime DateTime { get; set; } = DateTime.Now;
    }
}
