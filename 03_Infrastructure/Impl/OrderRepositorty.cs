using proyecto_2ev_practicas;

public class OrderRepository : IOrderRepository
{   
    private IDatabaseService _databaseService; 

    public OrderRepository(IDatabaseService databaseService){
        _databaseService = databaseService;
    }

    public List<OrderRepositoryModel> GetOrders()
    {
        return _databaseService.GetOrdersDB();
    }

    public OrderRepositoryModel GetOrderByProductId(int id)
    {
        var order = _databaseService.GetOrderByProductIdDB(id);
        return order;
    }

    public string AddOrder(OrderDto order)
    {
        var newOrder = new OrderRepositoryModel();
        newOrder.id = order.id;
        newOrder.product_id = order.product_id;
        newOrder.date = order.date;
        return _databaseService.AddOrderDB(newOrder);
    }
}
