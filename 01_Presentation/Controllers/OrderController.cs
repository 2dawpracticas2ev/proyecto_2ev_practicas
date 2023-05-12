using Microsoft.AspNetCore.Mvc;

namespace proyecto_2ev_practicas.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private IOrderService _orderService;

    public OrderController(IOrderService orderService){
        _orderService = orderService;
    }

    [HttpGet(Name = "GetOrders")]
    public ActionResult <List<OrderDto>> GetOrders()
    {
      var orders = _orderService.GetOrders(); 
      if (orders == null) {
        return NotFound(); 
      } else { 
        return Ok(orders);
      }
    }

    [HttpGet]
    [Route("/GetOrdersById{id}")]
    public ActionResult <OrderDto> GetOrderByProductId(int id)
    {
      var productOrder = _orderService.GetOrderByProductId(id); 
      if (productOrder == null) {
        return NotFound(); 
      } else { 
        if (productOrder.product_id == null ) {
          return NotFound();
        }else{
          return Ok(productOrder);
        }
      }
    }

    [HttpPost(Name = "PostOrder")]
    public ActionResult <string> AddOrder(OrderDto order)
    {
      if (order == null) {
        return BadRequest(); 
      }else{
        return Ok(_orderService.AddOrder(order)); 
      }
    }

}
