using Autofac;
using AutoMapper;
using Ecommerce.Application.AutoMapper;
using Ecommerce.Application.Services;
using Ecommerce.DTOs.Product;
using Ecommerce.Inftastructure;
using Ecommerce.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Ecommerce.Application.Contracts;

namespace Ecommerce.PresentationV2
{
    public partial class ShowProduct : Form
    {
        private IProductRepository ProductRepositor;


        private List<GetAllProductDTO> products;
        private int num = 1;

        Product prd;



        public ShowProduct()
        {
            InitializeComponent();
            products = new List<GetAllProductDTO>();
        }

        private void ShowProduct_Load(object sender, EventArgs e)
        {
            var container = AutoFac.Inject();
            IProductService productService = container.Resolve<IProductService>();
            BindingList<GetAllProductDTO> products = new BindingList<GetAllProductDTO>(productService.GetAllProudctPagination(4, 1));
            dataGridView1.DataSource = products;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[6].Visible = false;

            // Hide row headers
            dataGridView1.RowHeadersVisible = true;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ReadOnly = true;
            }


            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
            {
                HeaderText = "Image",
                Name = "Image",
                Width = 300,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };



            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 70;
            }
            dataGridView1.Columns.Add(imageColumn);
            for (int i = 0; i < products.Count; i++)
            {
                string prodImageURL = products[i].ImageURL;
                Image pic = imageURLToBitmap(prodImageURL);

                if (pic != null)
                {
                    dataGridView1.Rows[i].Cells["Image"].Value = pic;
                }
            }

            DataGridViewButtonColumn ProductDetails = new DataGridViewButtonColumn
            {
                HeaderText = "Check Out This Product",
                Name = "Details",
                Text = "ShowProductDetails",
                UseColumnTextForButtonValue = true,
                Width = 150
            };

            dataGridView1.Columns.Add(ProductDetails);

            var container2 = AutoFac.Inject();
            ICategoryService categoryService = container2.Resolve<ICategoryService>();
            var Categs = categoryService.GetAllCategory().Select(p => p.CategoryName).ToList();
            comboBoxCategory.DataSource = Categs;



        }




        Bitmap imageURLToBitmap(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    return new Bitmap(response.GetResponseStream());
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error fetching image: {ex.Message}");
                return null;
            }
        }
        //CreatOrderHiddenIDDTO orderMaster;
        //CreateOrderDetailDTO OrderItem;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            num++;
            var container = AutoFac.Inject();
            IProductService productService = container.Resolve<IProductService>();
            BindingList<GetAllProductDTO> products = new BindingList<GetAllProductDTO>(productService.GetAllProudctPagination(4, num));

            dataGridView1.DataSource = products;
            for (int i = 0; i < products.Count; i++)
            {
                string prodImageURL = products[i].ImageURL;
                Image pic = imageURLToBitmap(prodImageURL);
                if (pic != null)
                {
                    dataGridView1.Rows[i].Cells["Image"].Value = pic;
                }
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 100;
            }

        }

        private void Prevbtn_Click(object sender, EventArgs e)
        {
            if (num > 1)
            {
                num--;
                var container = AutoFac.Inject();
                IProductService productService = container.Resolve<IProductService>();
                BindingList<GetAllProductDTO> products = new BindingList<GetAllProductDTO>(productService.GetAllProudctPagination(4, num));

                dataGridView1.DataSource = products;
                for (int i = 0; i < products.Count; i++)
                {
                    string prodImageURL = products[i].ImageURL;
                    Image pic = imageURLToBitmap(prodImageURL);
                    if (pic != null)
                    {
                        dataGridView1.Rows[i].Cells["Image"].Value = pic;
                    }
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Height = 100;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SearchName = comboBoxCategory.Text;

            var container = AutoFac.Inject();
            IProductService productService = container.Resolve<IProductService>();
            BindingList<GetAllProductDTO> products = new BindingList<GetAllProductDTO>(productService.SearchProduct(SearchName, num, num));


            dataGridView1.DataSource = products;
            for (int i = 0; i < products.Count; i++)
            {
                string prodImageURL = products[i].ImageURL;
                Image pic = imageURLToBitmap(prodImageURL);
                if (pic != null)
                {
                    dataGridView1.Rows[i].Cells["Image"].Value = pic;
                }
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 100;
            }


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var selectedProduct = dataGridView1.Rows[e.RowIndex].DataBoundItem as GetAllProductDTO;

            if (selectedProduct != null)
            {
                var container = AutoFac.Inject();
                IProductService productService = container.Resolve<IProductService>();
              //  GetAllProductDTO productDetails = productService.GetProductDetails(selectedProduct);
                //prd = new Product();
                //prd.ProductName = productDetails.ProductName;
                //prd.Price = productDetails.Price;
                //ProductFrm.PCategory = productDetails.Category.Name;
//                prd.PDiscount = productDetails.Discount;
              //  prd.ImageURL = imageURLToBitmap(productDetails.ImageURL);





               // prd.ShowDialog();
            }
        }
    }
}
