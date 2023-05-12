using proyecto_2ev_practicas;

public class ProductService : IProductsService
{
    private IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository){
        _productRepository = productRepository;
    }

    public List<ProductDto> GetProducts()
    {
        var products = _productRepository.GetProducts();
        var productdtos = new List<ProductDto>(); 
        products.ForEach(e => {
                var product = new ProductDto(); 
                product.id = e.product_id;
                product.name = e.product_name;
                product.stock = e.stock;
                product.url_img = e.url_img;

                productdtos.Add(product);
            }
        );

        return productdtos;
    }

    public string AddProduct(ProductDto product)
    {
        var productrepo = new ProductRepositoryModel();
        productrepo.product_id = product.id;
        productrepo.product_name = product.name;
        productrepo.stock = product.stock;
        productrepo.url_img = product.url_img;
        
        return _productRepository.AddProduct(productrepo);
    }

    public string UpdateProduct(ProductDto product)
    {
        var productrepo = new ProductRepositoryModel();
        productrepo.product_id = product.id;
        productrepo.product_name = product.name;
        productrepo.stock = product.stock;
        productrepo.url_img = product.url_img;
        
        return   _productRepository.UpdateProduct(productrepo);
    }

    public string DeleteProduct(int id)
    {
        return   _productRepository.DeleteProduct(id);
    }
}

