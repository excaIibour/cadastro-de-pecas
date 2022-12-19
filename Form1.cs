using System.Globalization;
using System.IO;
using System.Transactions;

namespace Projeto_Final_Poo_Beta
{

    public partial class Form1 : Form
    {
        string nome;
        double altura;
        double diametro;
        double diamInterno;
        string material;
        int codigo;
        double diamcabe;
        double passo ;
        int i = 1;
        int w;
        Peca peca;
        Peca PecaComplexa;
        List<Peca> list = new List<Peca>();
       
        List<string> letras = new List<string>();
        SaveFileDialog sfd = new SaveFileDialog();
        string diretorio;
        string line;

        string a = ""; // nome
        double b = 1; // altura
        double c = 1; // diametro
        string f = ""; // material
        int e = 1; // codigo 
        double d = 1; // diametro interno




        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (caixatexto1.Text == "")
            {
                MessageBox.Show("Digite Algo");
            }
            else
            {
                nome = caixatexto1.Text.ToString();
               
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (caixatexto2.Text == "")
            {
                MessageBox.Show("Digite Algo");
            }

            try
            {
                altura = double.Parse(caixatexto2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite apenas valores numericos", "Digite apenas números");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (caixatexto3.Text == "")
            {
                MessageBox.Show("Digite Algo");
            }
            else
            {
                diametro = double.Parse(caixatexto3.Text);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //ESTE EVENTO ADICIONA O DIAMETRO INTERNO DE PEÇAS
            if (caixatexto3.Text == "")
            {
                MessageBox.Show("Digite Algo");
            }
            else if (caixatexto1.Text.ToString() == "Parafuso" || caixatexto1.Text.ToString() == "parafuso")
            {
                MessageBox.Show("Nao aplicavel a essa peca");

            }
            else if (caixatexto1.Text.ToString() == "rosca mecanica" || caixatexto1.Text.ToString() == "Rosca mecanica")

            {
                MessageBox.Show("Nao aplicavel a essa peca");

            }
            else
            {
                diamInterno = double.Parse(caixatexto7.Text);
            }
           
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (caixatexto1.Text == "")
            {
                MessageBox.Show("Digite Algo");
            }
            else if (caixatexto1.Text.ToString() == "Parafuso" || caixatexto1.Text.ToString() == "parafuso")
            {
                diamcabe = double.Parse(caixatexto5.Text);


            }
            else
            {
                MessageBox.Show("Nao aplicavel a essa peca");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (caixatexto1.Text == "")
            {
                MessageBox.Show("Digite Algo");
            }
            else if (caixatexto1.Text.ToString() == "rosca mecanica" || caixatexto1.Text.ToString() == "Rosca mecanica")
            {
                passo = double.Parse(caixatexto6.Text);


            }
            else if (caixatexto1.Text.ToString() == "Parafuso" || caixatexto1.Text.ToString() == "parafuso")
            {
                passo = double.Parse(caixatexto6.Text);


            }
            else if (caixatexto1.Text.ToString() == "engrenagem" || caixatexto1.Text.ToString() == "Engrenagem")
            {
                passo = double.Parse(caixatexto6.Text);


            }
            else
            {
                MessageBox.Show("Nao aplicavel a essa peca");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Random numAleatorio = new Random();
            codigo = numAleatorio.Next() +i ;


            peca = new Peca(nome, altura, diametro, material, codigo, diamInterno);
            PecaComplexa = new PecaComplex(nome, altura, diametro, material, codigo,diamInterno, diamcabe, passo);
           
            if (caixatexto1.Text.ToString() == "rosca mecanica" || caixatexto1.Text.ToString() == "Rosca mecanica")
            {

                list.Add(PecaComplexa);

            }
            else if (caixatexto1.Text.ToString() == "Parafuso" || caixatexto1.Text.ToString() == "parafuso")
            {

                list.Add(PecaComplexa);

            }
            else if (caixatexto1.Text.ToString() == "engrenagem" || caixatexto1.Text.ToString() == "Engrenagem")
            {

                list.Add(PecaComplexa);

            }
            else
            {
                list.Add(peca);
            }
            for(w=0; i<list.Count; w++)
            {
                if (list[w].Codigo == codigo)
                {
                    peca = new Peca(nome, altura, diametro, material, 4+codigo, diamInterno);
                }
                else
                {

                }
            }
            i++;
            //listBox.DataSource = null; // para o list box
            //listBox.DataSource = nomes;


            

            listBox.DataSource = null; // para o list box
            listBox.DataSource = list; // para o list box


            caixatexto1.Clear();
            caixatexto2.Clear();
            caixatexto3.Clear();
            caixatexto4.Clear();
            caixatexto5.Clear();
            caixatexto6.Clear();
            caixatexto7.Clear();
            caixatexto1.Focus();
            caixatexto2.Focus();
            caixatexto3.Focus();
            caixatexto4.Focus();
            caixatexto5.Focus();
            caixatexto6.Focus();
            caixatexto7.Focus();




        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (caixatexto4.Text == "")
            {
                MessageBox.Show("Digite Algo");
            }
            else
            {
                material = caixatexto4.Text.ToString();
                //listBox.DataSource = null; // para o list box
               // listBox.DataSource = peca.Nome(nome);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // PODE EXCLUIR

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // PODE EXCLUIR
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            list.RemoveAt(listBox.SelectedIndex);
            listBox.DataSource = null;// atualiza datasource
            listBox.DataSource = list;// atualiza datasource



        }

        private void label8_Click(object sender, EventArgs e)
        {
            //Pode excluir
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (textboxmodifica.Text == "")
            {
                MessageBox.Show("Digite Algo");
            }
            else if (list[listBox.SelectedIndex].nome == "rosca mecanica" || list[listBox.SelectedIndex].nome == "Rosca mecanica")
            {
                MessageBox.Show("Nao aplicavel");
            }
            else if (list[listBox.SelectedIndex].nome == "parafuso" || list[listBox.SelectedIndex].nome == "Parafuso")
            {
                MessageBox.Show("Nao aplicavel");
            }

            else if (list[listBox.SelectedIndex].nome == "engrenagem" || nome == "Engrenagem")
            {
                MessageBox.Show("Nao aplicavel");
            }
            else 
            {
               
               
                list[listBox.SelectedIndex].nome = textboxmodifica.Text;
                listBox.DataSource = null; // atualiza datasource
                // para o list box
                listBox.DataSource = list;// atualiza datasource
                textboxmodifica.Clear();
                textboxmodifica.Focus();
            }
                
                
           
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (textboxmodifica.Text == "")
            {
                MessageBox.Show("Digite Algo");
            }
            else
            {

                // list[listBox.SelectedIndex].Alteranome(textboxmodifica.Text.ToString()) = textboxmodifica.Text;
                list[listBox.SelectedIndex].altura = double.Parse(textboxmodifica.Text);
                listBox.DataSource = null;
                //listBox.DataSource = list[listBox.SelectedIndex];
                // para o list box
                listBox.DataSource = list;
                textboxmodifica.Clear();
                textboxmodifica.Focus();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (textboxmodifica.Text == "")
            {
                MessageBox.Show("Digite Algo");
            }
            else
            {

                // list[listBox.SelectedIndex].Alteranome(textboxmodifica.Text.ToString()) = textboxmodifica.Text;
                list[listBox.SelectedIndex].diametro = double.Parse(textboxmodifica.Text);
                listBox.DataSource = null;
                //listBox.DataSource = list[listBox.SelectedIndex];
                // para o list box
                listBox.DataSource = list;
                textboxmodifica.Clear();
                textboxmodifica.Focus();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (textboxmodifica.Text == "")
            {
                MessageBox.Show("Digite Algo");
            }
            else
            {

                // list[listBox.SelectedIndex].Alteranome(textboxmodifica.Text.ToString()) = textboxmodifica.Text;
                list[listBox.SelectedIndex].material = textboxmodifica.Text;
                listBox.DataSource = null;
                //listBox.DataSource = list[listBox.SelectedIndex];
                // para o list box
                listBox.DataSource = list;
                textboxmodifica.Clear();
                textboxmodifica.Focus();
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            /*
            if (TextProcurar.Text == "")
            {
                MessageBox.Show("Digite Algo");
            }
            else
            { 
                listBox.SelectedIndex = listBox.FindString("Peca:" + TextProcurar.Text.ToString());
                // listBox.SelectedIndex = listBox.FindString.list.nome(TextProcurar.Text.ToString());
                TextProcurar.Clear();
                TextProcurar.Focus();
            }

            */

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // linkLabel1.LinkVisited = true;
            //string mystr = "C:\Progra~1\Google\Chrome\Application\chrome.exe";
            //  System.Diagnostics.Process.Start("calc.exe");
            // System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = @"https://www.google.com.br/search?q=" + caixatexto1.Text.ToString(), UseShellExecute = true });
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = @"https://www.google.com.br/search?q=" + list[listBox.SelectedIndex].nome.ToString(), UseShellExecute = true });
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textProcurar2.Text == "")
            {
                MessageBox.Show("Digite Algo");
            }
            else
            {
                listBox.SelectedIndex = listBox.FindString("Codigo: " +textProcurar2.Text.ToString());
                // listBox.SelectedIndex = listBox.FindString.list.nome(TextProcurar.Text.ToString());
                textProcurar2.Clear();
                textProcurar2.Focus();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textboxmodifica.Text == "")
            {
                MessageBox.Show("Digite Algo");
            }
            else if (list[listBox.SelectedIndex].nome == "rosca mecanica" || list[listBox.SelectedIndex].nome == "Rosca mecanica")
            {
                MessageBox.Show("Nao aplicavel");
            }
            else if (list[listBox.SelectedIndex].nome == "parafuso" || list[listBox.SelectedIndex].nome == "Parafuso")
            {
                MessageBox.Show("Nao aplicavel");
            }

            else
            {

                // list[listBox.SelectedIndex].Alteranome(textboxmodifica.Text.ToString()) = textboxmodifica.Text;
                list[listBox.SelectedIndex].diametroInterno = double.Parse(textboxmodifica.Text);
                listBox.DataSource = null;
                //listBox.DataSource = list[listBox.SelectedIndex];
                // para o list box
                listBox.DataSource = list;
                textboxmodifica.Clear();
                textboxmodifica.Focus();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textboxmodifica.Text == "")
            {
                MessageBox.Show("Digite Algo");
            }
            else if (list[listBox.SelectedIndex].nome == "rosca mecanica" || list[listBox.SelectedIndex].nome == "Rosca mecanica")
            {
                MessageBox.Show("Nao aplicavel");
            }

            else if (list[listBox.SelectedIndex].nome == "engrenagem" || nome == "Engrenagem")
            {
                MessageBox.Show("Nao aplicavel");
            }
            else
            {

                // list[listBox.SelectedIndex].Alteranome(textboxmodifica.Text.ToString()) = textboxmodifica.Text;
                list[listBox.SelectedIndex].diamcabe = double.Parse(textboxmodifica.Text);
                listBox.DataSource = null;
                //listBox.DataSource = list[listBox.SelectedIndex];
                // para o list box
                listBox.DataSource = list;
                textboxmodifica.Clear();
                textboxmodifica.Focus();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textboxmodifica.Text == "")
            {
                MessageBox.Show("Digite Algo");
            }
            else
            {

                // list[listBox.SelectedIndex].Alteranome(textboxmodifica.Text.ToString()) = textboxmodifica.Text;
                list[listBox.SelectedIndex].passo = double.Parse(textboxmodifica.Text);
                listBox.DataSource = null;
                //listBox.DataSource = list[listBox.SelectedIndex];
                // para o list box
                listBox.DataSource = list;
                textboxmodifica.Clear();
                textboxmodifica.Focus();
            }
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Arquivo texto | *.txt";
            sfd.ShowDialog();
            StreamWriter sw = new StreamWriter(sfd.FileName);

            if(string.IsNullOrEmpty(sfd.FileName) == false)
            {
                try
                {
                    for (w = 0; w < list.Count; w++)
                    {
                        sw.WriteLine(list.Count());
                        sw.WriteLine(list[w].nome.ToString());
                        sw.WriteLine(list[w].altura.ToString());
                        sw.WriteLine(list[w].diametro.ToString());
                        sw.WriteLine(list[w].material.ToString());
                        sw.WriteLine(list[w].Codigo.ToString());
                        sw.WriteLine(list[w].diametroInterno.ToString());

                    }
                }
                catch(Exception ey)
                {
                    MessageBox.Show("ERROR: " + ey.Message);
                }
            }
            StreamWriter st = new StreamWriter(@"C:\Algo\dire.txt");
            st.Write(sfd.FileName);
            st.Close();

            
            /*
            StreamWriter sw = new StreamWriter(@"C:\Algo\trabpoo.txt");

            for (w = 0; w <list.Count; w++)
            {
                sw.WriteLine(list.Count());
                sw.WriteLine(list[w].nome.ToString());
                sw.WriteLine(list[w].altura.ToString());
                sw.WriteLine(list[w].diametro.ToString());
                sw.WriteLine(list[w].material.ToString());
                sw.WriteLine(list[w].Codigo.ToString());
                sw.WriteLine(list[w].diametroInterno.ToString());

            }
            */
            sw.Close();
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            foreach (string lines in System.IO.File.ReadLines(@"C:\Algo\dire.txt"))
            {
                // line = sr.ReadLine();

                diretorio = lines; 

            }
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt|All Files (*.*)|*.*";
            
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                // caixatexto1.Text = ofd.FileName;
                textProcurar2.Text = ofd.FileName;
                listBox.Text = File.ReadAllText(ofd.FileName);
                // string[] ler = File.ReadAllLines(@"C:\Algo\trabpoo.txt");
                string[] ler = File.ReadAllLines(diretorio);
                
                StreamReader sr = new StreamReader(diretorio);

                foreach (string lines in System.IO.File.ReadLines(diretorio))
                {
                    // line = sr.ReadLine();

                    letras.Add(lines.ToString());

                    i++;

                }
                sr.Close();
                int v = 0;
                int z = 0;

                int loop = int.Parse(letras[0]);
                

                for (w = 0; w < loop; w++)
                    
                {
                    //peca = new Peca(nome, altura, diametro, material, codigo, diamInterno);
                   // peca = new Peca(letras[0 + v].ToString(), double.Parse(letras[1 + v]), double.Parse(letras[2 + v]), letras[3 + v].ToString(), int.Parse(letras[4 + v]), double.Parse(letras[5 + v]) );
                    
                   peca = new Peca(letras[1 + v].ToString(), double.Parse(letras[2 + v]), double.Parse(letras[3 + v]), letras[4 + v].ToString(), int.Parse(letras[5 + v]), double.Parse(letras[6 + v]) );


                    list.Add(peca);


                    listBox.DataSource = null; // para o list box
                    listBox.DataSource = list;

                    v = 7 * (w + 1);

                }
                sr.Close();
            }
               
           
        
        /*
        StreamReader sr = new StreamReader(@"C:\Algo\trabpoo.txt");


        foreach (string lines in System.IO.File.ReadLines(@"C:\Algo\trabpoo.txt"))
        {
           // line = sr.ReadLine();

            letras.Add(lines.ToString());

            i++;

        }
        sr.Close();
        int v = 0;
        for (w = 0; w < 1 ; w++)
        {
            list[w].nome = letras[0+v].ToString(); //0

            bool resultado3 = double.TryParse(letras[1 + v], out b); //1

            list[w].altura = b;
            // ate aqui em cima ta certo

            bool resultado = double.TryParse(letras[2 + v], out c); //2

            list[w].diametro = c;


            list[w].material = letras[3 + v].ToString(); //3


            list[w].Codigo = int.Parse(letras[4 + v]); //4


            bool resultado4 = double.TryParse(letras[5 + v], out d); //5

            list[w].diametroInterno = d;


            listBox.DataSource = null; // para o list box
            listBox.DataSource = letras[w];

            //listBox.DataSource = null; // para o list box
            //listBox.DataSource = list[w]; // para o list box

            v = 6 * (w + 1);

        }
        sr.Close();
        */
    }

        private void textProcurar2_TextChanged(object sender, EventArgs e)
        {

        }

        /* private void button14_Click(object sender, EventArgs e)
         {
             diamInterno = double.Parse(caixatexto7.Text);
         }
        */
        /*
private void button12_Click(object sender, EventArgs e)
{
   if (caixatexto1.Text == "")
   {
       MessageBox.Show("Digite Algo");
   }
   else if (caixatexto1.Text.ToString() == "Parafuso" || caixatexto1.Text.ToString() == "parafuso")
   {
       diamcabe = double.Parse(caixatexto5.Text);


   }
   else 
   {
       MessageBox.Show("Nao aplicavel a essa peca");
   }
}

private void button13_Click(object sender, EventArgs e)
{
   if (caixatexto1.Text == "")
   {
       MessageBox.Show("Digite Algo");
   }
   else if (caixatexto1.Text.ToString() == "rosca" || caixatexto1.Text.ToString() == "Rosca")
   {
       passo = double.Parse(caixatexto6.Text);


   }
   else if (caixatexto1.Text.ToString() == "Parafuso" || caixatexto1.Text.ToString() == "parafuso")
   {
       passo = double.Parse(caixatexto6.Text);


   }
   else if (caixatexto1.Text.ToString() == "engrenagem" || caixatexto1.Text.ToString() == "Engrenagem")
   {
       passo = double.Parse(caixatexto6.Text);


   }
   else
   {
       MessageBox.Show("Nao aplicavel a essa peca");
   }
}
*/
    }
   }
