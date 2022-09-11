using LinkstagramGFL.Context;
using LinkstagramGFL.Models.Post;
using LinkstagramGFL.Areas.Identity.Data;

namespace LinkstagramGFL.Models
{
    public class PostLogic
    {
        public PostDbContext _postContext { get; set; }
        public PostLogic(PostDbContext postContext)
        {
            _postContext= postContext;
        }

        public void AddNewPost(PostInfo post)
        {
            if (_postContext.Posts.ToList().Find(x => x.Id == post.Id) == null)
            {
                _postContext.Posts.Add(post);
                _postContext.SaveChanges();
            }
            else
            {
                throw new Exception("The post is already in the database!");
            }
            
        }

        public void EditNewPost(PostInfo post)
        {
            var oldPost = _postContext.Posts.ToList().Find(x => x.Id == post.Id);
            if (oldPost != null)
            {
                post.DateTime = oldPost.DateTime;
                _postContext.Posts.Remove(oldPost);
                _postContext.Posts.Add(post);
                _postContext.SaveChanges();
            }
            else
            {
                throw new Exception("The post isn`t in the database!");
            }

        }

        public void DeleteNewPost(PostInfo post)
        {
            var deletePost = _postContext.Posts.ToList().Find(x => x.Id == post.Id);
            if (deletePost != null)
            {
                _postContext.Posts.Remove(deletePost);
                _postContext.SaveChanges();
            }
            else
            {
                throw new Exception("The post isn`t in the database!");
            }

        }

        public void AddLike(LikeDetails like)
        {
            var _like = _postContext.LikeDetails.ToList().Find(x => x.Id == like.Id &&
            x.IdOfUser == like.IdOfUser &&
            x.IdOfPost == like.IdOfPost);
            if(_like == null)
            {
                _postContext.LikeDetails.Add(like);
                _postContext.SaveChanges();
            }
            else
            {
                throw new Exception("The like is already in the database!");
            }
        }

        public void DeleteLike(LikeDetails like)
        {
            var _like = _postContext.LikeDetails.ToList().Find(x => 
                x.Id == like.Id &&
                x.IdOfUser == like.IdOfUser &&
                x.IdOfPost == like.IdOfPost);
            if (_like != null)
            {
                _postContext.LikeDetails.Remove(_like);
                _postContext.SaveChanges();
            }
            else
            {
                throw new Exception("The like isn`t in the database!");
            }
        }

    }
}
