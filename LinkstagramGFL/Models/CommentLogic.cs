using LinkstagramGFL.Context;
using LinkstagramGFL.Models.Post.Comment;

namespace LinkstagramGFL.Models
{
    public class CommentLogic
    {

        public CommentDbContext _commentContext { get; set; }
        public CommentLogic(CommentDbContext commentContext)
        {
            _commentContext = commentContext;
        }

        public void AddComment(CommentInfo comment)
        {
            if (_commentContext.Comments.ToList().Find(x => x.Id == comment.Id) == null)
            {
                _commentContext.Comments.Add(comment);
                _commentContext.SaveChanges();
            }
            else
            {
                throw new Exception("The comment is already in the database!");
            }

        }

        public void EditComment(CommentInfo comment)
        {
            var oldComment = _commentContext.Comments.ToList().Find(x => x.Id == comment.Id);
            if (oldComment != null)
            {
                comment.Created = oldComment.Created;
                _commentContext.Comments.Remove(oldComment);
                _commentContext.Comments.Add(comment);
                _commentContext.SaveChanges();
            }
            else
            {
                throw new Exception("The comment isn`t in the database!");
            }

        }

        public void DeleteComment(CommentInfo comment)
        {
            var deleteComment = _commentContext.Comments.ToList().Find(x => x.Id == comment.Id);
            if (deleteComment != null)
            {
                _commentContext.Comments.Remove(deleteComment);
                _commentContext.SaveChanges();
            }
            else
            {
                throw new Exception("The post isn`t in the database!");
            }

        }

        public void AddLike(LikeUnderComment like)
        {
            var _like = _commentContext.LikeDetails.ToList().Find(x => 
                x.Id == like.Id &&
                x.IdOfUser == like.IdOfUser &&
                x.IdOfComment == like.IdOfComment);
            if (_like == null)
            {
                _commentContext.LikeDetails.Add(like);
                _commentContext.SaveChanges();
            }
            else
            {
                throw new Exception("The like is already in the database!");
            }
        }

        public void DeleteLike(LikeUnderComment like)
        {
            var _like = _commentContext.LikeDetails.ToList().Find(x =>
                x.Id == like.Id &&
                x.IdOfUser == like.IdOfUser &&
                x.IdOfComment == like.IdOfComment);
            if (_like != null)
            {
                _commentContext.LikeDetails.Remove(_like);
                _commentContext.SaveChanges();
            }
            else
            {
                throw new Exception("The like isn`t in the database!");
            }
        }
    }
}
