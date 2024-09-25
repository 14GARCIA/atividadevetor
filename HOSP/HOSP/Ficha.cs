using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOSP
{
    internal class Ficha
    {
        protected string nome;
        protected string cpf;
        protected string numeroTel;
        protected string email;
        protected string dataNasc;
        protected int dia;
        protected int mes;
        protected int anp;
        protected string cep;
        protected string rua;
        protected string bairro;
        protected string cidade;
        protected string tipoConsulta;
        protected string sintomas;
        protected string tempoSintomas;
        protected string tempCorporal;
        protected double altura;
        protected double peso;
        protected int numeroCasa;
        protected int idade;
        protected string complemento;
        

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string NumeroTel { get; set; }
        public string Email { get; set; }
        public int Idade {  get; set; }

        public string DataNasc {  get; set; } 
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public double Peso {  get; set; }
        public double Altura { get; set; }
        public string Cep {  get; set; }
        public string Rua {  get; set; }    
        public string Bairro { get; set; }
        public string Cidade {  get; set; }
        public int NumeroCasa { get; set; }  
        public string TipoConsulta {  get; set; }
        public string Sintomas {  get; set; }   
        public string TempoSintomas {  get; set; }  
        public string TempCorporal { get; set;}

        public string Complemento { get; set; } 






    }
}
