using AirConditionerShop.DAL.Entities;
using AirConditionerShop.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditionerShop.BLL.Services
{
    public class UserService
    {
        private UserRepository _repository = new();

        public StaffMember? Authenticate(string email, string password)
        {
           return _repository.Login(email, password);
        }

    }
}
