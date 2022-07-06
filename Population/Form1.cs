using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Population
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._C__USERS_TONY_DOCUMENTS_BOOKS_C__STUDENT_SAMPLE_PROGRAMS_CHAP11_POPULATIONDB_MDFDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_C__USERS_TONY_DOCUMENTS_BOOKS_C__STUDENT_SAMPLE_PROGRAMS_CHAP11_POPULATIONDB_MDFDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this._C__USERS_TONY_DOCUMENTS_BOOKS_C__STUDENT_SAMPLE_PROGRAMS_CHAP11_POPULATIONDB_MDFDataSet.City);

        }

        private void sortAscend_Click(object sender, EventArgs e)
        {
            // Calling FillByPopAs to sort by population in ascending order
            this.cityTableAdapter.FillByPopAs(this._C__USERS_TONY_DOCUMENTS_BOOKS_C__STUDENT_SAMPLE_PROGRAMS_CHAP11_POPULATIONDB_MDFDataSet.City);
        }

        private void sortDesc_Click(object sender, EventArgs e)
        {
            // Calling FillByPopDes to sort by population in descending order
            this.cityTableAdapter.FillByPopDes(this._C__USERS_TONY_DOCUMENTS_BOOKS_C__STUDENT_SAMPLE_PROGRAMS_CHAP11_POPULATIONDB_MDFDataSet.City);
        }

        private void sortName_Click(object sender, EventArgs e)
        {
            // Calling FillByName to sort by city name in alphabetical order
            this.cityTableAdapter.FillByName(this._C__USERS_TONY_DOCUMENTS_BOOKS_C__STUDENT_SAMPLE_PROGRAMS_CHAP11_POPULATIONDB_MDFDataSet.City);
        }

        private void calculateTotal_Click(object sender, EventArgs e)
        {
            // Initalizing a variable to hold total for population
            double population;

            // Calling the SumPopulation function to calculate total for the population
            population = (double)this.cityTableAdapter.SumPopulation();

            // Displaying total population
            totalPop.Text = population.ToString("n2");

            // Updating the dataset if it was changed
            this.cityTableAdapter.Fill(this._C__USERS_TONY_DOCUMENTS_BOOKS_C__STUDENT_SAMPLE_PROGRAMS_CHAP11_POPULATIONDB_MDFDataSet.City);
        }

        private void calculateAverage_Click(object sender, EventArgs e)
        {
            // Initializing a variable to hold average population
            double averagePopulation;

            // Calling the AveragePopulation method to calculate average population 
            averagePopulation = (double)this.cityTableAdapter.AveragePopulation();

            // Displaying average population for all cities in a box
            averagePop.Text = averagePopulation.ToString("n2");

            // Updating the dataset if it was changed
            this.cityTableAdapter.Fill(this._C__USERS_TONY_DOCUMENTS_BOOKS_C__STUDENT_SAMPLE_PROGRAMS_CHAP11_POPULATIONDB_MDFDataSet.City);
        }

        private void getHigh_Click(object sender, EventArgs e)
        {
            // Initializing a variable to hold highest population
            double high;

            // Calling MaxPopulation method to get highest population
            high = (double)this.cityTableAdapter.MaxPopulation();

            // Displaying the highest population
            highLabel.Text = high.ToString("n2");

            // Updating the dataset if it was changed
            this.cityTableAdapter.Fill(this._C__USERS_TONY_DOCUMENTS_BOOKS_C__STUDENT_SAMPLE_PROGRAMS_CHAP11_POPULATIONDB_MDFDataSet.City);
        }

        private void getLow_Click(object sender, EventArgs e)
        {
            // Initializing a variable to hold lowest population
            double low;

            // Calling MinPopulation method to get lowest population
            low = (double)this.cityTableAdapter.MinPopulation();

            // Displaying lowest population
            lowLabel.Text = low.ToString("n2");

            // Updating the dataset if it was changed
            this.cityTableAdapter.Fill(this._C__USERS_TONY_DOCUMENTS_BOOKS_C__STUDENT_SAMPLE_PROGRAMS_CHAP11_POPULATIONDB_MDFDataSet.City);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            // Closing the form
            this.Close();
        }
    }
}
