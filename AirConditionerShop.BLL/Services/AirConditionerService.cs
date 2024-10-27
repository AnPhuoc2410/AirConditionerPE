using AirConditionerShop.DAL.Entities;
using AirConditionerShop.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditionerShop.BLL.Services
{
    public class AirConditionerService
    {
        private AirConRepository _conRepository = new();

        public List<AirConditioner> GetAllAirConditioner()
        {
            return _conRepository.GetAll();
        }
    }
}
