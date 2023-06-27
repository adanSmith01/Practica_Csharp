using System.Text.Json;
using SuperMercado;


internal class Program
{
    private static void Main(string[] args)
    {
       Console.WriteLine("Hola");
       LecturaProductos("productos.json");
    }

    public static void LecturaProductos(string path){
        if(File.Exists(path)){
            using(StreamReader datosSuperMercado = new StreamReader(path))
            {
                var datos_seccion = datosSuperMercado.ReadToEnd();
                Seccion seccion = JsonSerializer.Deserialize<Seccion>(datos_seccion);
                Console.WriteLine("\n========DATOS DEL SUPERMERCADO======\n");
                Console.WriteLine($"Color: {seccion.Color}");
                Console.WriteLine($"Numero: {seccion.Numero_seccion}");
                Console.WriteLine($"Productos:");
                Console.WriteLine("ID\t\t\tNombre\t\t\tCantidad\t\t\tTipo\t\t\tPrecio Unitario");
                foreach(var prod in seccion.Productos){
                    Console.WriteLine($"{prod.id}\t\t\t{prod.nombre}\t\t\t{prod.cantidad}\t\t\t{prod.tipo}\t\t\t{prod.precio_unitario}");
                }
            }
        }


    }
}