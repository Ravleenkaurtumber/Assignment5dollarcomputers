using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5dollarcomputers
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }
        

        private void SelectForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productinfoform.Show();
        }
        //cell-click event handler
        private void ProductDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //assign the values of selected row to the properties of product 

            Program.products.Id = Convert.ToInt32(ProductDataGridView.CurrentRow.Cells[0].Value);
            Program.products.Cost = Convert.ToDecimal(ProductDataGridView.CurrentRow.Cells[1].Value);
            Program.products.Manufacturer = Convert.ToString(ProductDataGridView.CurrentRow.Cells[2].Value);
            Program.products.Model = Convert.ToString(ProductDataGridView.CurrentRow.Cells[3].Value);
            Program.products.Screensize = Convert.ToString(ProductDataGridView.CurrentRow.Cells[4].Value);



            .Text = ProductDataGridView.CurrentRow.Cells[2].Value.ToString()
           + " " + ProductDataGridView.CurrentRow.Cells[3].Value.ToString() + " price at:" + ProductDataGridView.CurrentRow.Cells[1].Value.ToString();

            NextButton.Enabled = true;


        }
    }
