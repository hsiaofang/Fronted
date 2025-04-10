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
                    var apiUrl = "https://yourapi.com/api/orders"; // �������A��ݪ� API URL
                    var response = await client.GetStringAsync(apiUrl);
                    var orders = JsonConvert.DeserializeObject<List<OrderViewModel>>(response);

                    dgvOrders.Rows.Clear();

                    foreach (var order in orders)
                    {
                        dgvOrders.Rows.Add(
                            order.LastUpdated.ToString("yyyy/MM/dd"),
                            order.Status,
                            order.IntervalNumber,
                            order.Vendor,
                            order.Quantity,
                            order.TotalAmount,
                            $"{order.CustomerName} / {order.Phone} / {order.Address} / {order.PickupStore}",
                            "�s�� / �R��"
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"���J�q���Ʈɵo�Ϳ��~: {ex.Message}");
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
            var start = dtpStart.Value;
            var end = dtpEnd.Value;
            var status = cmbStatus.SelectedItem?.ToString();
            var vendor = cmbVendor.SelectedItem?.ToString();

            var filtered = GetOrders()
                .Where(o => o.LastUpdated >= start && o.LastUpdated <= end)
                .Where(o => string.IsNullOrEmpty(status) || o.Status == status)
                .Where(o => string.IsNullOrEmpty(vendor) || o.Vendor == vendor)
                .ToList();

            // ���s�j�w����
            BindToGrid(filtered);
        }
    }
}
