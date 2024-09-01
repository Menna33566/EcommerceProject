using Autofac;
using Ecommerce.Application.Services;
using Ecommerce.PresentationV2.AutoFac;
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
    public partial class AdminDashBord : Form
    {
        public AdminDashBord()
        {
            InitializeComponent();
        }
        int type = 0;
        ICategoryService categoryservs;
        IProductService productservs;
        IOrderService orderservs;
        private void btncategory_Click(object sender, EventArgs e)
        {
            type = 1;
            //var continer = AutoFac2.Inject();
            var continer = AutoFac.AutoFac.Inject();
            gradeAdminview.DataBindings.Clear();
            categoryservs = continer.Resolve<ICategoryService>();

            var categorylist = categoryservs.GetAllCategoryBinding();
            gradeAdminview.DataSource = categorylist;
            gradeAdminview.Columns[0].Visible = false;
            gradeAdminview.Columns[2].Visible = false;
            //BindingList<DTOs.Category.GetAllCategoryDTO> CategoryBindingList = new BindingList<DTOs.Category.GetAllCategoryDTO>(categorylist);
            //gradeAdminview.DataSource = CategoryBindingList;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            type = 2;
            gradeAdminview.DataBindings.Clear();
            //var continer = AutoFac2.Inject();
            var continer = AutoFac.AutoFac.Inject();
            productservs = continer.Resolve<IProductService>();
            var productlist = productservs.GetAllProductBinding();
            gradeAdminview.DataSource = productlist;
            gradeAdminview.Columns[0].Visible = false;
            gradeAdminview.Columns[7].Visible = false;

            //BindingList<DTOs.Category.GetAllCategoryDTO> CategoryBindingList = new BindingList<DTOs.Category.GetAllCategoryDTO>(categorylist);
            //gradeAdminview.DataSource = CategoryBindingList;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            type = 3;
            gradeAdminview.DataBindings.Clear();
            //var continer = AutoFac2.Inject();
            var continer = AutoFac.AutoFac.Inject();
            orderservs = continer.Resolve<IOrderService>();
            var prderlist = orderservs.GetAllOrderBinding();
            gradeAdminview.DataSource = prderlist;
            gradeAdminview.Columns[0].Visible = false;
            gradeAdminview.Columns[5].Visible = false;
            gradeAdminview.Columns[7].Visible = false;

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (type == 1)
            {
                categoryservs.savechanges();
            }
            else if (type == 2)
            {
                productservs.savechanges();
            }
            else if (type == 3)
            {
                orderservs.savechanges();
            }
        }

        private void AdminDashBord_Load(object sender, EventArgs e)
        {
            //var continer = AutoFac2.Inject();
            var continer = AutoFac.AutoFac.Inject();
            IUserService userservice =continer.Resolve<IUserService>();
            labeladminname.Text = userservice.AdminName();
        }
    }
}
