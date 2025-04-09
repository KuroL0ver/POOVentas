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
            }
            else
            {
                _venta = new VentaContado();
                this.Text = "Venta de Contado";
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
    }
}
