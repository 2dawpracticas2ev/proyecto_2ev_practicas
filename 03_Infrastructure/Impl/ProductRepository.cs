using proyecto_2ev_practicas;

public class ProductRepository : IProductRepository
{   
    private IDatabaseService _databaseService; 

    public ProductRepository(IDatabaseService databaseService){
        _databaseService = databaseService;
    }

    public List<ProductRepositoryModel> GetProducts()
    {
       return _databaseService.GetProductsDB(); 
    }
    public string AddProduct(ProductRepositoryModel productModel)
    {
       return _databaseService.SaveProductDB(productModel); 
    }
    public string UpdateProduct(ProductRepositoryModel productModel)
    {
       return _databaseService.UpdateProductDB(productModel); 
    }

    public string DeleteProduct(int id)
    {
        var test = _databaseService.DeleteProductDB(id);
        return test;
    }
}
