namespace POOVentas
{
    internal class VentaCortesia : Ventas
    {
        public override decimal CalcularTotal()
        {
            return 0; // La venta de cortesía no tiene costo
        }
    }
    
}
