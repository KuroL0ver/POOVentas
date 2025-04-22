namespace POOVentas
{
    internal abstract class Ventas
    {
        public decimal Total

        {
            get
            {
                return CalcularTotal();
            }

        }

        //Lista con constructor, los Conceptos son los Productos


        //[] indica para iniciar la lista
        public List<ConceptodeVenta> Conceptos { get; set; } = [];

        public virtual decimal CalcularTotal()
        {
            decimal total = 0.00m;
            foreach (ConceptodeVenta concepto in Conceptos)
            {
                total += concepto.Importe;
            }
            return total;
        }


    }
}
