using Domain;
using Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductService
    {
        public List<Product> Get()
        {
            using (var context = new ExampleContext())
            {
                return context.Products.Where(x => x.EstaActivo == true).ToList();
            }
        }

        public Product GetById(int id)
        {
            using (var context = new ExampleContext())
            {
                return context.Products.Find(id);
            }
        }

        public void Insert(Product product)
        {
            using (var context = new ExampleContext())
            {
                product.EstaActivo = true;
                product.FechaCreacion = DateTime.Today;
                product.IGV = product.PrecioVenta * 0.18;
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void Update(int id, Product product)
        {
            using (var context = new ExampleContext())
            {
                var prod = context.Products.Find(id);
                prod.Nombre = product.Nombre;
                prod.Descripcion = product.Descripcion;
                prod.PrecioVenta = product.PrecioVenta;
                prod.FechaVencimiento = product.FechaVencimiento;
                prod.IGV = product.PrecioVenta * 0.18;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new ExampleContext())
            {
                var product = context.Products.Find(id);
                product.EstaActivo = false;
                context.SaveChanges();
            }
        }
    }
}
