using Microsoft.AspNetCore.Mvc;

namespace proyecto_2ev_practicas.Controllers;

[ApiController]
[Route("[controller]")]
public class StockController : ControllerBase
{
    private IProductsService _productService;

    public StockController(IProductsService productService){
        _productService = productService;
    }

    [HttpGet(Name = "GetProducts")]
    public ActionResult<List<ProductDto>> GetProducts()
    {
      var products = _productService.GetProducts(); 
      if (products == null) {
        return NotFound(); 
      } else { 
        return Ok(products);
      }
    }

    [HttpPost(Name = "PostProduct")]
    public ActionResult AddProduct(ProductDto product)
    {
      if (product == null) {
        return BadRequest(); 
      }else{
        return Ok(_productService.AddProduct(product)); 
      }
    }

    [HttpPut(Name = "UpdateProduct")]
    public ActionResult UpdateProduct(ProductDto product)
    {
      if (product == null) {
        return BadRequest(); 
      }else{
        return Ok(_productService.UpdateProduct(product)); 
      }
    }

    [HttpDelete(Name = "DeleteProduct")]
    public ActionResult DeleteProduct(int id)
    {
      if (id == null) {
        return BadRequest(); 
      }else{
        return Ok(_productService.DeleteProduct(id)); 
      }
    }
}
