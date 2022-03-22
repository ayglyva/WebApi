using BuisnessLibrary;
using DataAccess.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
      
        private readonly IOrderService service;
        /// <summary>
        /// dependecy injection
        /// </summary>
      
        public OrderController(IOrderService service)
        {
            this.service = service;
        }
        [Route("getAll")]
        [HttpGet]
        public IEnumerable<OrderClass> GetAll()
        {
            var rsp=service.GetAll();
            return rsp;
        }
        [Route("get")]
        [HttpGet]
        public OrderClass Get(int id)
        {
            var rsp=service.Get(id);
            return rsp;
        }

        [Route("create")]
        [HttpPost]
        public void Create(OrderClass orderClass)
        {
            service.Create(orderClass);
        }
        [Route("update")]
        [HttpPut]
        public void Update(OrderClass orderClass)
        {
            service.Update(orderClass);
        }

        [Route("delete")]
        [HttpDelete]
        public void Delete(int id)
        {
            service.Delete(id);
        }

    }
}
