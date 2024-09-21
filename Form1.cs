using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomCharacters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum enOptions { Letters, Numbers, Symbols, Mix };

        enOptions _options = enOptions.Numbers;

        
        private void CheckFalse()
        {
            chkLetters.Checked = false;
            chkSymbols.Checked = false;
            chkMix.Checked = false;
            chkNumbers.Checked = false;
        }
        
        private string GenerateRandomCharacters()
        {
            short NumberOfDigits = Convert.ToInt16(txtInput.Text);

            string RandomCharacters = "";
            
            Random Random = new Random();
            

            switch (_options)
                {
                    case enOptions.Numbers:
                    {
                        for (int i = 0; i < NumberOfDigits; i++)
                        {
                            RandomCharacters += Random.Next(0, 10);
                        }
                    }
                    break;


                case enOptions.Letters:
                    {
                        for (int i = 0; i < NumberOfDigits; i++)
                        {
                            RandomCharacters += (char)Random.Next(65, 91);
                        }
                    }
                    break;

                case enOptions.Symbols:
                    {
                        for (int i = 0; i < NumberOfDigits; i++)
                        {
                            RandomCharacters += (char)Random.Next(33, 48);
                        }
                    }
                    break;


                case enOptions.Mix:
                    {
                        RandomCharacters += GenerateMix();
                    }
                    break;
               }

                return RandomCharacters;
        }
        
        private string GenerateMix()
        {
            Random Random = new Random();

            string random = "";

            short NumberOfDigits = Convert.ToInt16(txtInput.Text);


            for (int i = 0; i < NumberOfDigits; i++)
            {
                short Num = Convert.ToInt16(Random.Next(1, 4));

                switch(Num)
                {
                    case 1:
                        {
                            random += (char)Random.Next(65, 91);
                        }
                        break;

                    case 2:
                        {
                            random += Random.Next(0, 10);
                        }
                        break;

                    case 3:
                        {
                            random += (char)Random.Next(33, 48);
                        }
                        break;
                }
            }

            return random;
        }

        private void InvisibleCopyAndOptions()
        {
            gbOptions.Visible = false;
            lblCopy.Visible = false;
        }

        private void DisableGenerateButton()
        {
            btnGenerate.Enabled = false;
        }

        private void EnableGenerateButton()
        {
            if((chkLetters.Checked || chkMix.Checked || chkNumbers.Checked || chkSymbols.Checked) && (!String.IsNullOrEmpty(txtInput.Text)))
            {
                    btnGenerate.Enabled = true;
            }
        }

        private void lblCopy_MouseClick(object sender, MouseEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtResult.Text))
            {
                Clipboard.SetText(txtResult.Text);

                MessageBox.Show("The text has been copied.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InvisibleCopyAndOptions();
            DisableGenerateButton();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InvisibleCopyAndOptions();
            DisableGenerateButton();

            txtResult.Text = "";
            txtInput.Text = "";

            chkNumbers.Checked = false;
            chkSymbols.Checked = false;
            chkLetters.Checked = false;
            chkMix.Checked = false;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lblCopy.Visible = true;

            string input = txtInput.Text;
            short Num;

            if ((!short.TryParse(input, out Num)) || (Convert.ToInt16(input) <= 0))
            {
                MessageBox.Show("Please enter a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            
            else
                txtResult.Text = GenerateRandomCharacters();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            gbOptions.Visible = true;
        }

        private void chkNumbers_CheckedChanged(object sender, EventArgs e)
        {
            _options = enOptions.Numbers;

            EnableGenerateButton();

            if (!chkLetters.Checked && !chkMix.Checked && !chkNumbers.Checked && !chkSymbols.Checked)
                btnGenerate.Enabled = false;
        }

        private void chkLetters_CheckedChanged(object sender, EventArgs e)
        {         
            _options = enOptions.Letters;

            EnableGenerateButton();

            if (!chkLetters.Checked && !chkMix.Checked && !chkNumbers.Checked && !chkSymbols.Checked)
                btnGenerate.Enabled = false;
        }

        private void chkMix_CheckedChanged(object sender, EventArgs e)
        {
            _options = enOptions.Mix;

            EnableGenerateButton();

            if (!chkLetters.Checked && !chkMix.Checked && !chkNumbers.Checked && !chkSymbols.Checked)
                btnGenerate.Enabled = false;
        }

        private void chkSymbols_CheckedChanged(object sender, EventArgs e)
        {
            _options = enOptions.Symbols;

            EnableGenerateButton();

            if (!chkLetters.Checked && !chkMix.Checked && !chkNumbers.Checked && !chkSymbols.Checked)
                btnGenerate.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            EnableGenerateButton();
        }

        private void chkLetters_Click(object sender, EventArgs e)
        {
            CheckFalse();
            chkLetters.Checked = true;
        }

        private void chkNumbers_Click(object sender, EventArgs e)
        {
            CheckFalse();
            chkNumbers.Checked = true;
        }

        private void chkSymbols_Click(object sender, EventArgs e)
        {
            CheckFalse();
            chkSymbols.Checked = true;
        }

        private void chkMix_Click(object sender, EventArgs e)
        {
            CheckFalse();
            chkMix.Checked = true;
        }
    }
}
