namespace SuperMercado;
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int cantidad { get; set; }
        public string tipo { get; set; }
        public double precio_unitario { get; set; }
        public bool stock { get; set; }
    }

    public class Seccion
    {
        public string Color {get; set;}
        public int Numero_seccion {get; set; }
        public List<Producto> Productos { get; set; }
    }