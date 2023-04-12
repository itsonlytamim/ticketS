using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class UserRepo
    {
        static UserContext _usrContext;

        static UserRepo()
        {
            _usrContext = new UserContext();
        }

        public static List<User> Get()
        {
            return _usrContext.Users.ToList();
        }

        public static User Get(int id)
        {
            return _usrContext.Users.Find(id);
        }


        public static bool Create(User user)
        {
            _usrContext.Users.Add(user);
            return _usrContext.SaveChanges()>0;
        }

        public static bool Update(User user)
        {
            var exemp = _usrContext.Users.Find(user.Id);
            _usrContext.Entry(exemp).CurrentValues.SetValues(user);
            return _usrContext.SaveChanges() > 0;
        }

        public static bool DeleteUser(int id)
        {
            var exemp = Get(id);
            _usrContext.Users.Remove(exemp);
            return _usrContext.SaveChanges() > 0;
        }
    }
    }
