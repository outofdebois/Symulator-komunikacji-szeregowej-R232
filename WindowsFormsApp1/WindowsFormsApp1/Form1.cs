using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class RS232 : Form
    {
        public RS232()
        {
            InitializeComponent();
        }

        public string[] zakazane;
        private string ConvertToBinary(string text)
        {
            StringBuilder binaryBuilder = new StringBuilder(); 
            foreach (char c in text)
            {
                
                binaryBuilder.Append("0");

                
                string binaryChar = Convert.ToString(c, 2).PadLeft(8, '0');
                for (int i = binaryChar.Length - 1; i >= 0; i--)
                {
                    binaryBuilder.Append(binaryChar[i]);
                }

                
                binaryBuilder.Append("11");
            }
            return binaryBuilder.ToString();
        }
        private string ConverToAscii(string binaryText)
        {
            StringBuilder asciiBuilder = new StringBuilder();
            int i = 0;

            while ((i + 11) <= binaryText.Length)
            {
                string byteString = binaryText.Substring(i + 1, 8); 
                byteString = ReverseString(byteString); 

                int asciiCode = Convert.ToInt32(byteString, 2);
                asciiBuilder.Append(Convert.ToChar(asciiCode));

                i += 11; 
            }

            return asciiBuilder.ToString();
        }
        private static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private int countlines(StreamReader f)
        {
            int liczbaLinii = 0;
            while ((f.ReadLine()) != null)
            {
                liczbaLinii++;
            }
            return liczbaLinii;
        }

        private string[] loadfile(StreamReader f, int liczbaLinii)
        {
            string linia = "";
            int i = 0;
            string[] tablica = new string[liczbaLinii];

            while ((linia = f.ReadLine()) != null)
            {
                tablica[i] = linia;
                i++;
            }
            return tablica;
        }


        private void Send_Click(object sender, EventArgs e)
        {
            Output_In.Text = Input_Out.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public string blur(string tekstS, string[] czarnaListaSlow)
        {
            StringBuilder tekst = new StringBuilder(tekstS);
            string star = "";

            for (int i = 0; i < czarnaListaSlow.Length; i++)
            {
                for (int j = 0; j < czarnaListaSlow[i].Length; j++)
                {
                    star += "*";
                }

                tekst.Replace(czarnaListaSlow[i], star);
                tekst.Replace(czarnaListaSlow[i].ToLower(), star);
                tekst.Replace(czarnaListaSlow[i].ToUpper(), star);
                star = "";
            }
            return tekst.ToString();
        }

        private void BlurCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Blur.Checked)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamReader f1 = new StreamReader(openFileDialog1.FileName);
                    int liczbaLinii = countlines(f1);
                    f1.Close();

                    StreamReader f2 = new StreamReader(openFileDialog1.FileName);
                    zakazane = loadfile(f2, liczbaLinii);
                    f2.Close();
                }
            }
        }

        private void Input_in_TextChanged(object sender, EventArgs e)
        {

        }

        private void Input_out_TextChanged(object sender, EventArgs e)
        {

        }

        private void KonwIn_Click(object sender, EventArgs e)
        {
            Input_Out.Text = ConvertToBinary(Input_in.Text);
        }

        private void Output_in_TextChanged(object sender, EventArgs e)
        {

        }

        private void Output_out_TextChanged(object sender, EventArgs e)
        {

        }

        private void KonwOut_Click(object sender, EventArgs e)
        {
            string convertedText = ConverToAscii(Output_In.Text);
            if (Blur.Checked && zakazane != null)
            {
                convertedText = blur(convertedText, zakazane);
            }
            Output_out.Text = convertedText;
        }

    }
}

