using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_pos
{
    public partial class UcProduct : UserControl
    {
        private string UcPrdID;
        private string UcPrdName;
        private string UcPrdImg;
        private float UcPrdPrice;
        private string UcPrdStatus;
        private string UcPrdCatID;



        public UcProduct()
        {
            InitializeComponent();
        }
        public string PUcPrdID
        {
            get { return LBIdPrd.Text; }
            set { LBIdPrd.Text = value; }
        }
        public string PUcPrdName
        {
            get { return LBNamePrd.Text; }
            set { LBNamePrd.Text = value; }
        }
        public Image PUcPrdImage
        {
            get { return PbImgPrd.Image; }
            set { PbImgPrd.Image = value; }
        }
        public float PUcPrdPrice
        {
            get { return Convert.ToSingle(LBPricrPrd.Text); }
            set { LBPricrPrd.Text = value.ToString(); }
        }
        public string PUcPrdCatID
        {
            get { return LBCatIdPrd.Text; }
            set { LBCatIdPrd.Text = value; }
        }
        public string PUcPrdStatus
        {
            get { return LBStatusPrd.Text; }
            set { LBStatusPrd.Text = value; }
        }

        private void BtAddPrd_Click(object sender, EventArgs e)
        {
            UcPrdID     = PUcPrdID; 
            UcPrdName   = PUcPrdName;
            UcPrdPrice  = PUcPrdPrice;
            UcPrdCatID  = PUcPrdCatID;

            Global.SellPrdId    = UcPrdID;
            Global.SellPrdName  = UcPrdName;
            Global.SellPrdPrice = UcPrdPrice;
            Global.SellPrdCatID = UcPrdCatID;

            FrmAddPrd FrmAddPrd = new FrmAddPrd();
            FrmAddPrd.Show();
        }
    }
}
