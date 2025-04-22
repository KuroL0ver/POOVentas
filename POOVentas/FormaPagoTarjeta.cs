namespace POOVentas
{
    public class FormaPagoTarjeta : IFormaPago
    {
        public void Cobrar(decimal total)
        {
            MessageBox.Show("Esperando terminal..");
            MessageBox.Show("El código fue aprobado :3");
        }
    }
}
