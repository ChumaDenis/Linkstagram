namespace LinkstagramGFL.Areas.Identity.Data
{
    public class Subscription
    {
        public int Id { get; set; }
        
        public string IdOfUser { get; set; }

        public string IdOfSubscriber { get; set; }

        public DateTime DateTime { get; set; } = DateTime.Now;
    }
}
