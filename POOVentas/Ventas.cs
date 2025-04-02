namespace POOVentas
{
    internal abstract class Ventas
    {
        public decimal Total { get; set; }

        //Lista con constructor, los Conceptos son los Productos
        public List<ConceptodeVenta> Conceptos { get; set; } = new List<ConceptodeVenta>();
    }
}
