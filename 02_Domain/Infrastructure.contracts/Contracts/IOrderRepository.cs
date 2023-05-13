
using proyecto_2ev_practicas;

public interface IOrderRepository{
    List<OrderRepositoryModel> GetOrders();
    OrderRepositoryModel GetOrderByProductId(int id);
    string AddOrder(OrderDto order);

}