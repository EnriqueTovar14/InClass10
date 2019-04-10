using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//This is my own work
//Enrque Tovar
namespace InClass10
{
    public partial class Form1 : Form
    {
        public static System.IO.StreamWriter sw;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sw = System.IO.File.CreateText("Sample.dat");
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);

                string allText = sr.ReadToEnd();
                string[] words = allText.Split();
                int count = 0;            

                for (int i = 0; i < words.Length; i++)
                {
                    string textWord = words[i];

                    for (int v = 0; v != textWord.Length - 1; v++)
                    {
                        if (textWord[v] == 't' || textWord[v] == 'e' || textWord[v] == 'T' || textWord[v] == 'E')
                        {
                            count++;
                        }
                    }                  
                }
                richTextBox1.Text += "Words that end with T or E: " + count;
            }
            sw.Close();
        }

        private object tolower(object p)
        {
            throw new NotImplementedException();
        }
    }
}






