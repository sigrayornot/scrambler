using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public String Encrypter()
        { 
            string InitialWord = textBox1.Text;
            char FirstChar = InitialWord[0];
            char LastChar = InitialWord[InitialWord.Length - 1];
            string SecretIngredient = "hoj";
            string PreWordBase = InitialWord.Remove(0,1);
            string FinalWordBase = PreWordBase.Remove(PreWordBase.Length - 1);
            string EncryptedWord = LastChar + FinalWordBase + SecretIngredient + FirstChar;
            return EncryptedWord;
        }


        public void Button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Encrypter();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
