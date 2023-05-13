using proyecto_2ev_practicas;

public class OrderService : IOrderService
{
    private IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository){
        _orderRepository = orderRepository;
    }

    public List<OrderDto> GetOrders()
    {
        var order = _orderRepository.GetOrders();
        var orderdtos = new List<OrderDto>(); 
        order.ForEach(e => {
            var order = new OrderDto();
            order.date = e.date;
            order.id = e.id;
            order.product_id = e.product_id;

            orderdtos.Add(order);
        });

        return orderdtos;
    }
    public OrderDto GetOrderByProductId(int id)
    {
        var productOrder = _orderRepository.GetOrderByProductId(id);
        var orderdto = new OrderDto(); 
        orderdto.date = productOrder.date;
        orderdto.id = productOrder.id;
        orderdto.product_id = productOrder.product_id;

        return orderdto;

    }
    public string AddOrder(OrderDto order)
    {
        var orderrepo = new OrderRepositoryModel();
        orderrepo.product_id = order.product_id;
        orderrepo.id = order.id;
        orderrepo.date = order.date;

        return _orderRepository.AddOrder(order);
    }
}

