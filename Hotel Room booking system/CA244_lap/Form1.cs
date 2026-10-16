using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace CA244_lap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
           


            string guestName = txtGuestName.Text;
            int age, nights, guests;

            bool isAgeValid = int.TryParse(txtGuestAge.Text, out age);
            bool isNightsValid = int.TryParse(txtNuberOfNights.Text, out nights);
            bool isGuestsValid = int.TryParse(txtNumOfGuests.Text, out guests);
            try
            {
                if (string.IsNullOrWhiteSpace(guestName))
                {
                    MessageBox.Show("Enter guest name!");
                }
                else if (!isAgeValid || age < 18 || age > 90)
                {
                    MessageBox.Show("Age must be between 18 and 90!");
                }
                else if (!isNightsValid || nights < 1 || nights > 30)
                {
                    MessageBox.Show("Nights must be between 1 and 30!");
                }
                else if (!isGuestsValid || guests < 1 || guests > 6)
                {
                    MessageBox.Show("Guests must be between 1 and 6!");
                }
                else if (!radioStanadard.Checked && !radioNormal.Checked && !radioHight.Checked)
                {
                    MessageBox.Show("Select a room type!");
                }
                else
                {
                    string roomType = "";
                    double rate = 0;
                    int maxCapacity = 0;

                    if (radioStanadard.Checked)
                    {
                        roomType = "Standard Room";
                        maxCapacity = 2;
                    }
                    else if (radioNormal.Checked)
                    {
                        roomType = "Normal Room";
                        maxCapacity = 4;
                    }
                    else if (radioHight.Checked)
                    {
                        roomType = "High Room";
                        maxCapacity = 6;
                    }

                    switch (roomType)
                    {
                        case "Standard Room":
                            rate = 50;
                            break;
                        case "Normal Room":
                            rate = 80;
                            break;
                        case "High Room":
                            rate = 130;
                            break;
                    }

                    bool approved = guests <= maxCapacity;

                    if (!approved)
                    {
                        BookinDetails.Items.Add("BOOKING REJECTED");
                        BookinDetails.Items.Add("Guest: " + guestName);
                        BookinDetails.Items.Add("Room: " + roomType);
                        BookinDetails.Items.Add("Maximum Guests: " + maxCapacity);
                        BookinDetails.Items.Add("Guests: " + guests);
                        MessageBox.Show("Too many guests for this room!");
                    }
                    else
                    {
                        double baseCost = rate * nights;
                        double stayDiscount = 0;
                        double seniorDiscount = 0;
                        double breakfastCost = 0;
                        double serviceSurcharge = 0;

                        if (nights >= 10)
                            stayDiscount = baseCost * 0.12;
                        else if (nights >= 5)
                            stayDiscount = baseCost * 0.05;

                        if (age >= 60)
                            seniorDiscount = baseCost * 0.05;

                        if (checkBoxCheck.Checked)
                            breakfastCost = 10 * guests * nights;

                        double subtotal = baseCost - stayDiscount
                                          - seniorDiscount + breakfastCost;

                        if (guests > 4)
                            serviceSurcharge = subtotal * 0.05;

                        double finalCost = subtotal + serviceSurcharge;

                        BookinDetails.Items.Add("----- BOOKING SUMMARY -----");
                        BookinDetails.Items.Add("Guest: " + guestName);
                        BookinDetails.Items.Add("Age: " + age);
                        BookinDetails.Items.Add("Nights: " + nights);
                        BookinDetails.Items.Add("Guests: " + guests);
                        BookinDetails.Items.Add("Room: " + roomType);
                        BookinDetails.Items.Add("Status: Approved");
                        BookinDetails.Items.Add("Rate: $" + rate.ToString("F2"));
                        BookinDetails.Items.Add("Base Cost: $" + baseCost.ToString("F2"));
                        BookinDetails.Items.Add("Stay Discount: $" + stayDiscount.ToString("F2"));
                        BookinDetails.Items.Add("Senior Discount: $" + seniorDiscount.ToString("F2"));
                        BookinDetails.Items.Add("Breakfast: $" + breakfastCost.ToString("F2"));
                        BookinDetails.Items.Add("Service Surcharge: $" + serviceSurcharge.ToString("F2"));
                        BookinDetails.Items.Add("---------------------------");
                        BookinDetails.Items.Add("FINAL COST: $" + finalCost.ToString("F2"));
                    }
                }
            }
catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btbClear_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            txtGuestName.Clear();
            txtGuestAge.Clear();
            txtNuberOfNights.Clear();
            txtNumOfGuests.Clear();

            // Reset room selections
            radioStanadard.Checked = false;
            radioNormal.Checked = false;
            radioHight.Checked = false;

            // Uncheck breakfast
            checkBoxCheck.Checked = false;

            // Clear booking details
            BookinDetails.Items.Clear();

            // Focus on guest name
            txtGuestName.Focus();

        }

        private void btbExit_Click(object sender, EventArgs e)
        {
            // Close the application
            this.Close();
        }
    }
} 
    

