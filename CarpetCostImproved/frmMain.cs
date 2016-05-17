using System;
using System.Windows.Forms;

public partial class frmMain : Form
{
    private static int mCartCount = 0;
    private static decimal mCartTotal = 0.00M;
    private static decimal mTotalCost = 0.00M;

    public static void Main()
    {
        frmMain main = new frmMain();
        Application.Run(main);
    }

    public frmMain()
    {
        InitializeComponent();

        //mCartCount = 0;
        //mCartTotal = 0.00M;
        //mTotalCost = 0.00M;
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        txtLengthInFeet.Text = "";
        txtWidthInFeet.Text = "";
        txtPricePerSquareYard.Text = "";
        txtSubtotal.Text = "";
        txtTaxAmount.Text = "";
        txtTotalCost.Text = "";
        txtCartCount.Text = "";
        txtCartTotal.Text = "";

        txtLengthInFeet.Focus();
        
        mCartTotal = 0.00M;
        mCartCount = 0;
        mTotalCost = 0;
    }

    private void btnAddToCart_Click(object sender, EventArgs e)
    {
        if (mTotalCost == 0)
        {
            messageBoxOK("Nothing to add."); // More information
            return;
        }

        const string addToCartQuery = "Are you sure you want to add to cart?";

        if (MessageBox.Show(addToCartQuery, Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
        {
            return;
        }

        mCartCount++;
        mCartTotal += mTotalCost;
        // mTotalCost = 0.00M;

        txtCartCount.Text = mCartCount.ToString();
        txtCartTotal.Text = mCartTotal.ToString("C");
    }

    private void btnClearCurrentOrder_Click(object sender, EventArgs e)
    {
        txtLengthInFeet.Text = "";
        txtWidthInFeet.Text = "";
        txtPricePerSquareYard.Text = "";
        txtSubtotal.Text = "";
        txtTaxAmount.Text = "";
        txtTotalCost.Text = "";

        mTotalCost = 0;

        txtLengthInFeet.Focus();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
        // Declarations
        const float taxRate = 0.05F;


        // Decimal too!!!
        float subtotal;
        float lengthInFeet;
        float widthInFeet;

        // Jesus
        float pricePerSquareYard;

        float squareFeet;
        float squareYards;

        // Should be decimal, Kyle wants everything money in decimal
        float taxAmount;

        bool didConvert;

        // Validation
        didConvert = inputValidation();

        if (didConvert == false)
        {
            return;
        }

        // Input

        lengthInFeet = float.Parse(txtLengthInFeet.Text);
        widthInFeet = float.Parse(txtWidthInFeet.Text);
        pricePerSquareYard = float.Parse(txtPricePerSquareYard.Text);

        if (didConvert == false)
        {
            return;
        }
        
        // Calculations

        squareFeet = lengthInFeet * widthInFeet;
        squareYards = squareFeet / 9;

        subtotal = squareYards * pricePerSquareYard;
        taxAmount = subtotal * taxRate;

        mTotalCost = Math.Round((decimal)(subtotal + taxAmount), 2);

        txtSubtotal.Text = subtotal.ToString("C");
        txtTaxAmount.Text = taxAmount.ToString("C");
        txtTotalCost.Text = mTotalCost.ToString("C");
    }

    private bool inputValidation()
    {
        const string lengthInFeetErrorMessage = "Enter a valid numeric greater than zero for the length";
        const string widthInFeetErrorMessage = "Enter a valid numeric greater than zero for the width";
        const string pricePerSquareYardErrorMessage = "Enter a valid numeric greater than zero for the price per square yard";

        float lengthInFeet;
        float widthInFeet;
        float pricePerSquareYard;

        // Validating length in feet
        try
        {
            lengthInFeet = float.Parse(txtLengthInFeet.Text);
        }
        catch
        {
            messageBoxOK(lengthInFeetErrorMessage);
            txtLengthInFeet.Focus();
            return false;
        }
        
        if (lengthInFeet < 0)
        {
            messageBoxOK(widthInFeetErrorMessage);
            txtWidthInFeet.Focus();
            return false;
        }

        // Validating width in feet
        try
        {
            widthInFeet = float.Parse(txtWidthInFeet.Text);
        }
        catch (Exception e)
        {
            messageBoxOK(widthInFeetErrorMessage);
            txtWidthInFeet.Focus();
            return false;
        }

        if (widthInFeet < 0)
        {
            messageBoxOK(widthInFeetErrorMessage);
            txtWidthInFeet.Focus();
            return false;
        }

        // Validating price per square yard
        try
        {
            pricePerSquareYard = float.Parse(txtPricePerSquareYard.Text);
            if (pricePerSquareYard < 0)
            {
                messageBoxOK(pricePerSquareYardErrorMessage);
                txtPricePerSquareYard.Focus();
                return false;
            }
        }
        catch (Exception e)
        {
            messageBoxOK(pricePerSquareYardErrorMessage);
            txtPricePerSquareYard.Focus();
            return false;
        }

        return true;
    }

    private void messageBoxOK(string errorMessage)
    {
        MessageBox.Show(errorMessage, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}