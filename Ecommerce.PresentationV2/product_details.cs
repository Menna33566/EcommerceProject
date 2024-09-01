using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce.PresentationV2
{
    public partial class product_details : Form
    {
        public product_details()
        {
            InitializeComponent();
        }

        public string PName;
        public decimal PPrice;
        public int PStock;
        public bool PDiscount;
        public string PImgURL;
        public string PCategory;
        public Image PImage;

        private void product_details_Load(object sender, EventArgs e)
        {
            Price.Text= PPrice.ToString();
            Description.Text= Description.ToString();
            pictureBox1.Image= PImage;
            LB_Name.Text = PName;
        }
    }
}
