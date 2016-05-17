using System;
using System.Windows.Forms;

public partial class frmMain : Form
{
    public static void Main()
    {
        frmMain main = new frmMain();
        Application.Run(main);
    }

    public frmMain()
    {
        InitializeComponent();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {

        const string lengthErrorMessage = "Length in Feet must be numeric and greater than zero.";
        const string widthErrorMessage = "Width in Feet must be numeric and greater than zero.";
        const string priceErrorMessage = "Price Per Square Yard must be numeric and greater than zero.";
        const string taxErrorMessage = "Tax Rate must be numeric and less than 10%";
        bool didConvert;


        decimal taxRate = 0.05M;
        decimal lengthInFeet;
        decimal widthInFeet;
        decimal pricePerSquareYard;
        decimal squareFeet;
        decimal squareYards;
        decimal subtotal;
        decimal taxAmount;
        decimal totalCost;

        didConvert = decimal.TryParse(txtLengthInFeet.Text, out lengthInFeet);
        // Validating Length in Feet
        if (didConvert == false) {
            MessageBox.Show(lengthErrorMessage);
            txtLengthInFeet.Focus();
            return;
        }
        if (lengthInFeet <= 0) {
            MessageBox.Show(lengthErrorMessage);
            txtLengthInFeet.Focus();
            return;
        }

        didConvert = decimal.TryParse(txtWidthInFeet.Text, out widthInFeet);
        // Validating Width in Feet
        if (didConvert == false) {
            MessageBox.Show(widthErrorMessage);
            txtWidthInFeet.Focus();
            return;
        }
        if (widthInFeet <= 0) {
            MessageBox.Show(widthErrorMessage);
            txtWidthInFeet.Focus();
            return;
        }

        didConvert = decimal.TryParse(txtPricePerSquareYard.Text, out pricePerSquareYard);
        // Validating Price Per Square Yard in Feet
        if (didConvert == false) {
            MessageBox.Show(priceErrorMessage);
            txtPricePerSquareYard.Focus();
            return;
        }
        if (pricePerSquareYard <= 0) {
            MessageBox.Show(priceErrorMessage);
            txtPricePerSquareYard.Focus();
            return;
        }

        didConvert = decimal.TryParse(txtTaxRate.Text, out taxRate);
        // Validating Price Per Square Yard in Feet
        if (didConvert == false)
        {
            MessageBox.Show(taxErrorMessage);
            txtTaxRate.Focus();
            return;
        }
        if (taxRate > 10)
        {
            MessageBox.Show(taxErrorMessage);
            txtTaxRate.Focus();
            return;
        }


        // Calculations
        taxRate /= 100;

        squareFeet = lengthInFeet * widthInFeet;
        squareYards = squareFeet / 9;
        subtotal = squareYards * pricePerSquareYard;
        subtotal = Math.Round(subtotal, 2);
        
        taxAmount = subtotal * taxRate;
        taxAmount = Math.Round(taxAmount, 2);

        totalCost = subtotal + taxAmount;
        txtSubtotal.Visible = true;
        txtTaxAmount.Visible = true;
        txtTotalCost.Visible = true;

        txtSubtotal.Text = subtotal.ToString("C");
        txtTaxAmount.Text = taxAmount.ToString("C");
        txtTotalCost.Text = totalCost.ToString("C");
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
        txtSubtotal.Visible = false;
        txtTaxAmount.Visible = false;
        txtTotalCost.Visible = false;

        txtTaxRate .Text = "";
        txtLengthInFeet.Text = "";
        txtWidthInFeet.Text = "";
        txtPricePerSquareYard.Text = "";
        txtLengthInFeet.Focus();
    }


}