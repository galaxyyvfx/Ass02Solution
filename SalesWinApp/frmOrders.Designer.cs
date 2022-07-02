namespace SalesWinApp
{
    partial class frmOrders
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
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.btnInsertOrder = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.btnDeleteOrderDetails = new System.Windows.Forms.Button();
            this.btnUpdateOrderDetail = new System.Windows.Forms.Button();
            this.btnInsertOrderDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(86, 14);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(250, 27);
            this.dtpStartDate.TabIndex = 0;
            this.dtpStartDate.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPeriod.Location = new System.Drawing.Point(12, 12);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(68, 28);
            this.lblPeriod.TabIndex = 1;
            this.lblPeriod.Text = "Period";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(86, 47);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(250, 27);
            this.dtpEndDate.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(342, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 60);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(12, 129);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 29;
            this.dgvOrders.Size = new System.Drawing.Size(451, 293);
            this.dgvOrders.TabIndex = 4;
            // 
            // btnInsertOrder
            // 
            this.btnInsertOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInsertOrder.Location = new System.Drawing.Point(12, 80);
            this.btnInsertOrder.Name = "btnInsertOrder";
            this.btnInsertOrder.Size = new System.Drawing.Size(97, 43);
            this.btnInsertOrder.TabIndex = 5;
            this.btnInsertOrder.Text = "Insert";
            this.btnInsertOrder.UseVisualStyleBackColor = true;
            this.btnInsertOrder.Click += new System.EventHandler(this.btnInsertOrder_Click);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateOrder.Location = new System.Drawing.Point(115, 80);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(97, 43);
            this.btnUpdateOrder.TabIndex = 6;
            this.btnUpdateOrder.Text = "Update";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteOrder.Location = new System.Drawing.Point(218, 80);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(97, 43);
            this.btnDeleteOrder.TabIndex = 7;
            this.btnDeleteOrder.Text = "Delete";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Location = new System.Drawing.Point(469, 129);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowHeadersWidth = 51;
            this.dgvOrderDetail.RowTemplate.Height = 29;
            this.dgvOrderDetail.Size = new System.Drawing.Size(451, 293);
            this.dgvOrderDetail.TabIndex = 8;
            // 
            // btnDeleteOrderDetails
            // 
            this.btnDeleteOrderDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteOrderDetails.Location = new System.Drawing.Point(675, 80);
            this.btnDeleteOrderDetails.Name = "btnDeleteOrderDetails";
            this.btnDeleteOrderDetails.Size = new System.Drawing.Size(97, 43);
            this.btnDeleteOrderDetails.TabIndex = 11;
            this.btnDeleteOrderDetails.Text = "Delete";
            this.btnDeleteOrderDetails.UseVisualStyleBackColor = true;
            this.btnDeleteOrderDetails.Click += new System.EventHandler(this.btnDeleteOrderDetails_Click);
            // 
            // btnUpdateOrderDetail
            // 
            this.btnUpdateOrderDetail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateOrderDetail.Location = new System.Drawing.Point(572, 80);
            this.btnUpdateOrderDetail.Name = "btnUpdateOrderDetail";
            this.btnUpdateOrderDetail.Size = new System.Drawing.Size(97, 43);
            this.btnUpdateOrderDetail.TabIndex = 10;
            this.btnUpdateOrderDetail.Text = "Update";
            this.btnUpdateOrderDetail.UseVisualStyleBackColor = true;
            this.btnUpdateOrderDetail.Click += new System.EventHandler(this.btnUpdateOrderDetail_Click);
            // 
            // btnInsertOrderDetail
            // 
            this.btnInsertOrderDetail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInsertOrderDetail.Location = new System.Drawing.Point(469, 80);
            this.btnInsertOrderDetail.Name = "btnInsertOrderDetail";
            this.btnInsertOrderDetail.Size = new System.Drawing.Size(97, 43);
            this.btnInsertOrderDetail.TabIndex = 9;
            this.btnInsertOrderDetail.Text = "Insert";
            this.btnInsertOrderDetail.UseVisualStyleBackColor = true;
            this.btnInsertOrderDetail.Click += new System.EventHandler(this.btnInsertOrderDetail_Click);
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 434);
            this.Controls.Add(this.btnDeleteOrderDetails);
            this.Controls.Add(this.btnUpdateOrderDetail);
            this.Controls.Add(this.btnInsertOrderDetail);
            this.Controls.Add(this.dgvOrderDetail);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.btnInsertOrder);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.dtpStartDate);
            this.Name = "frmOrders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.frmOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtpStartDate;
        private Label lblPeriod;
        private DateTimePicker dtpEndDate;
        private Button btnSearch;
        private DataGridView dgvOrders;
        private Button btnInsertOrder;
        private Button btnUpdateOrder;
        private Button btnDeleteOrder;
        private DataGridView dgvOrderDetail;
        private Button btnDeleteOrderDetails;
        private Button btnUpdateOrderDetail;
        private Button btnInsertOrderDetail;
    }
}