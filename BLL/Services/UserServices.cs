using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserServices
    {
        public static object Get()
        {
            return UserRepo.Get();
        }
        public static User Get(int id)
        {
            return UserRepo.Get(id);
        }
    }
}
