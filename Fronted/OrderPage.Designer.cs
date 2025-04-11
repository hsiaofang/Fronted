namespace Fronted
{
    partial class OrderPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            cmbStatus = new ComboBox();
            cmbVendor = new ComboBox();
            btnSearch = new Button();
            btnAddOrder = new Button();
            dgvOrders = new DataGridView();
            LastUpdated = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            IntervalNumber = new DataGridViewTextBoxColumn();
            Vendor = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            CustomerInfo = new DataGridViewTextBoxColumn();
            Action = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(81, 115);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(134, 23);
            dtpStart.TabIndex = 0;
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(238, 115);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(128, 23);
            dtpEnd.TabIndex = 1;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(390, 115);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(114, 23);
            cmbStatus.TabIndex = 2;
            cmbStatus.Text = "狀態篩選\n";
            cmbStatus.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cmbVendor
            // 
            cmbVendor.FormattingEnabled = true;
            cmbVendor.Location = new Point(541, 115);
            cmbVendor.Name = "cmbVendor";
            cmbVendor.Size = new Size(116, 23);
            cmbVendor.TabIndex = 6;
            cmbVendor.Text = "廠商名稱";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1147, 114);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(91, 23);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "搜尋";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(1259, 114);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(80, 23);
            btnAddOrder.TabIndex = 9;
            btnAddOrder.Text = "➕ 新增訂單";
            btnAddOrder.UseVisualStyleBackColor = true;
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { LastUpdated, Status, IntervalNumber, Vendor, Quantity, TotalAmount, CustomerInfo, Action });
            dgvOrders.Location = new Point(81, 163);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.Size = new Size(1565, 708);
            dgvOrders.TabIndex = 10;
            dgvOrders.CellContentClick += dgvOrders_CellContentClick;
            // 
            // LastUpdated
            // 
            LastUpdated.HeaderText = "最後更新時間";
            LastUpdated.Name = "LastUpdated";
            // 
            // Status
            // 
            Status.HeaderText = "狀態";
            Status.Name = "Status";
            // 
            // IntervalNumber
            // 
            IntervalNumber.HeaderText = "區間單號";
            IntervalNumber.Name = "IntervalNumber";
            // 
            // Vendor
            // 
            Vendor.HeaderText = "廠商";
            Vendor.Name = "Vendor";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "數量";
            Quantity.Name = "Quantity";
            // 
            // TotalAmount
            // 
            TotalAmount.HeaderText = "總金額";
            TotalAmount.Name = "TotalAmount";
            // 
            // CustomerInfo
            // 
            CustomerInfo.HeaderText = "客戶資料";
            CustomerInfo.Name = "CustomerInfo";
            // 
            // Action
            // 
            Action.HeaderText = "操作";
            Action.Name = "Action";
            // 
            // OrderPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1964, 1041);
            Controls.Add(dgvOrders);
            Controls.Add(btnAddOrder);
            Controls.Add(btnSearch);
            Controls.Add(cmbVendor);
            Controls.Add(cmbStatus);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Name = "OrderPage";
            Text = "Form1";
            Load += OrderPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private ComboBox cmbStatus;
        private ComboBox cmbVendor;
        private Button btnSearch;
        private Button btnAddOrder;
        private DataGridView dgvOrders;
        private DataGridViewTextBoxColumn LastUpdated;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn IntervalNumber;
        private DataGridViewTextBoxColumn Vendor;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn TotalAmount;
        private DataGridViewTextBoxColumn CustomerInfo;
        private DataGridViewTextBoxColumn Action;
    }
}
