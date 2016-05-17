partial class frmMain
{
    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
            this.txtLengthInFeet = new System.Windows.Forms.TextBox();
            this.txtWidthInFeet = new System.Windows.Forms.TextBox();
            this.txtPricePerSquareYard = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTaxAmount = new System.Windows.Forms.TextBox();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.lblLengthInFeet = new System.Windows.Forms.Label();
            this.lblWidthInFeet = new System.Windows.Forms.Label();
            this.lblPricePerSquareYard = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTaxAmount = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtTaxRate = new System.Windows.Forms.TextBox();
            this.lblTaxRate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLengthInFeet
            // 
            this.txtLengthInFeet.Location = new System.Drawing.Point(172, 13);
            this.txtLengthInFeet.Name = "txtLengthInFeet";
            this.txtLengthInFeet.Size = new System.Drawing.Size(100, 20);
            this.txtLengthInFeet.TabIndex = 0;
            // 
            // txtWidthInFeet
            // 
            this.txtWidthInFeet.Location = new System.Drawing.Point(172, 40);
            this.txtWidthInFeet.Name = "txtWidthInFeet";
            this.txtWidthInFeet.Size = new System.Drawing.Size(100, 20);
            this.txtWidthInFeet.TabIndex = 1;
            // 
            // txtPricePerSquareYard
            // 
            this.txtPricePerSquareYard.Location = new System.Drawing.Point(172, 67);
            this.txtPricePerSquareYard.Name = "txtPricePerSquareYard";
            this.txtPricePerSquareYard.Size = new System.Drawing.Size(100, 20);
            this.txtPricePerSquareYard.TabIndex = 2;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(172, 133);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 3;
            this.txtSubtotal.Visible = false;
            // 
            // txtTaxAmount
            // 
            this.txtTaxAmount.Location = new System.Drawing.Point(172, 160);
            this.txtTaxAmount.Name = "txtTaxAmount";
            this.txtTaxAmount.Size = new System.Drawing.Size(100, 20);
            this.txtTaxAmount.TabIndex = 4;
            this.txtTaxAmount.Visible = false;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(172, 187);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCost.TabIndex = 5;
            this.txtTotalCost.Visible = false;
            // 
            // lblLengthInFeet
            // 
            this.lblLengthInFeet.AutoSize = true;
            this.lblLengthInFeet.Location = new System.Drawing.Point(13, 19);
            this.lblLengthInFeet.Name = "lblLengthInFeet";
            this.lblLengthInFeet.Size = new System.Drawing.Size(75, 13);
            this.lblLengthInFeet.TabIndex = 6;
            this.lblLengthInFeet.Text = "Length in feet:";
            // 
            // lblWidthInFeet
            // 
            this.lblWidthInFeet.AutoSize = true;
            this.lblWidthInFeet.Location = new System.Drawing.Point(13, 46);
            this.lblWidthInFeet.Name = "lblWidthInFeet";
            this.lblWidthInFeet.Size = new System.Drawing.Size(70, 13);
            this.lblWidthInFeet.TabIndex = 7;
            this.lblWidthInFeet.Text = "Width in feet:";
            // 
            // lblPricePerSquareYard
            // 
            this.lblPricePerSquareYard.AutoSize = true;
            this.lblPricePerSquareYard.Location = new System.Drawing.Point(13, 73);
            this.lblPricePerSquareYard.Name = "lblPricePerSquareYard";
            this.lblPricePerSquareYard.Size = new System.Drawing.Size(110, 13);
            this.lblPricePerSquareYard.TabIndex = 8;
            this.lblPricePerSquareYard.Text = "Price per square yard:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(13, 139);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 9;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblTaxAmount
            // 
            this.lblTaxAmount.AutoSize = true;
            this.lblTaxAmount.Location = new System.Drawing.Point(13, 166);
            this.lblTaxAmount.Name = "lblTaxAmount";
            this.lblTaxAmount.Size = new System.Drawing.Size(66, 13);
            this.lblTaxAmount.TabIndex = 10;
            this.lblTaxAmount.Text = "Tax amount:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(13, 193);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(57, 13);
            this.lblTotalCost.TabIndex = 11;
            this.lblTotalCost.Text = "Total cost:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(16, 226);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(197, 226);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(107, 226);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.Location = new System.Drawing.Point(172, 94);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Size = new System.Drawing.Size(100, 20);
            this.txtTaxRate.TabIndex = 15;
            // 
            // lblTaxRate
            // 
            this.lblTaxRate.AutoSize = true;
            this.lblTaxRate.Location = new System.Drawing.Point(16, 100);
            this.lblTaxRate.Name = "lblTaxRate";
            this.lblTaxRate.Size = new System.Drawing.Size(77, 13);
            this.lblTaxRate.TabIndex = 16;
            this.lblTaxRate.Text = "Tax rate (in %):";
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblTaxRate);
            this.Controls.Add(this.txtTaxRate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblTaxAmount);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblPricePerSquareYard);
            this.Controls.Add(this.lblWidthInFeet);
            this.Controls.Add(this.lblLengthInFeet);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.txtTaxAmount);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtPricePerSquareYard);
            this.Controls.Add(this.txtWidthInFeet);
            this.Controls.Add(this.txtLengthInFeet);
            this.Name = "frmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    #endregion

    private System.Windows.Forms.TextBox txtLengthInFeet;
    private System.Windows.Forms.TextBox txtWidthInFeet;
    private System.Windows.Forms.TextBox txtPricePerSquareYard;
    private System.Windows.Forms.TextBox txtSubtotal;
    private System.Windows.Forms.TextBox txtTaxAmount;
    private System.Windows.Forms.TextBox txtTotalCost;
    private System.Windows.Forms.Label lblLengthInFeet;
    private System.Windows.Forms.Label lblWidthInFeet;
    private System.Windows.Forms.Label lblPricePerSquareYard;
    private System.Windows.Forms.Label lblSubtotal;
    private System.Windows.Forms.Label lblTaxAmount;
    private System.Windows.Forms.Label lblTotalCost;
    private System.Windows.Forms.Button btnCalculate;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.TextBox txtTaxRate;
    private System.Windows.Forms.Label lblTaxRate;


}