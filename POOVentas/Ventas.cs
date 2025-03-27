namespace POOVentas
{
    internal abstract class Ventas
    {
        public decimal Total { get; set; }

        //Lista con constructor, los Conceptos son los Productos
        List<ConceptodeVenta> Conceptos { get; set; } = new List<ConceptodeVenta>();
    }
}
