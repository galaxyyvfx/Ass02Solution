namespace SalesWinApp
{
    partial class frmProducts
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
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblUnitInStock = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.numUnitPriceMin = new System.Windows.Forms.NumericUpDown();
            this.numUnitPriceMax = new System.Windows.Forms.NumericUpDown();
            this.numUnitsInStockMax = new System.Windows.Forms.NumericUpDown();
            this.numUnitsInStockMin = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPriceMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPriceMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitsInStockMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitsInStockMin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductID.Location = new System.Drawing.Point(27, 25);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(105, 28);
            this.lblProductID.TabIndex = 0;
            this.lblProductID.Text = "Product ID";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductName.Location = new System.Drawing.Point(27, 74);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(138, 28);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUnitPrice.Location = new System.Drawing.Point(413, 22);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(96, 28);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblUnitInStock
            // 
            this.lblUnitInStock.AutoSize = true;
            this.lblUnitInStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUnitInStock.Location = new System.Drawing.Point(413, 71);
            this.lblUnitInStock.Name = "lblUnitInStock";
            this.lblUnitInStock.Size = new System.Drawing.Size(131, 28);
            this.lblUnitInStock.TabIndex = 3;
            this.lblUnitInStock.Text = "Units in Stock";
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(12, 186);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 29;
            this.dgvProducts.Size = new System.Drawing.Size(786, 333);
            this.dgvProducts.TabIndex = 4;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInsert.Location = new System.Drawing.Point(809, 186);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(121, 49);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(809, 251);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 49);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(809, 316);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 49);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(27, 119);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(380, 49);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductID.Location = new System.Drawing.Point(170, 22);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(237, 34);
            this.txtProductID.TabIndex = 9;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductName.Location = new System.Drawing.Point(170, 71);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(237, 34);
            this.txtProductName.TabIndex = 10;
            // 
            // numUnitPriceMin
            // 
            this.numUnitPriceMin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numUnitPriceMin.Location = new System.Drawing.Point(559, 20);
            this.numUnitPriceMin.Name = "numUnitPriceMin";
            this.numUnitPriceMin.Size = new System.Drawing.Size(85, 34);
            this.numUnitPriceMin.TabIndex = 11;
            this.numUnitPriceMin.ThousandsSeparator = true;
            // 
            // numUnitPriceMax
            // 
            this.numUnitPriceMax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numUnitPriceMax.Location = new System.Drawing.Point(665, 20);
            this.numUnitPriceMax.Name = "numUnitPriceMax";
            this.numUnitPriceMax.Size = new System.Drawing.Size(85, 34);
            this.numUnitPriceMax.TabIndex = 12;
            this.numUnitPriceMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numUnitsInStockMax
            // 
            this.numUnitsInStockMax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numUnitsInStockMax.Location = new System.Drawing.Point(665, 69);
            this.numUnitsInStockMax.Name = "numUnitsInStockMax";
            this.numUnitsInStockMax.Size = new System.Drawing.Size(85, 34);
            this.numUnitsInStockMax.TabIndex = 14;
            this.numUnitsInStockMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numUnitsInStockMin
            // 
            this.numUnitsInStockMin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numUnitsInStockMin.Location = new System.Drawing.Point(559, 69);
            this.numUnitsInStockMin.Name = "numUnitsInStockMin";
            this.numUnitsInStockMin.Size = new System.Drawing.Size(85, 34);
            this.numUnitsInStockMin.TabIndex = 13;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 531);
            this.Controls.Add(this.numUnitsInStockMax);
            this.Controls.Add(this.numUnitsInStockMin);
            this.Controls.Add(this.numUnitPriceMax);
            this.Controls.Add(this.numUnitPriceMin);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.lblUnitInStock);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductID);
            this.Name = "frmProducts";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPriceMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPriceMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitsInStockMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitsInStockMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblProductID;
        private Label lblProductName;
        private Label lblUnitPrice;
        private Label lblUnitInStock;
        private DataGridView dgvProducts;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private TextBox txtProductID;
        private TextBox txtProductName;
        private NumericUpDown numUnitPriceMin;
        private NumericUpDown numUnitPriceMax;
        private NumericUpDown numUnitsInStockMax;
        private NumericUpDown numUnitsInStockMin;
    }
}