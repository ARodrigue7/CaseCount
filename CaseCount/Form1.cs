using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            int countL = 0, countU = 0, space = 0;
            string text = textBox1.Text;
            

            //character count
            //foreach (delimiterChars in text) charCount++;
            //{
            //    charCount = text.Length - charCount;
            //    label11.Text = charCount.ToString();
            //}



            //uppercase & lower case counts
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i])) countU++;
                {
                    label2.Text = countU.ToString();
                }
                if (char.IsLower(text[i])) countL++;
                {
                    label4.Text = countL.ToString();
                }
                if (char.IsWhiteSpace(text[i])) space++;
                {                    
                    label11.Text = (text.Length - space).ToString();
                }
            }

            //word count
            //char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            //string[] words = text.Split(delimiterChars);

            int wordCount = 0, index = 0, wordU = 0, wordL = 0;

            while (index < text.Length && char.IsWhiteSpace(text[index])) index++;

            while (index < text.Length)
            {
                // check if current char is part of a word
                while (index < text.Length && !char.IsWhiteSpace(text[index])) index++;

                wordCount++;

                // skip whitespace until next word
                while (index < text.Length && char.IsWhiteSpace(text[index])) index++;
            }
            label12.Text = wordCount.ToString();
            
            var ucWord = WordFilt(text);
            foreach (string word in ucWord)
            {
                textBox2.Text += word;
                wordU = word.Count();
                label7.Text = wordU.ToString();
            }
        }

        static IEnumerable<string> WordFilt(string mystr)
        {
            var upWord = mystr.Split(' ').Where(x => String.Equals(x, x.ToUpper(), StringComparison.Ordinal));

            return upWord;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}