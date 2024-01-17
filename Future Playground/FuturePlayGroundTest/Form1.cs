using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuturePlayGroundTest
{
    
    public partial class Form1 : Form
    {
         string Charname;
         string Famname;
         bool gender;
         string SexPref;
         string bodyType;
         string EyeColor;
         string HairColor;
         string HairType;
         int FashionLevel, cybernetics, Soul, Composure, Communication, Reflexes, Stamina, Strength, istatTotal= 50, icurrentTotalC,icurrentTotalS,icurrentTotalComp,icurrentTotalCom;
         int iCurReflex, iCurStrength, iCurStamina;
         bool Tatoo;
         string InterfaceColor;

        private void tbCybernetics_Scroll(object sender, EventArgs e)
        {
            cybernetics = tbCybernetics.Value;
            tbSoul.Enabled = true;
            if (istatTotal - cybernetics >= 0)
            {

                icurrentTotalC = istatTotal - cybernetics;
                lblStatTotal.Text = " " + icurrentTotalC;
            }
            else
            {
                MessageBox.Show("Current available stat points", "Out of stat points", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbStamina_Scroll(object sender, EventArgs e)
        {
            Stamina = tbStamina.Value;
            tbStrength.Enabled = true;
            if (iCurReflex- Stamina >= 0)
            {
                iCurStamina = iCurReflex - Stamina;
                lblStatTotal.Text = " " + iCurStamina;
            }
            else
            {
                MessageBox.Show("Current available stat points", "Out of stat points", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbStrength_Scroll(object sender, EventArgs e)
        {
            Strength = tbStrength.Value;
          
            if (iCurStamina - Strength >= 0)
            {
                iCurStrength = iCurStamina - Strength;
                lblStatTotal.Text = " " + iCurStrength;
            }
            else
            {
                MessageBox.Show("Current available stat points", "Out of stat points", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbCommunication_Scroll(object sender, EventArgs e)
        {
            Communication = tbCommunication.Value;
            tbReflexes.Enabled = true;
            if (icurrentTotalComp - Communication >= 0)
            {
                icurrentTotalCom = icurrentTotalComp - Communication;
                lblStatTotal.Text = " " + icurrentTotalCom;
            }
            else
            {
                MessageBox.Show("Current available stat points", "Out of stat points", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbReflexes_Scroll(object sender, EventArgs e)
        {
            Reflexes = tbReflexes.Value;
            tbStamina.Enabled = true;
            if (icurrentTotalCom - Reflexes >= 0)
            {
                iCurReflex = icurrentTotalCom - Reflexes;
                lblStatTotal.Text = " " + iCurReflex;
            }
            else
            {
                MessageBox.Show("Current available stat points", "Out of stat points", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbCybernetics_ValueChanged(object sender, EventArgs e)
        {
          //
        }

        private void tbComposure_Scroll(object sender, EventArgs e)
        {
            Composure = tbComposure.Value;
            tbCommunication.Enabled = true;
            if (icurrentTotalS - Composure >= 0)
            {

                icurrentTotalComp = icurrentTotalS - Composure;
                lblStatTotal.Text = " " + icurrentTotalComp;
            }
            else
            {
                MessageBox.Show("Current available stat points", "Out of stat points", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbSoul_Scroll(object sender, EventArgs e)
        {
            Soul = tbSoul.Value;
            tbComposure.Enabled = true;
            if (icurrentTotalC - Soul >= 0)
            {

                icurrentTotalS = icurrentTotalC - Soul;
                lblStatTotal.Text = " " + icurrentTotalS;
            }
            else
            {
                MessageBox.Show("Current available stat points", "Out of stat points", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        Random charhistory = new Random();
        int[] charHChosen = new int[] { 1, 2, 3 };

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            cboStyles.Visible = true;
            lblMaleSign.Visible = true;
            cboStyles.Items.Clear();
            cboStyles.Items.Add("Fade");
            cboStyles.Items.Add("Man Bun");
            cboStyles.Items.Add("Conrows");
            cboStyles.Items.Add("Brush");
            cboStyles.Items.Add("Bald");
            cboStyles.Items.Add("Dread Locks");
            

            lblFemaleSign.Visible = false;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {

            lblFemaleSign.Visible = true;
            cboStyles.SelectedIndex = -1;
            cboStyles.Items.Clear();
            cboStyles.Items.Add("Afro");
            cboStyles.Items.Add("Half Up Top Knot");
            cboStyles.Items.Add("Perm");
            cboStyles.Items.Add("Braids");
            cboStyles.Items.Add("Bangs");
            cboStyles.Items.Add("Cropped Cut");

            cboStyles.Visible = true;
            lblMaleSign.Visible = false;
        }

   



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            //btnStart.Enabled = false;
            btnStart.Visible = false;
            cboStyles.Items.Clear();
            tbCybernetics.Enabled = true;
            tbSoul.Enabled = false;
            tbComposure.Enabled = false;
            tbCommunication.Enabled = false;
            tbReflexes.Enabled = false;
            tbStamina.Enabled = false;
            tbStrength.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnStart.Visible = true;
            
            btnBuild.Visible = false;

            #region Tab 1 Character Creation
            Charname = txtCharName.Text;
            Famname = txtFamName.Text;

            if (rbMale.Checked == true)
            {
                gender = true;
             
            }
            else
            {
                gender = false;
                
            }

            if (rbMen.Checked == true)
            {
                SexPref = "Men";
            }
            else if (rbFemale.Checked == true)
                {
                SexPref = "Female";
                }
            else
            {
                SexPref = "Both";
            }
            #endregion

            #region Tab 2 character creation

            string bodychoice ="";
            int BodychoiceInt = cboBody.SelectedIndex;

         switch (BodychoiceInt)
            {
                    case 0:
                    bodychoice = "Slim";
                    break;

                case 1:
                    bodychoice = "Average";
                    break;

                case 2:
                    bodychoice = "Built";
                    break;

                case 3:
                    bodychoice = "Ripped";
                    break;

                default:
                    MessageBox.Show("Please choose one of the body types");
                    break;
            }


            string Eyechoice = "";
            int EyechoiceInt = cboEyeColor.SelectedIndex;

            switch (EyechoiceInt)
            {
                case 0:
                    Eyechoice = "Brown";
                    break;

                case 1:
                    Eyechoice = "Green";
                    break;

                case 2:
                    Eyechoice = "White";
                    break;

                case 3:
                    Eyechoice = "Yellow";
                    break;

                case 4:
                    Eyechoice = "Blue";
                    break;

                default:
                    MessageBox.Show("Please choose one of the eye color types");
                    break;
            }

            //Hair Colours
                  string Hairchoice = "";
            int HairchoiceInt = cboHairColor.SelectedIndex;

            switch (HairchoiceInt)
            {
                case 0:
                    Hairchoice = "Red";
                    break;

                case 1:
                    Hairchoice = "Orange";
                    break;

                case 2:
                    Hairchoice = "Black";
                    break;

                case 3:
                    Hairchoice = "Brown";
                    break;

                case 4:
                    Hairchoice = "Pink";
                    break;

                default:
                    MessageBox.Show("Please choose one of the hair color types");
                    break;
            }

            // Male Hair types

                  string HairMTypechoice = "";
            int HairMTypechoiceInt = cboStyles.SelectedIndex;

            switch (HairMTypechoiceInt)
            {
                case 0:
                    HairMTypechoice = "Fade";
                    break;

                case 1:
                    HairMTypechoice = "Man Bun";
                    break;

                case 2:
                    HairMTypechoice = "Conrows";
                    break;

                case 3:
                    HairMTypechoice = "Brush";
                    break;

                case 4:
                    HairMTypechoice = "Bald";
                    break;

                case 5:
                    HairMTypechoice = "Dread Locks";
                    break;

                default:
                    MessageBox.Show("Please choose one of the male hair types");
                    break;
            }

                // Female Hair Types
                   string HairFTypechoice = "";
            int HairFTypechoiceInt = cboStyles.SelectedIndex;

            switch (HairFTypechoiceInt)
            {
                case 0:
                    HairFTypechoice = "Afro";
                    break;

                case 1:
                    HairFTypechoice = "Half Up Top Knot";
                    break;

                case 2:
                    HairFTypechoice = "Perm";
                    break;

                case 3:
                    HairFTypechoice = "Braids";
                    break;

                case 4:
                    HairFTypechoice = "Bangs";
                    break;

                case 5:
                    HairFTypechoice = "Cropped Cut";
                    break;

                default:
                    MessageBox.Show("Please choose one of the female hair types");
                    break;
            }


            FashionLevel = tbFashion.Value;


                // Interface Color Types
                   string InterfaceColor = "";
            int InterfaceColorInt = cboInterface.SelectedIndex;

            switch (InterfaceColorInt)
            {
                case 0:
                    HairFTypechoice = "Default";
                    break;

                case 1:
                    HairFTypechoice = "Red";
                    break;

                case 2:
                    HairFTypechoice = "Green";
                    break;

                default:
                    MessageBox.Show("Please choose one of the following interface color types");
                    break;
            }

            if (rbTatoo.Checked == true)
            {
                Tatoo = true;

            }
            else
            {
                Tatoo = false;

            }
            #endregion

            #region Tab 3 Character Creation
            if (tbCybernetics.Value >1)
            {
                cybernetics = tbCybernetics.Value;
               
            }
            else
            {
                MessageBox.Show("Are you sure that you want to continue without a cybernetic stat? This is one of the games core stats and will change your gameplay experience", "Continue?", MessageBoxButtons.OK, MessageBoxIcon.Error);

           
            }


            if (tbComposure.Value >1)
            {
                Composure = tbComposure.Value;
            }
            else
            {
                MessageBox.Show("Are you sure that you want to continue without a composure stat? This is one of the games core stats and will change your gameplay experience", "Continue?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(tbCommunication.Value >1)
            {
                Communication = tbCommunication.Value;
            }
            else
            {
                MessageBox.Show("Are you sure that you want to continue without a communication stat? This is one of the games core stats and will change your gameplay experience", "Continue?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
          
        if(tbSoul.Value> 1)
            {
                Soul = tbSoul.Value;
            }
        else
            {
                MessageBox.Show("Are you sure that you want to continue without a soul stat? This is one of the games core stats and will change your gameplay experience", "Continue?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Reflexes = tbReflexes.Value;
            Strength = tbStrength.Value;
            Stamina = tbStamina.Value;

            #endregion



            #region Character Background Generator
            int charback;
            charback = charHChosen[charhistory.Next(charHChosen.Length)];
            MessageBox.Show("Your characters background is option: " + charback, "Character Background", MessageBoxButtons.OK, MessageBoxIcon.Information);
            #endregion
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form3 open = new Form3();
            open.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        //private void panel3_Pastring(object sender, PastringEventArgs e)
        //{

        //}

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
