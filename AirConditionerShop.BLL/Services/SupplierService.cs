using AirConditionerShop.DAL.Entities;
using AirConditionerShop.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditionerShop.BLL.Services
{
    public class SupplierService
    {
        private SupplierRepository _repository = new();
         
        public List<SupplierCompany> GetAllSupplier()
        {
            return _repository.GetAll();
        }
    }
}
