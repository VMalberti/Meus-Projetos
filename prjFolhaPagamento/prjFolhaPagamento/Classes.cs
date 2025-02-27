using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFolhaPagamento
{
   public class Funcionario : IComparable<Funcionario> 
    {
        public String matricula { get; private set; }
        public String nome { get; private set; }
        public String cpf { get; private set; }
        public char tipo { get; private set; }  // 'M' Mensalista, 'H' Horista

        public Funcionario(string matricula, string nome, string cpf, char tipo)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.cpf = cpf;
            this.tipo = tipo;
           
        }

        public float salarioMensal { get; set; }
        public float salarioHora { get; set; }
             
        public int CompareTo(Funcionario? f)
        {
            if (f == null) return 1;
            
           return matricula.CompareTo(f.matricula);   
        }
    }

    public class Pagamento : IComparable<Pagamento>
    {
        public int CompareTo(Pagamento ?p)
        {
            if (p == null) return 1;

            return funcionario.CompareTo(p.funcionario); // Comparando funcionário c funcionário (matrícula) CompareTo do funcionário 
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}, {4:###,###,##0,00}", funcionario.matricula, funcionario.nome, funcionario.cpf, funcionario.tipo, valor);
        }
        public Funcionario funcionario { get; private set; } // funcionario de pagamento comparado com funcionario de Funcionario 
        public float valor { get; set; }
        public DateTime data { get; set; }  

        public Pagamento (DateTime data, Funcionario funcionario, float valor)
        {
            this.data = data;
            this.funcionario = funcionario;
            this.valor = valor;
        }

   
    }

    public class Folha
    {
        private List<Pagamento> lista; 

        public Folha()
        {
            lista = new List<Pagamento>();  
        }

        public void add (Pagamento p)
        {
            lista.Add(p);   
            lista.Sort(); 
        }

        public float total()
        {
            float sum = 0; 
            foreach (Pagamento p in lista)
            {
                sum += p.valor;
            }
            return sum;
        }

        public String relatorio()
        {
            StringBuilder sb = new StringBuilder(); 
            foreach (Pagamento p in lista)
            {
                sb.AppendLine(p.ToString()); // transforma p (pagamento) em linha
            }
            return sb.ToString();   
        }

    }
}

