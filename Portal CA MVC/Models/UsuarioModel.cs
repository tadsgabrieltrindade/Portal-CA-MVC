using System;

namespace Portal_CA_MVC.Models
{
    public class UsuarioModel
    {
        public int id { get; set; }
        public  string Nome { get; set; }
        public string Email { get; set;}
        public DateTime Data_Cadastrada { get; }

        public UsuarioModel() { 
            Data_Cadastrada = DateTime.Now;
        }
    }
}
