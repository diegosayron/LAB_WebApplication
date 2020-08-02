using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Usuario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }

        private static List<Usuario> Lista = new List<Usuario>();

        public Usuario() { }
        public Usuario(int Id, string Nome, string Telefone)
        {
            this.id = id;
            this.nome = Nome;
            this.telefone = Telefone;
        }

        public void Gravar()
        {
            Lista.Add(this);
        }

        public List<Usuario> Listar()
        {
            return Usuario.Lista;
        }
    }
}