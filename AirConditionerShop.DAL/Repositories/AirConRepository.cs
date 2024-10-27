using AirConditionerShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditionerShop.DAL.Repositories
{
    public class AirConRepository
    {
        private AirConditionerShop2024DbContext _context;

        public List<AirConditioner> GetAll()
        {
            _context = new AirConditionerShop2024DbContext();
            return _context.AirConditioners.ToList();
        }
    }
}
