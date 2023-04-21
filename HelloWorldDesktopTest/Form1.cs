namespace HelloWorldDesktopTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            lbxDados.Items.Add($"{txtNome.Text} | {txtEndereco.Text} | {txtComplemento.Text} | {txtNumero.Text}");
            txtNome.ResetText();
            txtEndereco.ResetText();
            txtComplemento.ResetText();
            txtNumero.ResetText();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lbxDados.Items.Clear();
        }

        private void pbxCorFundo_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();

            if(colorPicker.ShowDialog() == DialogResult.OK)
            {
                pbxCorFundo.BackColor = colorPicker.Color;
                panel1.BackColor = colorPicker.Color;
            }
        }
    }
}