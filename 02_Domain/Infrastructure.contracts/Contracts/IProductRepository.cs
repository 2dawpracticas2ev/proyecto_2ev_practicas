
using proyecto_2ev_practicas;

public interface IProductRepository{
    List<ProductRepositoryModel> GetProducts();
    string AddProduct(ProductRepositoryModel productModel); 
    string UpdateProduct(ProductRepositoryModel productModel);
    string DeleteProduct(int id);

}