namespace LinkstagramGFL.Models.Post
{
    public class PostInfo
    {
        
        public string Id  { get; set; }= Guid.NewGuid().ToString();

        public string IdOfUser { get; set; }

        public string IdOfImage { get; set; }

        public DateTime DateTime { get; set; } = DateTime.Now;

        public string Signature { get; set; }

    }

}
