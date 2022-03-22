using DataAccess.Model;
using System;
using System.Collections.Generic;


namespace BuisnessLibrary
{
    public interface IOrderService
    {
        public IEnumerable<OrderClass> GetAll();
        public OrderClass Get(int id);
        public void Create(OrderClass orderClass);
        public void Update(OrderClass orderClass);
        public void Delete(int id);
        
    }
}
