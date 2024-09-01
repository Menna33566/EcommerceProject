using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ecommerce.Application.Services;
using Ecommerce.Models;
using Ecommerce.DTOs.Order;

namespace Ecommerce.PresentationV2
{
    public partial class orderForm : Form
    {
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;
        List<ordersPending> ordersPending;
        int idx = 0;
        public orderForm(IOrderService orderService, IUserService userService)
        {
            _orderService = orderService;
            _userService = userService;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _orderService.UpdateOrderQuantity(ordersPending[idx].Id, int.Parse(textBox3.Text));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            _orderService.UpdateOrderStatus(ordersPending[idx].Id, "processing");
        }

        private void orderForm_Load(object sender, EventArgs e)
        {
            var user_id = _userService.GetActiveUser().Id;
            ordersPending = _orderService.getAllPendingOrders(user_id, "pending").ToList();

            if (ordersPending.Count > 0)
            {
                textBox2.Text = ordersPending[idx].Quantity.ToString();
                textBox4.Text = ordersPending[idx].ProductName.ToString();
                textBox1.Text = ordersPending[idx].Price.ToString();
            }
            else this.Text = "There is no orders in the cart";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            _orderService.DeleteOrder(ordersPending[idx].Id);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ordersPending.Count > 0)
            {
                idx++;
                idx %= ordersPending.Count;
                textBox2.Text = ordersPending[idx].Quantity.ToString();
                textBox4.Text = ordersPending[idx].ProductName.ToString();
                textBox1.Text = ordersPending[idx].Price.ToString();
            }
            else this.Text = "There is no orders in the cart";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (ordersPending.Count > 0)
            {
                idx--;
                idx += ordersPending.Count;
                idx %= ordersPending.Count;
                textBox2.Text = ordersPending[idx].Quantity.ToString();
                textBox4.Text = ordersPending[idx].ProductName.ToString();
                textBox1.Text = ordersPending[idx].Price.ToString();
            }
            else this.Text = "There is no orders in the cart";
        }
    




        //////////////////////////////////////////////////////////////////
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
