using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contract_Collection_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rtbOutputBox.KeyPress += txtAmountKeyPress;
            rtbOutputBox.KeyDown += KeyCheckID_KeyDown;
        }

        //initialize dictionary here:
        ContractCollection contractBox = new ContractCollection();
        Contract clientContract = new Contract();

        #region Form Buttons
        private void btnAddContract_Click(object sender, EventArgs e)
        {
            if(validateData())
            {

            }
        }

        private void btnRemoveContract_Click(object sender, EventArgs e)
        {

        }

        private void btnTotalDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplayCurrent_Click(object sender, EventArgs e)
        {

        }

        private void btnIDSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Form Buttons

        #region General Form Functions

        public bool validateData()
        {
            if(txtIDInput.Text == string.Empty)
            {
                errprovider.SetError(txtIDInput, "Contract ID Required");
                txtIDInput.Focus();
                return false;
            }
            else
            {
                if (txtNameInput.Text == string.Empty)
                {
                    errprovider.SetError(txtNameInput, "Client Name Reqiured");
                    txtNameInput.Focus();
                    return false;
                }
                else
                {
                    if(txtClientAmount.Text == string.Empty)
                    {
                        errprovider.SetError(txtClientAmount, "Amount required");
                        txtClientAmount.Focus();
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }

        #endregion General Form Functions

        //Key Events written here were with reference to 
        //this msdn document: 
        //shorturl.at/bxBU8
        //Key Event Args document

        //specifically exampe 3 in the document
        #region form events

        //this boolean helps determine if a key was pressed. 
        //this goes in the keycheckID method here. 
        bool NumberNotPressed = false;

        //This event will include a KeyEventArgs which is for keyboard events


        public void KeyCheckID_KeyDown(object sender, KeyEventArgs e)
        {

            //Key event args e is essentially the key detected and has 
            //different methods, properties on its own. In here the main
            //interest is e.Keycode which is the detected key made by the keystroke
            //

            //MainKeyNumbersNotPressed detects keys 0 - 9 on the top keyboard if they are pressed
            //within that range. 
            bool mainKeyNumbersNotPressed = e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9;

            //NumPadNumbersNotPressed does the same thing as the first boolean, only
            //instead detected number pad keys being pressed. 
            bool numPadNumbersNotPressed = e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9;

            //Uses the boolean as a conditional for if main key nums are pressed
            if (mainKeyNumbersNotPressed)
            {
                //Uses the boolean as a conditional for if num pad keys are pressed
                if (numPadNumbersNotPressed)
                {
                    //this is for if backspace is not pressed
                    if(e.KeyCode != Keys.Back || e.KeyCode != Keys.OemPeriod)
                    {
                        NumberNotPressed = true;
                    }
                }
            }
            
        }

        //!!!The intended keyEventArg that the professor wanted!!!!
        //This is actually better, but I could condese this by a keychar ascii values
        //to shorten this method. 

        //How this works:
        //  -The switch statement detects the key character and the cases for the key detection fall through
        //
        //  -If any of the characters typed fall into one of these cases it will break. If none of them
        //   fall within this range then it will default to making the event already "handled" and a key
        //   will not be input into the control
        private void KeyEventDetection_SwitchVer(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                case '\b':
                case '.':
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        //How this works:
        //A detected keychar generated from the numpad or the top key pad will be detected in the
        //switch cases. If the characters aren't numbers 1-9 the default case will make it
        //as if the event was already handled. Thus e.handled = true;

        //to shorten this to an if statement refer to this: https://www.ascii-code.com/
        //for the ascii values
        private void KeyEventDetection_AsciiVer(object sender, KeyPressEventArgs e)
        {
            int KeyToAscci = (int)e.KeyChar;
            bool isValidKey = (KeyToAscci >= 48 && KeyToAscci <= 57) ||(KeyToAscci == 8 || KeyToAscci == 46);

            e.Handled = isValidKey ? e.Handled = false : true;           
            
        }

        //This method here uses the NumberKeyPressed as the indicator for the key.
        //if the number key was pressed the event is handled. 
        //
        //Otherwise we aren't handling the event and just discard the result

        
        public void txtAmountKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (NumberNotPressed) ? true : false;

            //Number key pressed should equal false to reset
            //proper key detection for each keystroke
            NumberNotPressed = false;
        }


        #endregion Form events

        private void rtbOutputBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
