using proyecto_2ev_practicas;

public interface IDatabaseService{
    List<ProductRepositoryModel> GetProductsDB(); 
    string SaveProductDB(ProductRepositoryModel productDB);
    string UpdateProductDB(ProductRepositoryModel productDB);
    string DeleteProductDB(int id);
     List<OrderRepositoryModel> GetOrdersDB();
    OrderRepositoryModel GetOrderByProductIdDB(int id);
    string AddOrderDB(OrderRepositoryModel order);
}