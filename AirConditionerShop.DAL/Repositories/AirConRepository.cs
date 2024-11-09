using AirConditionerShop.DAL.Entities;
using Microsoft.EntityFrameworkCore;
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
            _context = new();
            //return _context.AirConditioners.ToList(); //SELECT * FROM AIR CONDITIONER
            return _context.AirConditioners.Include("Supplier").ToList();//SELECT * FROM AIRE CONDITIONER JOIN Supplier   
        }
        public void Create(AirConditioner obj)
        {
            _context = new();
            _context.AirConditioners.Add(obj);
            _context.SaveChanges();
        }
        public void Update(AirConditioner obj)
        {
            _context = new();
            _context.AirConditioners.Update(obj);
            _context.SaveChanges();
        }
        public void Delete(AirConditioner obj)
        {
            _context = new();
            _context.AirConditioners.Remove(obj);
            _context.SaveChanges();
        }
        public List<AirConditioner> SearchByFeatureOrQuantity(string feature, int? quantity)
        {
            _context = new();
            List<AirConditioner> result = _context.AirConditioners.Include("Supplier").ToList();
            //Case 1: both is nothing
            if (string.IsNullOrWhiteSpace(feature) && quantity == null)
            {
                return result;
            }
            //Case 2: Both have value
            else if (!string.IsNullOrWhiteSpace(feature) && quantity != null)
            {
                //WHERE mean Foreach in List<AirCon>
                return result.Where(x => x.FeatureFunction.ToLower().Contains(feature.ToLower()) || x.Quantity == quantity).ToList();
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(feature))
                {
                    return result.Where(x => x.FeatureFunction.Contains(feature)).ToList();
                }
                else
                {
                    return result.Where(x => x.Quantity == quantity).ToList();
                }
            }

            return null;
        }

    }
}
