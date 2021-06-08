
using System.Collections.Generic;
using System.Windows.Forms;

namespace CafeManagement
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDebug = new System.Windows.Forms.Label();
            this.gbTransaksiSum = new System.Windows.Forms.GroupBox();
            this.lblTotalBayar = new System.Windows.Forms.Label();
            this.lblTotalPajak = new System.Windows.Forms.Label();
            this.lblTotalNonPajak = new System.Windows.Forms.Label();
            this.lblGuideTotalBayar = new System.Windows.Forms.Label();
            this.lblGuideTotalPajak = new System.Windows.Forms.Label();
            this.lblGuideTotalNonPajak = new System.Windows.Forms.Label();
            this.dgvRingkasanOrder = new System.Windows.Forms.DataGridView();
            this.gbTransaksiSum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRingkasanOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDebug.Location = new System.Drawing.Point(0, 550);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(168, 32);
            this.lblDebug.TabIndex = 0;
            this.lblDebug.Text = "Debug label";
            // 
            // gbTransaksiSum
            // 
            this.gbTransaksiSum.Controls.Add(this.lblTotalBayar);
            this.gbTransaksiSum.Controls.Add(this.lblTotalPajak);
            this.gbTransaksiSum.Controls.Add(this.lblTotalNonPajak);
            this.gbTransaksiSum.Controls.Add(this.lblGuideTotalBayar);
            this.gbTransaksiSum.Controls.Add(this.lblGuideTotalPajak);
            this.gbTransaksiSum.Controls.Add(this.lblGuideTotalNonPajak);
            this.gbTransaksiSum.Location = new System.Drawing.Point(631, 451);
            this.gbTransaksiSum.Name = "gbTransaksiSum";
            this.gbTransaksiSum.Size = new System.Drawing.Size(300, 107);
            this.gbTransaksiSum.TabIndex = 2;
            this.gbTransaksiSum.TabStop = false;
            this.gbTransaksiSum.Text = "Ringkasan Pembayaran";
            // 
            // lblTotalBayar
            // 
            this.lblTotalBayar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalBayar.AutoSize = true;
            this.lblTotalBayar.Location = new System.Drawing.Point(246, 78);
            this.lblTotalBayar.Name = "lblTotalBayar";
            this.lblTotalBayar.Size = new System.Drawing.Size(31, 32);
            this.lblTotalBayar.TabIndex = 5;
            this.lblTotalBayar.Text = "0";
            // 
            // lblTotalPajak
            // 
            this.lblTotalPajak.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalPajak.AutoSize = true;
            this.lblTotalPajak.Location = new System.Drawing.Point(246, 53);
            this.lblTotalPajak.Name = "lblTotalPajak";
            this.lblTotalPajak.Size = new System.Drawing.Size(31, 32);
            this.lblTotalPajak.TabIndex = 4;
            this.lblTotalPajak.Text = "0";
            // 
            // lblTotalNonPajak
            // 
            this.lblTotalNonPajak.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalNonPajak.AutoSize = true;
            this.lblTotalNonPajak.Location = new System.Drawing.Point(246, 25);
            this.lblTotalNonPajak.Name = "lblTotalNonPajak";
            this.lblTotalNonPajak.Size = new System.Drawing.Size(31, 32);
            this.lblTotalNonPajak.TabIndex = 3;
            this.lblTotalNonPajak.Text = "0";
            // 
            // lblGuideTotalBayar
            // 
            this.lblGuideTotalBayar.AutoSize = true;
            this.lblGuideTotalBayar.Location = new System.Drawing.Point(6, 78);
            this.lblGuideTotalBayar.Name = "lblGuideTotalBayar";
            this.lblGuideTotalBayar.Size = new System.Drawing.Size(160, 32);
            this.lblGuideTotalBayar.TabIndex = 2;
            this.lblGuideTotalBayar.Text = "Total Bayar";
            this.lblGuideTotalBayar.Click += new System.EventHandler(this.lblGuideTotalBayar_Click);
            // 
            // lblGuideTotalPajak
            // 
            this.lblGuideTotalPajak.AutoSize = true;
            this.lblGuideTotalPajak.Location = new System.Drawing.Point(6, 53);
            this.lblGuideTotalPajak.Name = "lblGuideTotalPajak";
            this.lblGuideTotalPajak.Size = new System.Drawing.Size(158, 32);
            this.lblGuideTotalPajak.TabIndex = 1;
            this.lblGuideTotalPajak.Text = "Total Pajak";
            // 
            // lblGuideTotalNonPajak
            // 
            this.lblGuideTotalNonPajak.AutoSize = true;
            this.lblGuideTotalNonPajak.Location = new System.Drawing.Point(6, 25);
            this.lblGuideTotalNonPajak.Name = "lblGuideTotalNonPajak";
            this.lblGuideTotalNonPajak.Size = new System.Drawing.Size(278, 32);
            this.lblGuideTotalNonPajak.TabIndex = 0;
            this.lblGuideTotalNonPajak.Text = "Total Sebelum Pajak";
            this.lblGuideTotalNonPajak.Click += new System.EventHandler(this.lblGuideTotalNonPajak_Click);
            // 
            // dgvRingkasanOrder
            // 
            this.dgvRingkasanOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRingkasanOrder.Location = new System.Drawing.Point(631, 12);
            this.dgvRingkasanOrder.Name = "dgvRingkasanOrder";
            this.dgvRingkasanOrder.RowHeadersWidth = 102;
            this.dgvRingkasanOrder.Size = new System.Drawing.Size(300, 433);
            this.dgvRingkasanOrder.TabIndex = 3;
            // 
            // MenuForm
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(946, 582);
            this.Controls.Add(this.dgvRingkasanOrder);
            this.Controls.Add(this.gbTransaksiSum);
            this.Controls.Add(this.lblDebug);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.gbTransaksiSum.ResumeLayout(false);
            this.gbTransaksiSum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRingkasanOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox[] groupBoxesList;
        private PictureBox[] gambarMenuList;
        private Label[] labelNamaList;
        private Label[] labelDeskripsiList;
        private Label[] labelHargaList;
        private Button[] buttonTambahList;
        private Label lblDebug;
        private GroupBox gbTransaksiSum;
        private Label lblTotalBayar;
        private Label lblTotalPajak;
        private Label lblTotalNonPajak;
        private Label lblGuideTotalBayar;
        private Label lblGuideTotalPajak;
        private Label lblGuideTotalNonPajak;
        private DataGridView dgvRingkasanOrder;
    }
}

