using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        public List<Contato> contatos = new List<Contato>();
        //definiu como pública!!!

        protected void Page_Load(object sender, EventArgs e)
        {
            contatos.Add(new Contato() { Nome = "Diego Sayron", Id = 1 });
            contatos.Add(new Contato() { Nome = "Ingrid Leticia", Id = 2 });
            contatos.Add(new Contato() { Nome = "Danilo Sayron", Id = 3 });
            contatos.Add(new Contato() { Nome = "Lísias Diogo", Id = 4 });
            //contatos.Add("Ingrid");
            //contatos.Add("Danilo");
            //contatos.Add("Diogo");
            ddlContatos.DataSource = contatos;
            ddlContatos.DataValueField = "Id"; //isso corrige o id e nome da tag html sem colocar correto as propriedades id e nome
            ddlContatos.DataTextField = "Nome";//isso corrige o id e nome da tag html sem colocar correto as propriedades id e nome
            ddlContatos.DataBind(); //dispara a acao do objeto, pegar os strings do datasource e exibir.

            GridView1.DataSource = contatos;
            GridView1.DataBind();

            //codigo DOM sao codigos html que interagimos.
            //Innerhtml é um metodo html que o javascript utiliza quando estamos programando DHTML 
            foreach (var valor in contatos)
            {
                selectManual.InnerHtml = "<select>";

                //nao recomendado
                selectManual.InnerHtml += "<option value='" + valor + "' >" + valor + "</ option>" ;
                selectManual.InnerHtml += "</select>";
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Ei, " + TextBox1.Text + "</br>");
            //Response.Write("<script>alert('" + "DIEGO" + "')</script>");
            Response.Write("Olá, " + Request["TextBox1"]);
        }

        private void PreencherLista(List<Usuario> usuario)
        {
            ListView1.DataSource = usuario;
            ListView1.DataBind();
        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            List<Usuario> usuario = new List<Usuario>();
            usuario.Add(new Usuario(Convert.ToInt16(txtId.Text), txtNome.Text, txtTelefone.Text));
            PreencherLista(usuario);
        }

    }


}