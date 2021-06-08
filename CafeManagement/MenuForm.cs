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
    public partial class MenuForm : Form
    {
        private List<Menu> menuList;
        private List<OrderItemSummary> orderItemSummaries;
        private List<Order> orders;
        private List<OrderMinuman> orderMinumans;

        public MenuForm()
        {
            InitializeComponent();
            orderItemSummaries = new List<OrderItemSummary>();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            menuList = MenuController.GetAllMenu();
            this.orderItemSummaries = new List<OrderItemSummary>();
            this.orders = new List<Order>();
            this.orderMinumans = new List<OrderMinuman>();
            dgvRingkasanOrder.DataSource = this.orderItemSummaries;
            generateMenuItemsView();
        }

        private void generateMenuItemsView()
        {
            string parentDir = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).FullName;
            int totalMenu = menuList.Count;

            groupBoxesList = new GroupBox[totalMenu];
            gambarMenuList = new PictureBox[totalMenu];
            labelNamaList = new Label[totalMenu];
            labelDeskripsiList = new Label[totalMenu];
            labelHargaList = new Label[totalMenu];
            buttonTambahList = new Button[totalMenu];

            int gbWidth = 200;
            int gbHeight = 380;

            int menuFormWidth = (this.Size.Width - 320);
            int menuItemsPerRow = menuFormWidth / gbWidth;

            for (int i = 0; i < menuList.Count; i++)
            {
                // GROUP BOXES
                GroupBox gbMenuItem = new GroupBox();

                int groupBox_x = (10 + gbWidth) * (i % menuItemsPerRow);
                int groupBox_y = (10 + gbHeight) * (i / menuItemsPerRow);
                gbMenuItem.Location = new System.Drawing.Point(groupBox_x, groupBox_y);
                gbMenuItem.Name = "gbMenuItem" + menuList[i].menu_id;
                gbMenuItem.Size = new System.Drawing.Size(gbWidth, gbHeight);
                gbMenuItem.TabStop = false;
                gbMenuItem.Visible = true;
                gbMenuItem.Text = "Menu ID: " + menuList[i].menu_id;
                this.groupBoxesList[i] = gbMenuItem;

                //PICTURE BOXES
                PictureBox gambarMenu = new PictureBox();

                gambarMenu.Location = new System.Drawing.Point(10, 15);
                gambarMenu.Name = "pbGambarMenu" + menuList[i].menu_id;
                gambarMenu.Size = new System.Drawing.Size(180, 180);
                gambarMenu.ImageLocation = parentDir + menuList[i].gambar_menu;
                gambarMenu.AutoSize = false;
                this.gambarMenuList[i] = gambarMenu;


                // LABEL NAMA
                Label lblNama = new Label();

                lblNama.AutoSize = true;
                lblNama.Location = new System.Drawing.Point(10, 195);
                lblNama.Name = "lblNama" + menuList[i].menu_id;
                lblNama.Size = new System.Drawing.Size(0, 32);
                lblNama.Text = menuList[i].nama_menu;
                lblNama.Visible = true;
                this.labelNamaList[i] = lblNama;

                // LABEL DESKRIPSI
                Label lblDesk = new Label();

                lblDesk.AutoSize = true;
                lblDesk.MaximumSize = new System.Drawing.Size(180, 64);
                lblDesk.Location = new System.Drawing.Point(10, 227);
                lblDesk.Name = "lblDeskripsi" + menuList[i].menu_id;
                lblDesk.Size = new System.Drawing.Size(0, 16);
                lblDesk.Text = menuList[i].deskripsi;
                lblDesk.Visible = true;
                this.labelDeskripsiList[i] = lblDesk;

                // LABEL HARGA
                Label lblHarga = new Label();

                lblHarga.AutoSize = true;
                lblHarga.Location = new System.Drawing.Point(10, 291);
                lblHarga.Name = "lblHarga" + menuList[i].menu_id;
                lblHarga.Size = new System.Drawing.Size(0, 32);
                lblHarga.Text = "Rp " + menuList[i].harga.ToString();
                lblHarga.Visible = true;
                this.labelHargaList[i] = lblHarga;


                //BUTTON TAMBAH
                Button btnTambah = new Button();

                btnTambah.Location = new System.Drawing.Point(10, 323);
                btnTambah.Name = "buttonTambah" + menuList[i].menu_id;
                btnTambah.Size = new System.Drawing.Size(78, 46);
                btnTambah.Text = "+";
                btnTambah.UseVisualStyleBackColor = true;
                btnTambah.Visible = true;
                btnTambah.Click += (sender, EventArgs) => btnTambah_Click(sender, EventArgs, btnTambah.Name.Replace("buttonTambah", ""));
                this.buttonTambahList[i] = btnTambah;


                //ADD TO GROUP BOX AND TO WINDOWS FORM
                gbMenuItem.Controls.Add(gambarMenuList[i]);
                gbMenuItem.Controls.Add(labelNamaList[i]);
                gbMenuItem.Controls.Add(labelDeskripsiList[i]);
                gbMenuItem.Controls.Add(labelHargaList[i]);
                gbMenuItem.Controls.Add(buttonTambahList[i]);
                this.Controls.Add(groupBoxesList[i]);
                //gbMenuItem.SuspendLayout();

            }
        }

        private void btnTambah_Click(object sender, EventArgs e, string menu_id_str)
        {
            int menu_id = Int32.Parse(menu_id_str);
            Menu selectedMenu = MenuController.GetMenuById(menu_id);

            OrderForm orderForm;
            if (selectedMenu.ismakanan == true)
            {
                orderForm = new OrderForm(selectedMenu, this);

            }
            else
            {
                orderForm = new OrderMinumanForm(selectedMenu, this);

            }
            orderForm.generateUI();
            orderForm.ShowDialog();

        }

        public void addOrder(Order order)
        {
            this.orders.Add(order);

            OrderItemSummary ois = new OrderItemSummary(order.Menu.nama_menu.Trim(), order.quantity, order.harga_item_xqty);
            this.orderItemSummaries.Add(ois);


            reloadOrderSummary();
        }

        public void addOrder(OrderMinuman orderMinuman)
        {
            this.orderMinumans.Add(orderMinuman);

            string ringkasanOrder = orderMinuman.Menu.nama_menu.Trim() + "(" + orderMinuman.Size1.size1.Trim() + ") + " + orderMinuman.Topping.nama_topping.Trim();
            OrderItemSummary ois = new OrderItemSummary(ringkasanOrder, orderMinuman.quantity, orderMinuman.harga_item_xqty);

            this.orderItemSummaries.Add(ois);
            this.lblDebug.Text = ois.Ringkasan_Order + " " + this.orderItemSummaries.Count;


            reloadOrderSummary();
        }

        private void reloadOrderSummary()
        {
            //dgvRingkasanOrder.Rows.Add(this.orderItemSummaries[this.orderItemSummaries.Count - 1]);
            dgvRingkasanOrder.DataSource = null;
            dgvRingkasanOrder.Update();
            dgvRingkasanOrder.Refresh();
            dgvRingkasanOrder.DataSource = this.orderItemSummaries;
            HitungTotalBayar();

        }

        public decimal totalHargaSebelumPajak { get; set; }
        public decimal totalPajak { get; set; }
        public decimal total { get; set; }

        public void HitungTotalBayar()
        {
            this.totalHargaSebelumPajak = 0;
            this.totalPajak = 0;
            this.total = 0;
            foreach (Order order in orders)
            {
              this.totalHargaSebelumPajak += order.harga_item_xqty;
              this.totalPajak += order.harga_item_xqty* GlobalVariable.ppn;
              this.total+= order.harga_item_xqty+ order.harga_item_xqty* GlobalVariable.ppn;
            }
            foreach (OrderMinuman order in orderMinumans)
            {
                this.totalHargaSebelumPajak += order.harga_item_xqty;
                this.totalPajak += order.harga_item_xqty * GlobalVariable.ppn;
                this.total += order.harga_item_xqty + order.harga_item_xqty * GlobalVariable.ppn;
            }
            this.lblTotalNonPajak.Text = this.totalHargaSebelumPajak.ToString();
            this.lblTotalPajak.Text = this.totalPajak.ToString();
            this.lblTotalBayar.Text = this.total.ToString();
        }

    private void lblGuideTotalNonPajak_Click(object sender, EventArgs e)
        {

        }

        private void lblGuideTotalBayar_Click(object sender, EventArgs e)
        {
            
        }
    }

    public class OrderItemSummary

    {
        public string Ringkasan_Order { get; set; }
        public int Qty { get; set; }
        public decimal Harga_Item_x_Qty { get; set; }

        public OrderItemSummary()
        {

        }
        public OrderItemSummary(string ringkasanOrder, int qty, decimal hargaItemxQty)
        {
            this.Ringkasan_Order = ringkasanOrder;
            this.Qty = qty;
            this.Harga_Item_x_Qty = hargaItemxQty;
        }

    }
}
