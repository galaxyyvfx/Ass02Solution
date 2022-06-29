namespace SalesWinApp
{
    partial class frmOrderInput
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
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblRequiredDate = new System.Windows.Forms.Label();
            this.lblShippedDate = new System.Windows.Forms.Label();
            this.lblFreight = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.numOrderID = new System.Windows.Forms.NumericUpDown();
            this.numMemberID = new System.Windows.Forms.NumericUpDown();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.dtpShippedDate = new System.Windows.Forms.DateTimePicker();
            this.numFreight = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMemberID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFreight)).BeginInit();
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
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(22, 79);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(84, 20);
            this.lblMemberID.TabIndex = 1;
            this.lblMemberID.Text = "Member ID";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(22, 119);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(83, 20);
            this.lblOrderDate.TabIndex = 2;
            this.lblOrderDate.Text = "Order Date";
            // 
            // lblRequiredDate
            // 
            this.lblRequiredDate.AutoSize = true;
            this.lblRequiredDate.Location = new System.Drawing.Point(22, 159);
            this.lblRequiredDate.Name = "lblRequiredDate";
            this.lblRequiredDate.Size = new System.Drawing.Size(105, 20);
            this.lblRequiredDate.TabIndex = 3;
            this.lblRequiredDate.Text = "Required Date";
            // 
            // lblShippedDate
            // 
            this.lblShippedDate.AutoSize = true;
            this.lblShippedDate.Location = new System.Drawing.Point(22, 199);
            this.lblShippedDate.Name = "lblShippedDate";
            this.lblShippedDate.Size = new System.Drawing.Size(100, 20);
            this.lblShippedDate.TabIndex = 4;
            this.lblShippedDate.Text = "Shipped Date";
            // 
            // lblFreight
            // 
            this.lblFreight.AutoSize = true;
            this.lblFreight.Location = new System.Drawing.Point(22, 239);
            this.lblFreight.Name = "lblFreight";
            this.lblFreight.Size = new System.Drawing.Size(55, 20);
            this.lblFreight.TabIndex = 5;
            this.lblFreight.Text = "Freight";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(87, 286);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(229, 286);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // numOrderID
            // 
            this.numOrderID.Enabled = false;
            this.numOrderID.Location = new System.Drawing.Point(152, 37);
            this.numOrderID.Name = "numOrderID";
            this.numOrderID.Size = new System.Drawing.Size(231, 27);
            this.numOrderID.TabIndex = 14;
            // 
            // numMemberID
            // 
            this.numMemberID.Location = new System.Drawing.Point(152, 77);
            this.numMemberID.Name = "numMemberID";
            this.numMemberID.Size = new System.Drawing.Size(231, 27);
            this.numMemberID.TabIndex = 15;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(152, 114);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(231, 27);
            this.dtpOrderDate.TabIndex = 16;
            // 
            // dtpRequiredDate
            // 
            this.dtpRequiredDate.Location = new System.Drawing.Point(152, 154);
            this.dtpRequiredDate.Name = "dtpRequiredDate";
            this.dtpRequiredDate.Size = new System.Drawing.Size(231, 27);
            this.dtpRequiredDate.TabIndex = 17;
            // 
            // dtpShippedDate
            // 
            this.dtpShippedDate.Location = new System.Drawing.Point(152, 194);
            this.dtpShippedDate.Name = "dtpShippedDate";
            this.dtpShippedDate.Size = new System.Drawing.Size(231, 27);
            this.dtpShippedDate.TabIndex = 18;
            // 
            // numFreight
            // 
            this.numFreight.Location = new System.Drawing.Point(152, 237);
            this.numFreight.Name = "numFreight";
            this.numFreight.Size = new System.Drawing.Size(231, 27);
            this.numFreight.TabIndex = 19;
            // 
            // frmOrderInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 341);
            this.Controls.Add(this.numFreight);
            this.Controls.Add(this.dtpShippedDate);
            this.Controls.Add(this.dtpRequiredDate);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.numMemberID);
            this.Controls.Add(this.numOrderID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblFreight);
            this.Controls.Add(this.lblShippedDate);
            this.Controls.Add(this.lblRequiredDate);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblMemberID);
            this.Controls.Add(this.lblOrderID);
            this.Name = "frmOrderInput";
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.numOrderID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMemberID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFreight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblOrderID;
        private Label lblMemberID;
        private Label lblOrderDate;
        private Label lblRequiredDate;
        private Label lblShippedDate;
        private Label lblFreight;
        private Button btnSave;
        private Button btnCancel;
        private NumericUpDown numOrderID;
        private NumericUpDown numMemberID;
        private DateTimePicker dtpOrderDate;
        private DateTimePicker dtpRequiredDate;
        private DateTimePicker dtpShippedDate;
        private NumericUpDown numFreight;
    }
}