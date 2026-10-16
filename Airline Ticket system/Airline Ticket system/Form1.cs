using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Ticket_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Variables
                string name = txtName.Text.Trim();
                int age;
                int tickets;
                double baggage;
                double ticketPrice = 0;
                double total;
                double insurance = 0;

                // 2. Validate passenger name
                if (name == "" || int.TryParse(name, out _))
                {
                    MessageBox.Show("Enter a valid passenger name.");
                    txtName.Focus();
                    return;
                }

                // 3. Validate age
                if (!int.TryParse(txtAge.Text, out age) ||
                    age < 1 || age > 120)
                {
                    MessageBox.Show("Enter a valid age (1-120).");
                    txtAge.Focus();
                    return;
                }

                // 4. Validate number of tickets
                if (!int.TryParse(txtTickets.Text, out tickets) ||
                    tickets < 1 || tickets > 10)
                {
                    MessageBox.Show("Enter tickets between 1 and 10.");
                    txtTickets.Focus();
                    return;
                }

                // 5. Validate baggage weight
                if (!double.TryParse(txtBaggageWeights.Text, out baggage) ||
                    baggage < 0)
                {
                    MessageBox.Show("Enter a valid baggage weight.");
                    txtBaggageWeights.Focus();
                    return;
                }

                // 6. Decision structure: Travel class
                if (radioFirstClass.Checked)
                {
                    ticketPrice = 500;
                }
                else if (radioNormalClass.Checked)
                {
                    ticketPrice = 250;
                }
                else if (radioBusinessClass.Checked)
                {
                    ticketPrice = 400;
                }
                else
                {
                    MessageBox.Show("Please select a travel class.");
                    return;
                }

                // 7. Calculate ticket cost
                total = ticketPrice * tickets;

                // 8. Optional travel insurance ($25 per ticket)
                if (checkAddTravel.Checked)
                {
                    insurance = 25 * tickets;
                }

                total = total + insurance;

                // 9. Display results in ListBox
                AirlineBookDetails.Items.Clear();
                AirlineBookDetails.Items.Add("AIRLINE BOOKING DETAILS");
                AirlineBookDetails.Items.Add("----------------------------");
                AirlineBookDetails.Items.Add("Passenger: " + name);
                AirlineBookDetails.Items.Add("Age: " + age);
                AirlineBookDetails.Items.Add("Number of Tickets: " + tickets);
                AirlineBookDetails.Items.Add("Baggage Weight: " + baggage + " kg");

                AirlineBookDetails.Items.Add("Travel Class: " +
                    (radioFirstClass.Checked ? "First Class" :
                    radioNormalClass.Checked ? "Normal Class" :
                    "Business Class"));

                AirlineBookDetails.Items.Add("Ticket Price: $" + ticketPrice);
                AirlineBookDetails.Items.Add("Insurance: $" + insurance);
                AirlineBookDetails.Items.Add("Total Amount: $" + total);

                MessageBox.Show("Booking calculated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
    }

