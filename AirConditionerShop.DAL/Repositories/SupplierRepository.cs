using AirConditionerShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditionerShop.DAL.Repositories
{
    public class SupplierRepository
    {
        AirConditionerShop2024DbContext _context;

        public List<SupplierCompany> GetAll()
        {
            _context = new();
           return _context.SupplierCompanies.ToList();
        }
    }
}
