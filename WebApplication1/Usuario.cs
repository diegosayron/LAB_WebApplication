using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Foto { get; set; }

        private static List<Usuario> Lista = new List<Usuario>();

        public Usuario() { }
        public Usuario(int id, string nome, string telefone, string sFoto)
        {
            this.Id =id;
            this.Nome = nome;
            this.Telefone = telefone;
            this.Foto = sFoto;
        }

        public void Gravar()
        {
            Lista.Add(this);
        }

        public List<Usuario> Listar()
        {
            return Usuario.Lista;
        }


        public void LimparLista()
        {
            Lista.Clear();
        }
    }
}