using proyecto_2ev_practicas;

public class DatabaseService : IDatabaseService
{
    private readonly DataContext _dataContext; 

    public DatabaseService(DataContext dataContext){
        _dataContext = dataContext;
    }
    public List<ProductRepositoryModel> GetProductsDB()
    {
        return _dataContext.Products.ToList();
    }

    public string SaveProductDB(ProductRepositoryModel productDB)
    {
        if(productDB == null){
            return "Error";
        } else {
            _dataContext.Products.Add(productDB);
            _dataContext.SaveChanges(); 
            return "Product Added";
        }
    }

     public string UpdateProductDB(ProductRepositoryModel productDB)
    {
        var updatedProduct = _dataContext.Products.Where(e => e.product_id == productDB.product_id).FirstOrDefault();
        
        if (updatedProduct == null ) {
            return "Error";
        } else {
            updatedProduct.product_name = productDB.product_name;
            updatedProduct.stock = productDB.stock;
            updatedProduct.url_img = productDB.url_img;
            _dataContext.SaveChanges(); 
            return "Product Updated";
        }
    }

    public string DeleteProductDB(int id)
    {

        var removedProduct = _dataContext.Products.Where(e => e.product_id == id).FirstOrDefault();
        
        if (removedProduct == null ) {
            return "Error";
        } else {
            _dataContext.Remove(removedProduct);
            _dataContext.SaveChanges(); 
            return "Product Removed";
        }
    }
}
