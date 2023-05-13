using proyecto_2ev_practicas;

public interface IOrderService
{
    List<OrderDto> GetOrders(); 
    OrderDto GetOrderByProductId(int id); 
    string AddOrder(OrderDto order);

}