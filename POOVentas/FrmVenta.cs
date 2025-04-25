namespace POOVentas
{
    public partial class FrmVenta : Form
    {
        //Borramos la Lista que teníamos antes y le pusimos _venta para que sea privada
        private Ventas _venta;

        public FrmVenta(string tipoVenta)
        {
            InitializeComponent();


            if (tipoVenta == "credito")
            {
                _venta = new VentaCredito();
                this.Text = "Venta de Credito";
                TxtCortesia.Text= "Nope";
            }
            else if (tipoVenta == "contado")
            {
                _venta = new VentaContado();
                this.Text = "Venta de Contado";
                TxtCortesia.Text = "Nope";
            }
            else
            {
                _venta = new VentaCortesia();
                this.Text = "Venta de Cortesia";
                TxtCortesia.Text = "Sí";
            }



        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DgvConceptos.DataSource = null;


            ConceptodeVenta concepto = new ConceptodeVenta();
            concepto.Cantidad = Convert.ToInt32(TxtCantidad.Text);
            concepto.Descripcion = TxtDescripcion.Text;
            concepto.ValorUnitario = Convert.ToDecimal(TxtValorUnitario.Text);
            _venta.Conceptos.Add(concepto);

            DgvConceptos.DataSource = _venta.Conceptos;

            //Se agrega Empty, para que se limpie los conceptos que se agregaron
            TxtCantidad.Text = string.Empty;
            TxtDescripcion.Text = string.Empty;
            TxtValorUnitario.Text = string.Empty;
            TxtTotal.Text = _venta.Total.ToString();
            TxtCantidad.Focus();

        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {

        }

        private void BtnEfectivo_Click(object sender, EventArgs e)
        {
            FormaPagoEfectivo efectivo = new FormaPagoEfectivo();
            AplicarPago(efectivo);

        }
        void AplicarPago(IFormaPago formaPago)
        {
            formaPago.Cobrar(_venta.Total);
        }

        private void BtnTarjeta_Click(object sender, EventArgs e)
        {
            FormaPagoTarjeta tarjeta = new FormaPagoTarjeta();
            AplicarPago(tarjeta);
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtCortesia_TextChanged(object sender, EventArgs e)
        {
            if (TxtCortesia.Text.ToLower() == "sí")
            {
                _venta = new VentaCortesia();
                this.Text = "Venta de Cortesía";

            }
            else
            {
                _venta = new VentaContado(); // O el tipo de venta predeterminado
                this.Text = "Venta de Contado";
            }

        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
