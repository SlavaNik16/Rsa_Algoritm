using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http.Headers;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AlgoritmRSA
{
    public partial class Form1 : Form
    {
        private long p,q,f;
        private bool run = true;

      

        public Form1()
        {
            InitializeComponent();
        }
        private void butNotEncrypt_Click(object sender, EventArgs e)
        {
            if (dBox.Text.Length > 0 && nBox.Text.Length > 0)
            {

                BigInteger d = long.Parse(dBox.Text);
                BigInteger n = long.Parse(nBox.Text);
                Console.WriteLine($"d = {d}");
                Console.WriteLine($"ex = {e}");
                List<string> textInput = new List<string>();
                StreamReader sr = new StreamReader("Decode.txt");

                while (!sr.EndOfStream)
                {
                    textInput.Add(sr.ReadLine()); 
                }
                sr.Close();

                string result = Rsa_CodeOff(textInput, d,n);

                StreamWriter sw = new StreamWriter("Encode.txt");
                sw.WriteLine(result);
                sw.Close();

                Process process = new Process();
                process.StartInfo.FileName = "Encode.txt";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                butNotEncrypt.Enabled = false;
                process.Start();
                process.WaitForExit();
                butNotEncrypt.Enabled = true;
            }
            else
            {
                MessageBox.Show("Введите секретный ключ!");
            }
        }

        private void butEncrypt_Click(object sender, EventArgs e)
        {
            
            if (pBox.Text.Length > 0 && qBox.Text.Length > 0)
            {
 
                run = ValidatePBox(pBox.Text,qBox.Text);
                if (run)
                {
                    BigInteger n, d = 3, ex = 3;
                    n = p * q;
                    f = (p - 1) * (q - 1);
                   
                    SimvolE(ref ex);
                    SimvolD(ex, ref d);
                    PublicLabel.Text = $"Открытый ключ(e,n): ({ex},{n})";
                    dBox.Text = d.ToString();
                    nBox.Text = n.ToString();
                    List<string> textOutput = Rsa_CodeOn(ex,n);
                    StreamWriter sw = new StreamWriter("Decode.txt");
                    foreach(var c in textOutput)
                    {
                        sw.WriteLine(c);
                    }
                    sw.Close();
                    Process process = new Process();
                    process.StartInfo.FileName = "Decode.txt";
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                    butEncrypt.Enabled = false;
                    process.Start();             
                    process.WaitForExit();
                    butEncrypt.Enabled = true;
                    run = false;
                }
            }
        }
        private bool ValidatePBox(string c1,string c2)
        {
            if ((!long.TryParse(c1, out  p) || p < 0) ||
                (!long.TryParse(c2, out  q) || q < 0))
            {
                MessageBox.Show("Число не простое!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            for (int i = 2; i <= p/2; i++)
            {
                if (p % i == 0)
                {
                    MessageBox.Show("Число p не простое!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            for (int j = 2; j <= q / 2; j++)
            {
                if (q % j == 0)
                {
                    MessageBox.Show("Число q не простое!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;

        }
        private void SimvolE(ref BigInteger e)
        {
            Random rand = new Random();
            e = rand.Next(2,(int)f/2);
            int count = 0;
            for (long i = 2; i <= f/2; i++)
            {
                if (e % i == 0 && e!=i)
                {
                    count++;   
                }
                if (count > 0)
                {
                    e++;
                    i = 1;
                    count = 0;
                }
                else if(count == 0 && e!= i && i == f/2 )
                {
                    break;
                }
            }
            Console.WriteLine();
        }
        private void SimvolD(BigInteger e, ref BigInteger d)
        {
            for(int i = 2; i < f; i++)
            {
                if ((e * i) % f == 1)
                {
                    d = i;                   
                    break;
                }
                    
            }
        }
        private List<string> Rsa_CodeOn(BigInteger ex, BigInteger n)
        {
            List<string> C = new List<string>();
            char[] str = new char[MesBox.Text.Length];
            BigInteger CodeOn =1, a;
            foreach(char c in MesBox.Text)
             {
                     a = c;
                     for(int i =0; i< ex; i++)
                     {
                     CodeOn *= a;
                     }
                     
                     CodeOn %= n;
                     C.Add(CodeOn.ToString());
                     CodeOn = 1;
            }

            return C;
        }
        private string Rsa_CodeOff(List<string> textInput, BigInteger d, BigInteger n)
        {
            string result = "";
            BigInteger CodeOff= 1, x ;
            foreach (string c in textInput)
            {             
                x = int.Parse(c);
                for (int i = 0; i < d; i++)
                {
                    CodeOff *= x;
                }

                CodeOff %= n;
                Console.WriteLine(CodeOff);
                result += (char)CodeOff;
                CodeOff = 1;
            }

            return result;
        }
    }
}
