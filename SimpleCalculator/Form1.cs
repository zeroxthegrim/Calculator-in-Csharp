using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Clearing Methods
        private void CEButton_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = string.Empty;
            this.label1.Text = "Enter an equation and press Enter or =";

            FocusInputText();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (this.UserInputText.TextLength > 0 && this.UserInputText.SelectionStart != this.UserInputText.TextLength)
            {
                //Remembering starting index
                var startingIndex = this.UserInputText.SelectionStart;

                //Deleting number/operator
                this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);

                // Updating cursor position
                this.UserInputText.SelectionStart = startingIndex;
            }    

            FocusInputText();
        }
        #endregion

        #region Operator Methods
        private void DivButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");
            FocusInputText();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");
            FocusInputText();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");
            FocusInputText();
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");
            FocusInputText();
        }
        #endregion

        #region Calculate Equation
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            try
            {
                //This resets the text on the label
                this.label1.Text = "Enter an equation and press Enter or =";

                //Using DataTable.Compute to calculate equation directly from the string
                DataTable dt = new DataTable();
                var result = dt.Compute(this.UserInputText.Text, "");

                this.UserInputText.Text = result.ToString();

                //Making sure the position of the cursor is at the end of textbox after calculation
                this.UserInputText.SelectionStart = this.UserInputText.TextLength;

                FocusInputText();
            }
            catch
            {
                this.label1.Text = "Invalid Equation";

                FocusInputText();
            }
            
        }
        #endregion

        #region Number Methods
        private void DotButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");
            FocusInputText();
        }

        private void Num0Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");
            FocusInputText();
        }

        private void Num1Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");
            FocusInputText();
        }

        private void Num2Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");
            FocusInputText();
        }

        private void Num3Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");
            FocusInputText();
        }

        private void Num4Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");
            FocusInputText();
        }

        private void Num5Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");
            FocusInputText();
        }

        private void Num6Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");
            FocusInputText();
        }

        private void Num7Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");
            FocusInputText();
        }

        private void Num8Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");
            FocusInputText();
        }

        private void Num9Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");
            FocusInputText();
        }
        #endregion

        #region Private Helpers
        /// <summary>
        /// Focuses user's input text
        /// </summary>
        private void FocusInputText()
        {
            this.UserInputText.Focus();
        }

        /// <summary>
        /// Inserts the given text into the user input textbox at the position of the cursor
        /// </summary>
        /// <param name="value"></param>
        private void InsertTextValue(string value)
        {
            //Remembering starting index
            var startingIndex = this.UserInputText.SelectionStart;
            
            //Adding new text
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);

            //Setting updated SelectionStart (where the cursor will be after added text)
            this.UserInputText.SelectionStart = startingIndex + value.Length;
        }
        #endregion
    }
}
