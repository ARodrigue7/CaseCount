using System.Security.Cryptography;
using System.Windows.Forms.VisualStyles;

namespace CaseCount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int countL = 0;
            int countU = 0;
            
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (char.IsUpper(textBox1.Text[i])) countU++;
                {
                    label2.Text = countU.ToString();
                }                
                if (char.IsLower(textBox1.Text[i])) countL++;
                {
                    label4.Text = countL.ToString();
                }
            }
        }

        
    }
}