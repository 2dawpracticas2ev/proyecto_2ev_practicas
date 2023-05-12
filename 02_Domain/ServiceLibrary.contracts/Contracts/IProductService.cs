using proyecto_2ev_practicas;

public interface IProductsService
{
    List<ProductDto> GetProducts(); 
    string AddProduct(ProductDto product); 
    string UpdateProduct(ProductDto product);

    string DeleteProduct(int id);
}