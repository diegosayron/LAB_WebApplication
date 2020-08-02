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
            List<Usuario> lista = new List<Usuario>();
            var usuario = new Usuario();
            usuario.id = Convert.ToInt16(txtId.Text);
            usuario.nome = txtNome.Text;
            usuario.telefone = txtTelefone.Text;
            lista.Add(new Usuario(Convert.ToInt16(txtId.Text), txtNome.Text, txtTelefone.Text));
            grdResultado.DataSource = lista;
            grdResultado.DataBind();
            MostrarLista(true);
        }
    }
}