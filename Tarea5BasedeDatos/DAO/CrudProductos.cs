using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea5BasedeDatos.Models;

namespace Tarea5BasedeDatos.DAO
{
    public class CrudProductos
    {
        public void guardar(Producto paramProducto)
        {
            using(AlmacenContext bd = new AlmacenContext())
            {
                Producto producto = new Producto();
                producto.Nombre = paramProducto.Nombre;
                producto.Descripcion = paramProducto.Descripcion;
                producto.Precio = paramProducto.Precio;
                producto.Stock = paramProducto.Stock;
                bd.Add(producto);
                bd.SaveChanges();
                Console.WriteLine("¡Su producto a sido ingresado correctamente!");
            }
        }
        public List<Producto> Listar()
        {
            using(AlmacenContext db = new AlmacenContext())
            {
                var Lista = db.Productos.ToList();
                return Lista;
            }
        }
        public Producto Validar(Producto paramProducto)
        {
            using (AlmacenContext db = new AlmacenContext())
            {
                var Busacr = db.Productos.FirstOrDefault(x => x.Id == paramProducto.Id);
                return Busacr;
            }
        }
        public void Actualizar(Producto paramProducto)
        {
            using (AlmacenContext db = new AlmacenContext())
            {
                db.Update(paramProducto);
                db.SaveChanges();
            }
        }
        public void Eliminar(Producto paramProducto)
        {
            using (AlmacenContext db = new AlmacenContext())
            {
                db.Remove(paramProducto);
                db.SaveChanges();
            }
        }
    }
}
