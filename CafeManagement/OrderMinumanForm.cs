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
    public partial class OrderMinumanForm : OrderForm
    {
        public OrderMinumanForm(Menu menu, MenuForm menuForm):base(menu,menuForm)
        {
            InitializeComponent();
            base.menu = menu;
            base.menuForm = menuForm;
        }

        private void OrderMinumanForm_Load(object sender, EventArgs e)
        {
            

        }

        public override void generateUI()
        {
            generateQtyInput(300);
            generateEndButtons(320);
            generatePilihanSize();
            generatePilihanTopping();
            generateTumblrCheckBox();
        }

        private void generatePilihanTopping()
        {
            this.gbTopping = new System.Windows.Forms.GroupBox();
            // 
            // gbTopping
            // 
            this.gbTopping.Location = new System.Drawing.Point(12, 123);
            this.gbTopping.Name = "gbTopping";
            this.gbTopping.Size = new System.Drawing.Size(200, 124);
            this.gbTopping.TabIndex = 2;
            this.gbTopping.TabStop = false;
            this.gbTopping.Text = "Pilih Topping";


            List<Topping> toppings = ToppingController.getAllTopping();
            radioButtonToppingList = new RadioButton[toppings.Count];

            for (int i = 0; i < toppings.Count; i++)
            {
                System.Windows.Forms.RadioButton rbTopping = new RadioButton();
                rbTopping.AutoSize = true;
                rbTopping.Location = new System.Drawing.Point(15, 15 + (17 * i));
                rbTopping.Name = "rbTopping" + toppings[i].topping_id;
                rbTopping.Size = new System.Drawing.Size(85, 17);
                rbTopping.TabIndex = 0;
                rbTopping.TabStop = true;
                string toppingText = toppings[i].nama_topping.Trim() + " (+Rp" + toppings[i].harga + ")";
                rbTopping.Text = toppingText;
                rbTopping.UseVisualStyleBackColor = true;

                radioButtonToppingList[i] = rbTopping;
                this.gbTopping.Controls.Add(radioButtonToppingList[i]);
            }

            this.Controls.Add(this.gbTopping);
        }

        private void generatePilihanSize()
        {
            this.gbSize = new System.Windows.Forms.GroupBox();
            // 
            // gbSize
            // 
            this.gbSize.Location = new System.Drawing.Point(12, 12);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(200, 100);
            this.gbSize.TabIndex = 3;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Pilih Size";


            List<Size> sizes = SizeController.getAllSize();
            radioButtonSizeList = new RadioButton[sizes.Count];
            for (int i = 0; i < sizes.Count; i++)
            {
                System.Windows.Forms.RadioButton rbSize = new RadioButton();
                rbSize.AutoSize = true;
                rbSize.Location = new System.Drawing.Point(15, 15 + (17 * i));
                rbSize.Name = "rbSize" + sizes[i].size1;
                rbSize.Size = new System.Drawing.Size(85, 17);
                rbSize.TabIndex = 0;
                rbSize.TabStop = true;
                rbSize.Text = sizes[i].size1.Trim() + " (+Rp" + sizes[i].harga + ")";
                rbSize.UseVisualStyleBackColor = true;

                radioButtonSizeList[i] = rbSize;
                this.gbSize.Controls.Add(radioButtonSizeList[i]);
            }
            //base.lblDebug.Text = "generate Size is called";
            this.Controls.Add(this.gbSize);
        }

        private void generateTumblrCheckBox()
        {
            this.cbTumblr = new System.Windows.Forms.CheckBox();
            // 
            // cbTumblr
            // 
            this.cbTumblr.AutoSize = true;
            this.cbTumblr.Location = new System.Drawing.Point(12, 263);
            this.cbTumblr.Name = "cbTumblr";
            this.cbTumblr.Size = new System.Drawing.Size(117, 17);
            this.cbTumblr.TabIndex = 1;
            this.cbTumblr.Text = "Bawa tumblr sendiri";
            this.cbTumblr.UseVisualStyleBackColor = true;

            this.Controls.Add(this.cbTumblr);
        }

        private Topping getSelectedTopping()
        {
            Topping result=null;
            for (int i = 0; i < radioButtonToppingList.Length; i++)
            {
                if (radioButtonToppingList[i].Checked == true)
                {
                    int topping_id = Int32.Parse(radioButtonToppingList[i].Name.Replace("rbTopping", ""));
                    result = ToppingController.getToppingById(topping_id);
                }
            }
            if (result is null)
            {
                throw new CustomException("Tidak ada topping dipilih");
            }
            return result;

        }

        private Size getSelectedSize()
        {
            Size result = null;
            for (int i = 0; i < radioButtonSizeList.Length; i++)
            {
                if (radioButtonSizeList[i].Checked == true)
                {
                    lblDebug.Text = "there is a checked rb size";
                    string size_id = radioButtonSizeList[i].Name.Replace("rbSize", "");
                    result = SizeController.getSizeById(size_id);
                }
            }
            if (result is null)
            {
                throw new CustomException("Tidak ada size dipilih");
            }
            return result;

        }
        protected override void btnAffirmative_Click(object sender, EventArgs e)
        {
            try
            {
                OrderMinuman orderMinuman;
                orderMinuman = new OrderMinuman(this.menu, getSelectedSize(), getSelectedTopping(), this.cbTumblr.Checked, collectQtyData());
                this.lblDebug.Text = this.menu.nama_menu;
                this.menuForm.addOrder(orderMinuman);

                this.Dispose();
            }
            catch (Exception ex)
            {
                this.lblDebug.Text = ex.Message;
            }
        }

    }
}
