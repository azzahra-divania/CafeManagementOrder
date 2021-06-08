using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class OrderForm : Form
    {
        protected int winFormWidth = 360;
        protected int winFormHeight = 160;

        protected Menu menu;
        protected MenuForm menuForm;
        public OrderForm(Menu menu, MenuForm menuForm)
        {
            this.menu = menu;
            this.menuForm = menuForm;
            InitializeComponent();

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(winFormWidth, winFormHeight);

        }

        public virtual void generateUI()
        {
            generateQtyInput(30);
            generateEndButtons(50);
        }

        protected void generateQtyInput(int y)
        {
            this.tbQty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            // 
            // tbQty
            // 
            this.tbQty.Location = new System.Drawing.Point(140, y - 2);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(70, 20);
            this.tbQty.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, y);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Masukkan jumlah order";

            this.Controls.Add(this.tbQty);
            this.Controls.Add(this.label1);
        }

        protected void generateEndButtons(int y)
        {
            this.lblDebug = new System.Windows.Forms.Label();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnAffirmative = new System.Windows.Forms.Button();
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.Location = new System.Drawing.Point(12, y);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(49, 13);
            this.lblDebug.TabIndex = 11;
            this.lblDebug.Text = "";
            // 
            // btnNegative
            // 
            this.btnNegative.Location = new System.Drawing.Point(55, y + 32);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(75, 23);
            this.btnNegative.TabIndex = 10;
            this.btnNegative.Text = "Cancel";
            this.btnNegative.UseVisualStyleBackColor = true;
            this.btnNegative.Click += (sender, EventArgs) => btnNegative_Click(sender, EventArgs);
            // 
            // btnAffirmative
            // 
            this.btnAffirmative.AllowDrop = true;
            this.btnAffirmative.Location = new System.Drawing.Point(135, y + 32);
            this.btnAffirmative.Name = "btnAffirmative";
            this.btnAffirmative.Size = new System.Drawing.Size(75, 23);
            this.btnAffirmative.TabIndex = 9;
            this.btnAffirmative.Text = "OK";
            this.btnAffirmative.UseVisualStyleBackColor = true;
            this.btnAffirmative.Click += (sender, EventArgs) => btnAffirmative_Click(sender, EventArgs);


            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btnAffirmative);
        }

        protected void btnNegative_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        protected virtual int collectQtyData()
        {
            int qty;
            if (int.TryParse(this.tbQty.Text, out qty))
            {
                qty = Int32.Parse(this.tbQty.Text);
                return qty;
            }
            else
            {
                throw new CustomException("Jumlah order tidak valid");
            }
        }
        protected virtual void btnAffirmative_Click(object sender, EventArgs e)
        {
            try
            {
                Order order;
                order = new Order(this.menu, collectQtyData());
                this.menuForm.addOrder(order);

                Dispose();
            }
            catch (Exception ex)
            {
                this.lblDebug.Text = ex.Message;
            }

        }
    }
}
