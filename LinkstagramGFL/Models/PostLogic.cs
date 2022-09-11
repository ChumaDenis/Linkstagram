using LinkstagramGFL.Context;

namespace LinkstagramGFL.Models
{
    public class PostLogic
    {
        public PostDbContext _postContext { get; set; }
        public PostLogic(PostDbContext postContext)
        {
            _postContext= postContext;
        }

       


    }
}
