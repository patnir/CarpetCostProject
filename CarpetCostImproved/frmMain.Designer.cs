partial class frmMain
{
    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.txtLengthInFeet = new System.Windows.Forms.TextBox();
            this.txtWidthInFeet = new System.Windows.Forms.TextBox();
            this.txtPricePerSquareYard = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTaxAmount = new System.Windows.Forms.TextBox();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.txtCartCount = new System.Windows.Forms.TextBox();
            this.txtCartTotal = new System.Windows.Forms.TextBox();
            this.lblLengthInFeet = new System.Windows.Forms.Label();
            this.lblWidthInFeet = new System.Windows.Forms.Label();
            this.lblPricePerSquareYard = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTaxAmount = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblCartCount = new System.Windows.Forms.Label();
            this.lblCartTotal = new System.Windows.Forms.Label();
            this.btnClearCurrentOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(281, 13);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(281, 182);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(281, 211);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(281, 153);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(75, 23);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // txtLengthInFeet
            // 
            this.txtLengthInFeet.Location = new System.Drawing.Point(138, 12);
            this.txtLengthInFeet.Name = "txtLengthInFeet";
            this.txtLengthInFeet.Size = new System.Drawing.Size(100, 20);
            this.txtLengthInFeet.TabIndex = 4;
            // 
            // txtWidthInFeet
            // 
            this.txtWidthInFeet.Location = new System.Drawing.Point(138, 39);
            this.txtWidthInFeet.Name = "txtWidthInFeet";
            this.txtWidthInFeet.Size = new System.Drawing.Size(100, 20);
            this.txtWidthInFeet.TabIndex = 5;
            // 
            // txtPricePerSquareYard
            // 
            this.txtPricePerSquareYard.Location = new System.Drawing.Point(138, 66);
            this.txtPricePerSquareYard.Name = "txtPricePerSquareYard";
            this.txtPricePerSquareYard.Size = new System.Drawing.Size(100, 20);
            this.txtPricePerSquareYard.TabIndex = 6;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(138, 93);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 7;
            this.txtSubtotal.TabStop = false;
            // 
            // txtTaxAmount
            // 
            this.txtTaxAmount.Location = new System.Drawing.Point(138, 120);
            this.txtTaxAmount.Name = "txtTaxAmount";
            this.txtTaxAmount.ReadOnly = true;
            this.txtTaxAmount.Size = new System.Drawing.Size(100, 20);
            this.txtTaxAmount.TabIndex = 8;
            this.txtTaxAmount.TabStop = false;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(138, 147);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCost.TabIndex = 9;
            this.txtTotalCost.TabStop = false;
            // 
            // txtCartCount
            // 
            this.txtCartCount.Location = new System.Drawing.Point(138, 192);
            this.txtCartCount.Name = "txtCartCount";
            this.txtCartCount.ReadOnly = true;
            this.txtCartCount.Size = new System.Drawing.Size(100, 20);
            this.txtCartCount.TabIndex = 10;
            this.txtCartCount.TabStop = false;
            // 
            // txtCartTotal
            // 
            this.txtCartTotal.Location = new System.Drawing.Point(138, 219);
            this.txtCartTotal.Name = "txtCartTotal";
            this.txtCartTotal.ReadOnly = true;
            this.txtCartTotal.Size = new System.Drawing.Size(100, 20);
            this.txtCartTotal.TabIndex = 11;
            this.txtCartTotal.TabStop = false;
            // 
            // lblLengthInFeet
            // 
            this.lblLengthInFeet.AutoSize = true;
            this.lblLengthInFeet.Location = new System.Drawing.Point(12, 19);
            this.lblLengthInFeet.Name = "lblLengthInFeet";
            this.lblLengthInFeet.Size = new System.Drawing.Size(75, 13);
            this.lblLengthInFeet.TabIndex = 12;
            this.lblLengthInFeet.Text = "Length in feet:";
            // 
            // lblWidthInFeet
            // 
            this.lblWidthInFeet.AutoSize = true;
            this.lblWidthInFeet.Location = new System.Drawing.Point(12, 46);
            this.lblWidthInFeet.Name = "lblWidthInFeet";
            this.lblWidthInFeet.Size = new System.Drawing.Size(70, 13);
            this.lblWidthInFeet.TabIndex = 13;
            this.lblWidthInFeet.Text = "Width in feet:";
            // 
            // lblPricePerSquareYard
            // 
            this.lblPricePerSquareYard.AutoSize = true;
            this.lblPricePerSquareYard.Location = new System.Drawing.Point(13, 72);
            this.lblPricePerSquareYard.Name = "lblPricePerSquareYard";
            this.lblPricePerSquareYard.Size = new System.Drawing.Size(110, 13);
            this.lblPricePerSquareYard.TabIndex = 14;
            this.lblPricePerSquareYard.Text = "Price per square yard:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(13, 99);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 15;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblTaxAmount
            // 
            this.lblTaxAmount.AutoSize = true;
            this.lblTaxAmount.Location = new System.Drawing.Point(13, 126);
            this.lblTaxAmount.Name = "lblTaxAmount";
            this.lblTaxAmount.Size = new System.Drawing.Size(66, 13);
            this.lblTaxAmount.TabIndex = 16;
            this.lblTaxAmount.Text = "Tax amount:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(13, 153);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(57, 13);
            this.lblTotalCost.TabIndex = 17;
            this.lblTotalCost.Text = "Total cost:";
            // 
            // lblCartCount
            // 
            this.lblCartCount.AutoSize = true;
            this.lblCartCount.Location = new System.Drawing.Point(13, 198);
            this.lblCartCount.Name = "lblCartCount";
            this.lblCartCount.Size = new System.Drawing.Size(59, 13);
            this.lblCartCount.TabIndex = 18;
            this.lblCartCount.Text = "Cart count:";
            // 
            // lblCartTotal
            // 
            this.lblCartTotal.AutoSize = true;
            this.lblCartTotal.Location = new System.Drawing.Point(13, 225);
            this.lblCartTotal.Name = "lblCartTotal";
            this.lblCartTotal.Size = new System.Drawing.Size(52, 13);
            this.lblCartTotal.TabIndex = 19;
            this.lblCartTotal.Text = "Cart total:";
            // 
            // btnClearCurrentOrder
            // 
            this.btnClearCurrentOrder.Location = new System.Drawing.Point(281, 50);
            this.btnClearCurrentOrder.Name = "btnClearCurrentOrder";
            this.btnClearCurrentOrder.Size = new System.Drawing.Size(75, 50);
            this.btnClearCurrentOrder.TabIndex = 20;
            this.btnClearCurrentOrder.Text = "Clear current order";
            this.btnClearCurrentOrder.UseVisualStyleBackColor = true;
            this.btnClearCurrentOrder.Click += new System.EventHandler(this.btnClearCurrentOrder_Click);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(368, 251);
            this.Controls.Add(this.btnClearCurrentOrder);
            this.Controls.Add(this.lblCartTotal);
            this.Controls.Add(this.lblCartCount);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblTaxAmount);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblPricePerSquareYard);
            this.Controls.Add(this.lblWidthInFeet);
            this.Controls.Add(this.lblLengthInFeet);
            this.Controls.Add(this.txtCartTotal);
            this.Controls.Add(this.txtCartCount);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.txtTaxAmount);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtPricePerSquareYard);
            this.Controls.Add(this.txtWidthInFeet);
            this.Controls.Add(this.txtLengthInFeet);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    #endregion

    private System.Windows.Forms.Button btnCalculate;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnAddToCart;
    private System.Windows.Forms.TextBox txtLengthInFeet;
    private System.Windows.Forms.TextBox txtWidthInFeet;
    private System.Windows.Forms.TextBox txtPricePerSquareYard;
    private System.Windows.Forms.TextBox txtSubtotal;
    private System.Windows.Forms.TextBox txtTaxAmount;
    private System.Windows.Forms.TextBox txtTotalCost;
    private System.Windows.Forms.TextBox txtCartCount;
    private System.Windows.Forms.TextBox txtCartTotal;
    private System.Windows.Forms.Label lblLengthInFeet;
    private System.Windows.Forms.Label lblWidthInFeet;
    private System.Windows.Forms.Label lblPricePerSquareYard;
    private System.Windows.Forms.Label lblSubtotal;
    private System.Windows.Forms.Label lblTaxAmount;
    private System.Windows.Forms.Label lblTotalCost;
    private System.Windows.Forms.Label lblCartCount;
    private System.Windows.Forms.Label lblCartTotal;
    private System.Windows.Forms.Button btnClearCurrentOrder;
}