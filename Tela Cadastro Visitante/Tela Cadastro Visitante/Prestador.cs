using System;
using System.Collections.Generic;
using System.Text;

namespace Tela_Cadastro_Visitante
{
    public class Prestador
    {
        List<string> Nomes = new List<string>();
        List<string> Rg = new List<string>();
        List<string> Telefone = new List<string>();

        public Prestador()
        {
        }

        public Prestador(string nome, string rg, string telefone)
        {
            this.nome = nome;
            this.rg = rg;
            this.telefone = telefone;
        }

        public string nome { get; set; }
        public string rg { get; set; }
        public string telefone { get; set; }
    }

    public static class Cadastrar
    {
        public static List<string> Nomes = new List<string>();
        public static List<string> Rg = new List<string>();
        public static List<string> Telefone = new List<string>();
    }
}

