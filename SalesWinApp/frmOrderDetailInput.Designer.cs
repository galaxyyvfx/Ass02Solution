namespace SalesWinApp
{
    partial class frmOrderDetailInput
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
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.numOrderID = new System.Windows.Forms.NumericUpDown();
            this.numProductID = new System.Windows.Forms.NumericUpDown();
            this.numUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProductID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(22, 39);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(66, 20);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "Order ID";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(22, 79);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(79, 20);
            this.lblProductID.TabIndex = 1;
            this.lblProductID.Text = "Product ID";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(22, 119);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(72, 20);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(22, 159);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(65, 20);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(22, 199);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(67, 20);
            this.lblDiscount.TabIndex = 4;
            this.lblDiscount.Text = "Discount";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(87, 254);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(229, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // numOrderID
            // 
            this.numOrderID.Location = new System.Drawing.Point(152, 37);
            this.numOrderID.Name = "numOrderID";
            this.numOrderID.Size = new System.Drawing.Size(231, 27);
            this.numOrderID.TabIndex = 14;
            // 
            // numProductID
            // 
            this.numProductID.Location = new System.Drawing.Point(152, 77);
            this.numProductID.Name = "numProductID";
            this.numProductID.Size = new System.Drawing.Size(231, 27);
            this.numProductID.TabIndex = 15;
            // 
            // numUnitPrice
            // 
            this.numUnitPrice.DecimalPlaces = 3;
            this.numUnitPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numUnitPrice.Location = new System.Drawing.Point(152, 117);
            this.numUnitPrice.Name = "numUnitPrice";
            this.numUnitPrice.Size = new System.Drawing.Size(231, 27);
            this.numUnitPrice.TabIndex = 16;
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(152, 157);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(231, 27);
            this.numQuantity.TabIndex = 17;
            // 
            // numDiscount
            // 
            this.numDiscount.DecimalPlaces = 3;
            this.numDiscount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numDiscount.Location = new System.Drawing.Point(152, 197);
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(231, 27);
            this.numDiscount.TabIndex = 18;
            // 
            // frmOrderDetailInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 314);
            this.Controls.Add(this.numDiscount);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.numUnitPrice);
            this.Controls.Add(this.numProductID);
            this.Controls.Add(this.numOrderID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.lblOrderID);
            this.Name = "frmOrderDetailInput";
            this.Text = "Order Detail";
            ((System.ComponentModel.ISupportInitialize)(this.numOrderID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProductID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblOrderID;
        private Label lblProductID;
        private Label lblUnitPrice;
        private Label lblQuantity;
        private Label lblDiscount;
        private Button btnSave;
        private Button btnCancel;
        private NumericUpDown numOrderID;
        private NumericUpDown numProductID;
        private NumericUpDown numUnitPrice;
        private NumericUpDown numQuantity;
        private NumericUpDown numDiscount;
    }
}