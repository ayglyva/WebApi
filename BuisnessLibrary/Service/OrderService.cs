using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DataAccess;
using DataAccess.Model;

namespace BuisnessLibrary
{
    public class OrderService:IOrderService
    {

        private AppDb db;

        public OrderService(AppDb db)
        {
            this.db = db;
        }

        public IEnumerable<OrderClass> GetAll()
        {
            
            return db.Orders;
            
        }
        public OrderClass Get(int id)
        {
            
            return db.Orders.Find(id);
        }

        public void Create(OrderClass orderClass)
        {
            db.Orders.Add(orderClass);
            db.SaveChanges();
        }
        public void Update(OrderClass orderClass)
        {
            db.Orders.Update(orderClass);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var x= db.Orders.Find(id);

            db.Orders.Remove(x);
            db.SaveChanges();
        }
    }
}
