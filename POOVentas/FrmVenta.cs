namespace POOVentas
{
    public partial class FrmVenta : Form
    {
        List<ConceptodeVenta> conceptos;
        public FrmVenta()
        {
            InitializeComponent();
            conceptos = new List<ConceptodeVenta>();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DgvConceptos.DataSource = null;

            

            ConceptodeVenta concepto = new ConceptodeVenta();
            concepto.Cantidad = Convert.ToInt32(TxtCantidad.Text);
            concepto.Descripcion = TxtDescripcion.Text;
            concepto.ValorUnitario = Convert.ToDecimal(TxtValorUnitario.Text);
            conceptos.Add(concepto);

            DgvConceptos.DataSource = conceptos;

        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {

        }
    }
}
