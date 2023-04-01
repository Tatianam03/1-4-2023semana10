using System;
using Tarea5BasedeDatos;
using Tarea5BasedeDatos.DAO;
using Tarea5BasedeDatos.Models;

while (true)
{
    Console.WriteLine("Seleccione una opcion del menu");
    Console.WriteLine("1 - Guardar");
    Console.WriteLine("2 - Listar");
    Console.WriteLine("3 - Actualizar");
    Console.WriteLine("4 - Eliminar");
    Console.WriteLine("5 - Salir");
    int op = int.Parse(Console.ReadLine());
    Producto producto = new Producto();
    CrudProductos crudProductos = new CrudProductos();
    switch (op)
    {
        case 1:
           
            Console.WriteLine("Ingrese el nombre del producto");
            producto.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la descripcion");
            producto.Descripcion = Console.ReadLine();
            Console.WriteLine("Ingrese el precio");
            producto.Precio = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Stock");
            producto.Stock = int.Parse(Console.ReadLine());
            crudProductos.guardar(producto);

            break;
        case 2:
            var Lista = crudProductos.Listar();
            foreach(var item in Lista)
            {
                Console.WriteLine($"Id : {item.Id}");
                Console.WriteLine($"Nombre : {item.Nombre}");
                Console.WriteLine($"Descripcion : {item.Descripcion}");
                Console.WriteLine($"Precio : {item.Precio}");
                Console.WriteLine($"Stcok : {item.Stock} /n");
            }
            break;
            case 3:
            Console.WriteLine("Ingrese el Id a actualizar");
            producto.Id = Convert.ToInt32(Console.ReadLine());
            if(crudProductos.Validar(producto) != null)
            {
                Console.WriteLine("Actualizando Nombre");
                producto.Nombre = Console.ReadLine();
                Console.WriteLine("Actualizando Descripcion");
                producto.Descripcion  = Console.ReadLine();
                Console.WriteLine("Actualizando Precio");
                producto.Precio = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Actualizando Stcok");
                producto.Stock = int.Parse(Console.ReadLine());

                crudProductos.Actualizar(producto);
                Console.WriteLine("¡El producto a sido actualizado correctamente!");

            }
            break;
        case 4:
            Console.WriteLine("Ingrese el Id que desee eliminar");
            producto.Id = Convert.ToInt32(Console.ReadLine());
            if(crudProductos.Validar(producto) != null)
            {
                crudProductos.Eliminar(producto);
                Console.WriteLine("¡El producto se elimino correctamente!");
            }
            break;
    }
    Console.WriteLine("¿Desea volver a ejecutar el programa?");
    Console.WriteLine("1 - SI");
    Console.WriteLine("2 - NO");
    int seguir = int.Parse(Console.ReadLine());
    if(seguir != 1)
    {
        break;
    }

}
