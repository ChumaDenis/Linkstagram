namespace LinkstagramGFL.Models.Post.Comment
{
    public class CommentInfo
    {

        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string IdOfPost { get; set; }

        public string IdOfUser { get; set; }
        

        public string Content { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;
    }
}
