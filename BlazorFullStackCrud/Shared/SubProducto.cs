using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFullStackCrud.Shared
{
    public class SubProducto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public int Stock { get; set; }

        public Producto? Producto { get; set; }

    }
}
