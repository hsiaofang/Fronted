using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Configuration;
using Newtonsoft.Json.Linq;

namespace Fronted
{
    public partial class OrderPage : Form
    {
        public OrderPage()
        {
            InitializeComponent();
        }



        private async void LoadOrders()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var apiUrl = "https://localhost:5279/orders";
                    var response = await client.GetStringAsync(apiUrl);
                    var orders = JsonConvert.DeserializeObject<List<OrderViewModel>>(response);
                    
                    cmbStatus.DataSource = orders;
                    cmbVendor.DataSource = orders;

                    dgvOrders.Rows.Clear();

                    foreach (var order in orders)
                    {
                        dgvOrders.Rows.Add(
                            order.LastUpdated.ToString("yyyy/MM/dd"),
                            order.Status,
                            order.IntervalNumber,
                            order.VendorName,
                            order.Quantity,
                            order.TotalAmount,
                            $"{order.CustomerName} / {order.CustomerPhone} / {order.CustomerAddress} / {order.PickupStore}",
                            "編輯 / 刪除"
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入訂單資料時發生錯誤: {ex.Message}");
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            var start = dtpStart.Value.Date;
            var end = dtpEnd.Value.Date.AddDays(1).AddTicks(-1);

            var status = cmbStatus.SelectedItem?.ToString();
            var vendor = cmbVendor.SelectedItem?.ToString();


            var filtered = LoadOrders()
                .Where(o => o.LastUpdated >= start && o.LastUpdated <= end)
                .Where(o => string.IsNullOrEmpty(status) || o.Status == status)
                .Where(o => string.IsNullOrEmpty(vendor) || o.Vendor?.ToString() == vendor)
                .ToList();

            UpdatedgvOrders(filtered);
        }


        private void UpdatedgvOrders(List<OrderViewModel> OrderViewModels)
        {
            foreach (var order in OrderViewModels)
            {
                dgvOrders.Rows.Add(
                    order.LastUpdated.ToString("yyyy/MM/dd"),
                    order.Status,
                    order.IntervalNumber,
                    order.VendorName,
                    order.Quantity,
                    order.TotalAmount,
                    $"{order.CustomerName} / {order.CustomerPhone} / {order.CustomerAddress} / {order.PickupStore}",
                    "編輯 / 刪除"
                );
            }
        }
       

        private void OrderPage_Load(object sender, EventArgs e)
        {


        }
    }
}
