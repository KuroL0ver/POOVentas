namespace POOVentas
{
    //No esta heredando, solo implementando la interfaz
    internal class FormaPagoEfectivo : IFormaPago
    {
        public void Cobrar(decimal total)
        {
           MessageBox.Show("El total se pagó en efectivo");
        }
    }
   
}
