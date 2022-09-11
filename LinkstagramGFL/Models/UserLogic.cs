using LinkstagramGFL.Areas.Identity.Data;
using User;
using System.Linq;

namespace LinkstagramGFL.Models
{
    public class UserLogic
    {
        private LinkstagramGFLContext _userContext;

        public UserLogic(LinkstagramGFLContext userContext)
        {
            _userContext = userContext;
            
        }

        public void AddUser(LinkstagramGFLUser user)
        {
            if(_userContext.Users.ToList().Find(x=>x.Id==user.Id && x.UserName==user.UserName)==null)
            {
                _userContext.Users.Add(user);
                _userContext.SaveChanges();
            }
            else
            {
                throw new Exception("The user is already registered!");
            }
        }

        public void EditUser (LinkstagramGFLUser user)
        {
            var oldUser = _userContext.Users.ToList().Find(x => x.Id == user.Id);
            if (oldUser != null)
            {
                user.DateTime = oldUser.DateTime;
                _userContext.Users.Remove(oldUser);
                _userContext.Users.Add(user);
                _userContext.SaveChanges();
            }
            else
            {
                throw new Exception("The user doesn`t exist in the database!");
            }
        }
        
        public void DeleteUser(LinkstagramGFLUser user)
        {
            if (_userContext.Users.ToList().Find(x => x.Id == user.Id && x.UserName == user.UserName) != null)
            {
                _userContext.Users.Remove(user);
                _userContext.SaveChanges();
            }
            else
            {
                throw new Exception("The user doesn`t exist in the database!");
            }
        }

        public void Subscribe(string user, string subscriber)
        { 
            if(_userContext.Subscriptions.ToList().Find(x=>x.IdOfSubscriber==subscriber&& x.IdOfUser == user) == null)
            {
                _userContext.Subscriptions.Add(new Subscription() { IdOfSubscriber = subscriber, IdOfUser=user });
            }
            else
            {
                throw new Exception("The subscription is already registered in the database");
            }
        }

        public List<LinkstagramGFLUser> GetSubscribers( LinkstagramGFLUser user)
        {
            List<string> IdOfSubscribers = _userContext.Subscriptions.ToList().Where(x => x.IdOfUser == user.Id).Select(x => x.IdOfSubscriber).ToList();
            return _userContext.Users.ToList().Where(x =>
            {
                if (IdOfSubscribers.Contains(x.Id))
                {
                    return true;
                }
                return false;
            }).ToList();
        }  
    }
}
