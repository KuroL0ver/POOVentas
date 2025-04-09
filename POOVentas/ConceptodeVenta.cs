namespace POOVentas
{
    class ConceptodeVenta
    {

        //get kectura y scritura es set
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Importe
        {
            //se pone get, porque lo anda leyendo 
            get
            {
                return CalcularImporte();
             
            }

        }

        private decimal CalcularImporte()
        {
            return Cantidad * ValorUnitario;
        }
    }
}
