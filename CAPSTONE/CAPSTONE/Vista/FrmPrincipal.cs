using System;
using System.Windows.Forms;

namespace CAPSTONE.Presentacion
{
    public partial class FrmPrincipal : Form
    {        
        
        public FrmPrincipal()
        {
            InitializeComponent();            
        }

        private void abrirformulario(Form fh)
        {
            if (this.panelcentral.Controls.Count > 0)
            {
                this.panelcentral.Controls.RemoveAt(0);
            }                
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcentral.Controls.Add(fh);
            this.panelcentral.Tag = fh;
            fh.Show();
        }        

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            FrmLogin l = new FrmLogin();
            l.Visible = true;
            this.Visible = false;
        }

    //    /private void btnpaciente_Click(object sender, EventArgs e)
    //    {
    //        var form = Application.OpenForms.OfType<FrmPaciente>().FirstOrDefault();
    //        FrmPaciente hijo = form ?? new FrmPaciente();
    //        abrirformulario(hijo);
    //    }
    }
}
