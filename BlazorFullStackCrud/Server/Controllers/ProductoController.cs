using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace BlazorFullStackCrud.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        public static List<ProductoTipo> productoTipos = new List<ProductoTipo> { 
            new ProductoTipo { Id = 1, Name = "Instrumentos de Cuerdas"},
            new ProductoTipo { Id = 2, Name = "Instrumentos de Percusion"},
            new ProductoTipo { Id = 3, Name = "Amplificadores"},
            new ProductoTipo { Id = 4, Name = "Accesorios varios"},

        };

        public static List<Producto> productos = new List<Producto> { 
            //Instrumentos de cuerdas
            new Producto { 
                Id = 1, 
                Name = "Guitarra Electrica", 
                Categoria = "Guitarra", 
                Brand = "Gibson", 
                ImgURL = "https://cdn.shopify.com/s/files/1/0563/1347/9221/products/gearhub_gibson_les_paul_high_performance_hot_pink_fade_2018_body_5x4_0b94fa6a-2f5e-453d-8ea9-b648977a469b_1800x1800.jpg?v=1663000079",
                Model= "LES PAUL HIGH PERFORMANCE HOT PINK SHADE 2018",
                Code = "001", 
                Stock = 30,  
                ProductoTipo = productoTipos[0]
            },
            new Producto {
                Id = 2,
                Name = "Guitarra Acustica",
                Categoria = "Guitarra",
                Brand = "Yamaha",
                ImgURL = "https://cdn.shopify.com/s/files/1/0563/1347/9221/products/gearhub_gibson_les_paul_high_performance_hot_pink_fade_2018_body_5x4_0b94fa6a-2f5e-453d-8ea9-b648977a469b_1800x1800.jpg?v=1663000079",
                Model= "CX40",
                Code = "002",
                Stock = 15,
                ProductoTipo = productoTipos[0]
            },
            new Producto {
                Id = 3,
                Name = "Guitarra Cuerpo Solido",
                Categoria = "Guitarra",
                Brand = "Fender",                
                ImgURL = "https://cdn.shopify.com/s/files/1/0563/1347/9221/products/gearhub_gibson_les_paul_high_performance_hot_pink_fade_2018_body_5x4_0b94fa6a-2f5e-453d-8ea9-b648977a469b_1800x1800.jpg?v=1663000079",
                Model= "STRATOCASTER AMERICAN STANDARD INCA SILVER 1997",
                Code = "003",
                Stock = 10,
                ProductoTipo = productoTipos[0]
            },
            new Producto {
                Id = 4,
                Name = "Bajo Cuatro Cuerdas",
                Categoria = "Bajo",
                Brand = "TAGIMA",
                ImgURL = "https://cdn.shopify.com/s/files/1/0563/1347/9221/products/gearhub_gibson_les_paul_high_performance_hot_pink_fade_2018_body_5x4_0b94fa6a-2f5e-453d-8ea9-b648977a469b_1800x1800.jpg?v=1663000079",
                Model= "Tw-65 Sunburst",
                Code = "004",
                Stock = 30,
                ProductoTipo = productoTipos[1]
            }
            

            // Instrumentos de percusion
            

            //Amplificadores
            

            //Accesorios varios
            
        };
        [HttpGet]
        public async Task<ActionResult<List<Producto>>> GetProductos()
        {
            return Ok(productos);
        }

        [HttpGet("{id}")]
       
        public async Task<ActionResult<Producto>> GetProducto(int id)
        {
            var producto = productos.FirstOrDefault(p => p.Id == id);
            if (producto == null)
            {
                return NotFound("Producto no encontrado");
            }
            return Ok(producto);
        }

    }
}
