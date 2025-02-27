namespace prjFolhaPagamento
{
    public partial class Form1 : Form
    {
        static public List<Funcionario> ?listaFun;
        static public Folha ?folha;
        public Form1()
        {
            InitializeComponent();
            listaFun = new List<Funcionario>(); // instanciou no construtor do form
            folha = new Folha();

            Funcionario f1 = new Funcionario("123456", "Vitor Cardoso", "509.156.098-00", 'M');
            f1.salarioMensal = 23000.00F;
            listaFun.Add(f1);
            
            Funcionario f2 = new Funcionario("123457", "Leonardo Pipa", "123.456.789-00", 'H');
            f2.salarioHora = 150.00F;
            listaFun.Add(f2);

            Funcionario f3 = new Funcionario("123458", "Thiago Rodrigues", "987.348.231-12", 'M');
            f3.salarioMensal = 25000.00F;
            listaFun.Add(f3);

            Funcionario f4 = new Funcionario("123459", "Miguel Muniz", "029.293.134-22", 'H');
            f4.salarioHora = 275.00F;
            listaFun.Add(f4);

            Funcionario f5 = new Funcionario("123450", "Murilo Guerra", "839.123.213-11", 'H');
            f5.salarioHora = 142.00F;
            listaFun.Add(f5);

            Funcionario f6 = new Funcionario("123451", "Guilherme Lessa", "914.213.413-44", 'M');
            f6.salarioMensal = 27000.00F;
            listaFun.Add(f6);

            Funcionario f7 = new Funcionario("123452", "Icaro Silva", "174.213.312-21", 'M');
            f7.salarioMensal = 23000.00F;
            listaFun.Add(f7);

            listaFun.Sort();
        }

        private Funcionario encontrado;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btBusca_Click(object sender, EventArgs e)
        {
            encontrado = null;
            btOk.Enabled = false;
            txHoras.Enabled = false;
            lbNome.Text = String.Empty;
            
            
            if (txMatricula.Text.Length != 6)
            {
                MessageBox.Show("Matrícula inválida!.");
                return;
            }

            Funcionario busca = new Funcionario(txMatricula.Text, "", "", '?'); // criando objeto para busca 

            if (listaFun != null) 
            {
                listaFun.Sort(); // ordenando 

                int pos = listaFun.BinarySearch(busca);

                if (pos < 0)
                {
                    MessageBox.Show("Matrícula não existe.");
                    return;
                }
                
                encontrado = listaFun[pos];
                btOk.Enabled = true;
                txHoras.Enabled=true;
                lbNome.Text = encontrado.nome;
                
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            int horas;
            float valor;
            if (encontrado.tipo == 'H')
            {
                if (int.TryParse(txHoras.Text, out horas))
                {
                    valor = encontrado.salarioHora * horas;
                }
                else
                {
                    MessageBox.Show("Horas digitadas inválida");
                    return;
                }
            }
            else
            {
                valor = encontrado.salarioMensal;
            }

            Pagamento p = new Pagamento(DateTime.Now, encontrado, valor);
            folha.add(p);

            txRelatorio.Text = folha.relatorio();
            lbTotal.Text = String.Format("{0:###,###,##0.00}", folha.total());

            txHoras.Text = txMatricula.Text = lbNome.Text = "";

            txHoras.Enabled = false;
            btOk.Enabled = false;

        }
    }
}