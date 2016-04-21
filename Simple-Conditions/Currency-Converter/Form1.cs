using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Converter
{
    public partial class FormConverter : Form
    {
        public FormConverter()
        {
            InitializeComponent();
        }
        //---------------------------------------------------------------------------

        /*
            Method:  FormConverter_Load(object sender, EventArgs e);

            Sets initial value of the output currency.
        */
        private void FormConverter_Load(object sender, EventArgs e)
        {
            this.comboBoxCurrency.SelectedItem = "EUR";
        }
        //---------------------------------------------------------------------------

        /*
            Method: numericUpDownAmount_ValueChanged(object sender, EventArgs e)
         
            It determines the action (called function) when the input currency
            amount is changed. 
            
            In our case the action is the value of the amount of output currency,
            given the selected output currency
        */
        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            ConvertCurrency();
        }
        //---------------------------------------------------------------------------

        /*
            Method: comboBoxCurrency_SelectedIndexChanged(object sender, EventArgs e)

            It determines the action when the output currency item is changed.

        */
        private void comboBoxCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConvertCurrency();
        }
        //---------------------------------------------------------------------------

        /*
            Method: ConvertCurrency()

            Action function called by the above two event handlers.
        */
        private void ConvertCurrency()
        {
            Dictionary<string, decimal> ConversionTable = new Dictionary<string, decimal>();
            InitializeConvertionTable(ConversionTable);

            // read the value stored in the box: numericUpDownAmount
            var InputAmount = this.numericUpDownAmount.Value;

            // read the selected output currency from box: 
            string OutputCurrency = this.comboBoxCurrency.SelectedItem.ToString();

            // convert 
            var OutputAmount = InputAmount / ConversionTable[OutputCurrency];

            // write result in: labelResult
            this.labelResult.Text = InputAmount + " лв. = " +
                                    Math.Round(OutputAmount, 2) + " " + 
                                    this.comboBoxCurrency.SelectedItem;
        }
        //---------------------------------------------------------------------------

        /*
            Method:  InitializeConvertionTable(Dictionary<string, decimal> table);

        */
        static private void InitializeConvertionTable(Dictionary<string, decimal> table)
        {
            table.Add("EUR", 1.95583m);
            table.Add("USD", 1.80810m);
            table.Add("GBP", 2.54990m);
        }
    }
}
