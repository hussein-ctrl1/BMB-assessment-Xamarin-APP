using BMB_asseessment_Xamarin_App_Web_API.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BMB_asseessment_Xamarin_App_Web_API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly MockData MockData = new MockData();
        // GET: api/<OrderController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return MockData.GetOrders();
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return MockData.GetOrders().FirstOrDefault(obj =>obj.OrderID==id);
        }

        // POST api/<OrderController>
        [HttpPost]
        public async Task<string> Post([FromBody] Order order)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    MockData.GetOrders().Add(order);
                    return await Task.FromResult("Order is Added Successfully");
                }
                catch(Exception ex)
                {
                    return await Task.FromResult(ex.Message);
                }
            }
            else { return await Task.FromResult("Order is Not Added Successfully");  }
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public async Task<string> Put(int id, [FromBody] Order order)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    MockData.GetOrders().Where(obj => obj.OrderID == id).Select(updatedObj => { updatedObj = order; return updatedObj; }).ToList();
                    return await Task.FromResult("Order is Updated Successfully");
                }
                catch (Exception ex)
                {
                    return await Task.FromResult(ex.Message);
                }
            }
            else { return await Task.FromResult("Order is Not Updated Successfully"); }
        }

        [HttpDelete("{id}")]
        public async Task<string> Delete(int id)
        {
            try
            {
                MockData.GetOrders().RemoveAll((deletedObj) => deletedObj.OrderID == id);
                return await Task.FromResult("Order is Updated Successfully");
            }
            catch (Exception ex)
            {
                return await Task.FromResult(ex.Message);
            }
        }
    }
}
