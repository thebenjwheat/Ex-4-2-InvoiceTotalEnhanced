using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal  // BEN WHEAT - CIS 123 - APRIL 18TH
{
	public partial class frmInvoiceTotal : Form  // BEN WHEAT - CIS 123 - APRIL 18TH
    {
        public frmInvoiceTotal()  // BEN WHEAT - CIS 123 - APRIL 18TH
        {
			InitializeComponent();       // BEN WHEAT - CIS 123 - APRIL 18TH
		}

        // CREATING THE VARIABLES THAT ARE NEEDED FOR THE CODE:

		int numberOfInvoices = 0; // SETTING IT TO "0" IS AN IDEAL DEFAULT

        decimal totalOfInvoices = 0m; 

		decimal invoiceAverage = 0m; 

        decimal smallestInvoice = Decimal.MaxValue; // BY SETTING THIS TO THE MAX VALUE, YOU CAN LATER FIND THE SMALLEST INVOICE OUT OF ALL THE VALUES GIVEN.

        decimal largestInvoice = 0m; // SETTING IT TO "0m" IS AN IDEAL DEFAULT ("m" for float / decimal)

		private void btnCalculate_Click(object sender, EventArgs e)
		{

			decimal subtotal = Convert.ToDecimal(txtEnterSubtotal.Text); // IF THE SUBTOTAL IS NOT ENTERED AS DECIMAL, IT CONVERTS IT TO A DECIMAL ANYWAY.

			decimal discountPercent = .25m; // CREATING AN EQUATION VARIABLE THAT WILL BE USED BELOW.

			decimal discountAmount = Math.Round(subtotal * discountPercent, 2); // EQUATION TO SOLVE THE DISCOUNT AMOUNT.

			decimal invoiceTotal = subtotal - discountAmount; // The total is the original user-entered number subtracted by the answer of the equation above.

            /*---------------------------------------------------*/

            // Left Side of Form

			txtSubtotal.Text = subtotal.ToString("c"); // SETTING ToString BECAUSE WE ARE ADDING A "$" BEFORE THE NUMBERS.

			txtDiscountPercent.Text = discountPercent.ToString("p1"); // SETTING ToString BECAUSE WE ARE ADDING A "%" AFTER THE NUMBERS.

			txtDiscountAmount.Text = discountAmount.ToString("c"); // SETTING ToString BECAUSE WE ARE ADDING A "$" BEFORE THE NUMBERS.

            txtTotal.Text = invoiceTotal.ToString("c"); // SETTING ToString BECAUSE WE ARE ADDING A "$" BEFORE THE NUMBERS.

            // Right Side of Form

            numberOfInvoices++; // This will make the number of invoices go up IF it repeats.

			totalOfInvoices += invoiceTotal; // This UPDATES the totalInvoices according to the above code.

			invoiceAverage = totalOfInvoices / numberOfInvoices;

            /* UPDATING THE VARIABLE */ smallestInvoice = Math.Min(smallestInvoice, invoiceTotal); // This finds the MINIMUM / SMALLEST among smallestInvoice and invoiceTotal.

             /* UPDATING THE VARIABLE */ largestInvoice = Math.Max(largestInvoice, invoiceTotal); // This finds the MAXIMUM / LARGEST among largestInvoice and invoiceTotal.

            /*---------------------------------------------------*/

			txtNumberOfInvoices.Text = numberOfInvoices.ToString(); // DOES NOT CONTAIN A "$" OR A "%".

			txtTotalOfInvoices.Text = totalOfInvoices.ToString("c"); // SETTING ToString BECAUSE WE ARE ADDING A "$" BEFORE THE NUMBERS.

            txtInvoiceAverage.Text = invoiceAverage.ToString("c"); // SETTING ToString BECAUSE WE ARE ADDING A "$" BEFORE THE NUMBERS.

            txtSmallestInvoice.Text = smallestInvoice.ToString("c"); // SETTING ToString BECAUSE WE ARE ADDING A "$" BEFORE THE NUMBERS.

            txtLargestInvoice.Text = largestInvoice.ToString("c"); // SETTING ToString BECAUSE WE ARE ADDING A "$" BEFORE THE NUMBERS.

            /*----------------------------------------------------*/

            txtEnterSubtotal.Text = ""; // Creating location for USER to enter a SUBTOTAL.

			txtEnterSubtotal.Focus(); // Creates focus on this portion of Code.
		}

		private void btnClearTotals_Click(object sender, System.EventArgs e)
		{
			numberOfInvoices = 0; // RESETS VARIABLE BACK TO ORIGINAL STATE UPON CLICK.

			totalOfInvoices = 0m; // RESETS VARIABLE BACK TO ORIGINAL STATE UPON CLICK.

            invoiceAverage = 0m; // RESETS VARIABLE BACK TO ORIGINAL STATE UPON CLICK.

            smallestInvoice = Decimal.MaxValue; // RESETS VARIABLE BACK TO ORIGINAL STATE UPON CLICK.

            largestInvoice = 0m; // RESETS VARIABLE BACK TO ORIGINAL STATE UPON CLICK.



            txtNumberOfInvoices.Text = ""; // WHEN "Clear Totals" BUTTON IS CLICKED, IT SETS THIS BACK TO EMPTY.

			txtTotalOfInvoices.Text = ""; // WHEN "Clear Totals" BUTTON IS CLICKED, IT SETS THIS BACK TO EMPTY.

            txtInvoiceAverage.Text = ""; // WHEN "Clear Totals" BUTTON IS CLICKED, IT SETS THIS BACK TO EMPTY.

            txtSmallestInvoice.Text = ""; // WHEN "Clear Totals" BUTTON IS CLICKED, IT SETS THIS BACK TO EMPTY.

            txtLargestInvoice.Text = ""; // WHEN "Clear Totals" BUTTON IS CLICKED, IT SETS THIS BACK TO EMPTY.


            txtEnterSubtotal.Focus(); // Creates focus on this portion of Code.
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close(); // Closes the document.
		}

	}
}