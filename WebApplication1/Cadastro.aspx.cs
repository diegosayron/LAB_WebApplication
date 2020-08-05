using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Cadastro : System.Web.UI.Page
    {

        static Usuario usuario;

        protected void Page_Load(object sender, EventArgs e)
        {
            MostrarLista(false);
        }

        private void MostrarLista(bool mostrar)
        {
            pnlResultado.Visible = mostrar;
        }

        private void MostrarCadastro(bool mostrar)
        {
            pnlResultado.Visible = mostrar;
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string caminhoArquivoFisico = (AppDomain.CurrentDomain.BaseDirectory + System.Configuration.ConfigurationManager.AppSettings["caminhoArquivo"] + @"\" + fileFoto.FileName).Replace(@"\\", @"\");
            string caminhoArquivoURL = System.Configuration.ConfigurationManager.AppSettings["caminhoArquivo"].Replace(@"\", "/") + "/" + fileFoto.FileName;
            fileFoto.SaveAs(caminhoArquivoFisico.Replace(@"\\",@"\"));
            
            usuario = new Usuario(Convert.ToInt16(txtId.Text), txtNome.Text, txtTelefone.Text, caminhoArquivoURL);
            usuario.Gravar();

            grdResultado.DataSource = usuario.Listar();
            grdResultado.DataBind();
            MostrarLista(true);
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtTelefone.Text = string.Empty;
        }

        protected void Limpar_Click(object sender, EventArgs e)
        {
            usuario.LimparLista();
        }
    }
}