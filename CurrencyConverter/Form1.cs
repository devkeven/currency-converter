using System.Data;
using System.Runtime.CompilerServices;

namespace CurrencyConverter
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public string[,] values;

		private void Form1_Load(object sender, EventArgs e)
		{
			lblError.Text = "";
			string filePath = @"C:\Users\kmartins\source\repos\CurrencyConverter\CurrencyConverter\Rates.xlsx";
			var dataTable = ExcelFiles.ReadExcelFiles(filePath);

			if (dataTable != null)
			{
				values = new string[dataTable.Rows.Count, 3];

				var i = 0;
				foreach (DataRow row in dataTable.Rows)
				{
					// add values to global array
					values[i, 0] = i.ToString();
					values[i, 1] = row[0].ToString();
					values[i, 2] = row[1].ToString();

					// add items to cb
					cbPairs.Items.Insert(i, row[0].ToString());

					i++;
				}

			}
			else
			{
				Console.WriteLine("There is No Data in Excel Files");
			}
		}

		private void btnConvert_Click(object sender, EventArgs e)
		{
			// clear the error label
			lblError.Text = "";

			decimal value;

			bool valid = decimal.TryParse(txtValue.Text, out value);
			if (valid) 
			{
				decimal rate = decimal.Parse(values[cbPairs.SelectedIndex, 2]);
				decimal result = value * rate;

				txtResult.Text = result.ToString();
			}
			else
			{
				lblError.Text = "Insert a valid value!";
			}
					
		}
	}
}
