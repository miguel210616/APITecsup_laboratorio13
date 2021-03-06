using APITecsup_laboratorio13.Models.Request;
using APITecsup_laboratorio13.Models.Response;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace APITecsup_laboratorio13.Controllers
{
    public class ProductsController : ApiController
    {
        // GET: Products
         public List<ProductResponse> Get()
        {

            var service = new ProductService();
            var products = service.Get();

            var response = products.Select(x => new ProductResponse
            {
                Nombre = x.Nombre,
                Descripcion =x.Descripcion,
                PrecioVenta=x.PrecioVenta,
                FechaVencimiento=x.FechaVencimiento,
                IGV=x.IGV
            }).ToList(); 

            return response;
        }

        [HttpPost]
        public ProductResponse GetById(int id)
        {
            var service = new ProductService();
            var product = service.GetById(id);

            var response = new ProductResponse
            {
                Nombre = product.Nombre,
                Descripcion = product.Descripcion,
                PrecioVenta = product.PrecioVenta,
                FechaVencimiento = product.FechaVencimiento,
                IGV = product.IGV
            };

            return response;
        }

        [HttpPost]
        public bool Insert(ProductRequest request)
        {
            var response = true;
            try
            {
                var service = new ProductService();
                service.Insert(new Domain.Product
                {
                    Nombre = request.Nombre,
                    Descripcion = request.Descripcion,
                    PrecioVenta = request.PrecioVenta,
                    FechaVencimiento = request.FechaVencimiento,
                });
            }
            catch (Exception)
            {
                response = false;
            }
            return response;
        }

        [HttpPost]
        public bool Update(int id, ProductRequest request)
        {
            var response = true;
            try
            {
                var service = new ProductService();
                service.Update(id, new Domain.Product
                {
                    Nombre = request.Nombre,
                    Descripcion = request.Descripcion,
                    PrecioVenta = request.PrecioVenta,
                    FechaVencimiento = request.FechaVencimiento,
                });
            }
            catch (Exception)
            {
                response = false;
            }
            return response;
        }

        [HttpPost]
        public void Delete(int id)
        {
            var service = new ProductService();
            service.Delete(id);

        }

    }
}