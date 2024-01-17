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
    public partial class Form3 : Form
    {
        string Charname;
        string Famname;
        bool gender;
        bool SexPref;
        string bodyType;
        string EyeColor;
        string HairColor;
        string HairType;
        int FashionLevel, cybernetics, Soul, Composure, Communication, Reflexes, Stamina, Strength;
        bool Tatoo;
        string InterfaceColor;

        #region Userglobalvariables
        public string Charname1
        {
            get
            {
                return Charname;
            }

            set
            {
                Charname = value;
            }
        }

        public string Famname1
        {
            get
            {
                return Famname;
            }

            set
            {
                Famname = value;
            }
        }

        public bool Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public bool SexPref1
        {
            get
            {
                return SexPref;
            }

            set
            {
                SexPref = value;
            }
        }

        public string BodyType
        {
            get
            {
                return bodyType;
            }

            set
            {
                bodyType = value;
            }
        }

        public string EyeColor1
        {
            get
            {
                return EyeColor;
            }

            set
            {
                EyeColor = value;
            }
        }

        public string HairColor1
        {
            get
            {
                return HairColor;
            }

            set
            {
                HairColor = value;
            }
        }

        public string HairType1
        {
            get
            {
                return HairType;
            }

            set
            {
                HairType = value;
            }
        }

        public int FashionLevel1
        {
            get
            {
                return FashionLevel;
            }

            set
            {
                FashionLevel = value;
            }
        }

        public int Cybernetics
        {
            get
            {
                return cybernetics;
            }

            set
            {
                cybernetics = value;
            }
        }

        public int Soul1
        {
            get
            {
                return Soul;
            }

            set
            {
                Soul = value;
            }
        }

        public int Composure1
        {
            get
            {
                return Composure;
            }

            set
            {
                Composure = value;
            }
        }

        public int Communication1
        {
            get
            {
                return Communication;
            }

            set
            {
                Communication = value;
            }
        }

        public int Reflexes1
        {
            get
            {
                return Reflexes;
            }

            set
            {
                Reflexes = value;
            }
        }

        public int Stamina1
        {
            get
            {
                return Stamina;
            }

            set
            {
                Stamina = value;
            }
        }

        public int Strength1
        {
            get
            {
                return Strength;
            }

            set
            {
                Strength = value;
            }
        }

        public bool Tatoo1
        {
            get
            {
                return Tatoo;
            }

            set
            {
                Tatoo = value;
            }
        }

        public string InterfaceColor1
        {
            get
            {
                return InterfaceColor;
            }

            set
            {
                InterfaceColor = value;
            }
        }
        #endregion
        public Form3()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
//
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            //
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
