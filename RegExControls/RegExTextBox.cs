using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegExControls
{
    public partial class RegExTextBox : TextBox 
    {
        private string mRegularExpression;

        public string Regular_Expression
        {
            get
            {
                return mRegularExpression;
            }
            set
            {
                mRegularExpression = value;
            }
        }

        public RegExTextBox()
        {
            InitializeComponent();
        }

        public bool ValidateControl(string text)
        {
            string TextToValidate;
            Regex expression;

            try
            {
                TextToValidate = text;
                expression = new Regex(Regular_Expression);
            }
            catch
            {
                MessageBox.Show("Regex invalid!");
                return false;
            }

            // test text with expression
            if (expression.IsMatch(TextToValidate))
            {
                return true;
            }
            else
            {
                // no match
                return false;
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            //Ein Taste wird gedrückt
            if (Char.IsControl(e.KeyChar) == false)
            {
                //Wenn es sich um ein eingabezeichen handelt
                string newText = base.Text.Substring(0, base.SelectionStart) + e.KeyChar.ToString() + base.Text.Substring(base.SelectionStart + base.SelectionLength);
                if (newText != "")
                {
                    bool validateCheck = this.ValidateControl(newText);
                    if (validateCheck == false)
                    {
                        //Die Eingabe ist ungültig und das Zerichen wird nicht geschrieben
                        e.Handled = true;
                    }
                }                 
            }
            
            base.OnKeyPress(e);
        }
    }
}
