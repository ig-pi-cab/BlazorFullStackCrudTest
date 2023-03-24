using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFullStackCrud.Shared
{
    public class Producto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public int Stock { get; set; }
        public string Categoria { get; set; } = string.Empty;
        public ProductoTipo? ProductoTipo { get; set; }
        public int IdProductoTipo { get; set; }
        public string ImgURL { get; set; }
    }
}
