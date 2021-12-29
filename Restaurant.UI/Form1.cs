using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RestaurantApi.CQRS.Queries.Request;
using RestaurantApi.CQRS.Queries.Response;
using RestaurantApi.Models.Data;
using RestaurantApi.Models.Entity.Factories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cboBosMasalar.DisplayMember = "TableName";
            cboBosMasalar.ValueMember = "Id";
            dtpRezervasyonSaati.Format = DateTimePickerFormat.Time;
            dtpRezervasyonSaati.ShowUpDown = true;
            ListEmptyTables();
        }

        private void btnRezervasyonOnay_Click(object sender, EventArgs e)
        {
            CustomerFactory.GetInstance().CreateNewCustomerReservation(txtAd.Text);

            MessageBox.Show($"{cboBosMasalar.SelectedIndex + 1} numaralı masa için rezervasyonunuz {dtpRezervasyonSaati.Value} saatine başarıyla yapılmıştır.");
            ListEmptyTables();
            cboBosMasalar.Refresh();
        }
        
        private void ListEmptyTables()
        {
            cboBosMasalar.DataSource = EmptyTableLister.GetInstance().GetEmptyTables();
        }
    }
}
