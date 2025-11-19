using System.Text.RegularExpressions;

namespace Licence_Plate_Management
{
    public partial class Form1 : Form
    {
        List<string> licencePlates = new List<string>();
        List<string> taggedPlates = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Updates the rtb text used for notices
        /// </summary>
        /// <param name="text"></param>
        private void UpdateText(string text)
        {
            tsslOutput.ForeColor = Color.Black;
            tsslOutput.Text = text;
        }

        /// <summary>
        /// Override for UpdateText for color output for error messages
        /// </summary>
        /// <param name="text"></param>
        /// <param name="col"></param>
        private void UpdateText(string text, Color col)
        {
            tsslOutput.ForeColor = col;
            tsslOutput.Text = text;
        }

        /// <summary>
        /// Updates the listboxes
        /// </summary>
        /// <param name="type"></param>
        private void UpdateLB(string type = "both")
        {
            if (type == "licence")
            {
                licencePlates.Sort();
                lbLicPlates.DataSource = null; // Reset
                lbLicPlates.DataSource = licencePlates;
            }
            else if (type == "tagged")
            {
                taggedPlates.Sort();
                lbTagPlates.DataSource = null;
                lbTagPlates.DataSource = taggedPlates;
            }
            else
            {
                // Update both
                licencePlates.Sort();
                lbLicPlates.DataSource = null;
                lbLicPlates.DataSource = licencePlates;
                taggedPlates.Sort();
                lbTagPlates.DataSource = null;
                lbTagPlates.DataSource = taggedPlates;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.ToUpper();
            string validity = ValidPlate(input);
            if (validity == "true")
            {
                licencePlates.Add(input);
                UpdateLB("licence");
                lbLicPlates.SelectedIndex = licencePlates.IndexOf(input);
                UpdateText("Added licence plate: " + input);
            }
            else
            {
                UpdateText(validity, Color.Red);
            }

        }

        private string ValidPlate(string plate)
        {
            if (!Regex.IsMatch(plate, "^1[A-Z]{3}-[0-9]{3}$"))
            {
                return "License Plate is not valid, correct format: 1ABC-123";
            }
            if (licencePlates.Contains(plate))
            {
                return "License Plate already exists in licence listbox";
            }
            else if (taggedPlates.Contains(plate))
            {
                return "License Plate already exists in tagged listbox";
            }
            return "true";
        }

        private void lbLicPlates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbLicPlates.SelectedIndex > -1)
            {
                txtInput.Text = licencePlates[lbLicPlates.SelectedIndex].ToString();
                lbTagPlates.SelectedIndex = -1;
            }
        }

        private void lbTagPlates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTagPlates.SelectedIndex > -1)
            {
                txtInput.Text = taggedPlates[lbTagPlates.SelectedIndex].ToString();
                lbLicPlates.SelectedIndex = -1;
            }
        }

        private void lbLicPlates_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbLicPlates.SelectedIndex > -1)
            {
                string temp = licencePlates[lbLicPlates.SelectedIndex];
                licencePlates.RemoveAt(lbLicPlates.SelectedIndex);
                taggedPlates.Add(temp);
                UpdateLB();
                lbLicPlates.SelectedIndex = licencePlates.IndexOf(temp);
                UpdateText("Moved " + temp + " to tagged.");
            }
        }

        private void lbTagPlates_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbTagPlates.SelectedIndex > -1)
            {
                string temp = taggedPlates[lbTagPlates.SelectedIndex];
                taggedPlates.RemoveAt(lbTagPlates.SelectedIndex);
                licencePlates.Add(temp);
                UpdateLB();
                lbTagPlates.SelectedIndex = taggedPlates.IndexOf(temp);
                UpdateText("Untagged " + temp + ".");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            /* Edit values in the list and update with appropriate error messages. If it's not a valid 
             * number plate, warn the user, else if not already the value user entered then we can 
             * update the list, update the listbox and let the user know what values changed.
            */
            if (lbLicPlates.SelectedIndex > -1)
            {
                string input = txtInput.Text.ToUpper();
                string validity = ValidPlate(input);
                if (validity == "true")
                {
                    string old = licencePlates[lbLicPlates.SelectedIndex].ToUpper();
                    licencePlates[lbLicPlates.SelectedIndex] = input;
                    UpdateLB("licence");
                    lbLicPlates.SelectedIndex = licencePlates.IndexOf(input);
                    UpdateText("Licence plate: " + old + " has been changed to: " + input);
                }
                else
                {
                    UpdateText(validity, Color.Red);
                }
            }
            else
            {
                UpdateText("Unable to edit tagged plates. Please untag them first", Color.Red);
            }

        }

        private void btnSearchLin_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.ToUpper();
            string validity = ValidPlate(input);
            if (validity == "true")
            {
                for (int i = 0; i < licencePlates.Count; i++)
                {
                    if (licencePlates[i] == input)
                    {
                        UpdateText(input + " was found in licence plates at index " + i + ".");
                        lbLicPlates.SelectedIndex = i;
                        return;
                    }
                }

                for (int i = 0; i < taggedPlates.Count; i++)
                {
                    if (licencePlates[i] == input)
                    {
                        UpdateText(input + " was found in tagged plates at index " + i + ".");
                        lbTagPlates.SelectedIndex = i;
                        return;
                    }
                }
            }
            else
            {
                UpdateText(validity, Color.Red);
            }
        }

        private void btnSearchBin_Click(object sender, EventArgs e)
        {
            int min = 0;
            int max = licencePlates.Count - 1;

            string input = txtInput.Text.ToUpper();
            string validity = ValidPlate(input);
            if (validity == "true")
            {

            }
            else
            {
                UpdateText(validity, Color.Red);
            }
            // Binary search requires values to be sorted first
            LinearSort();
            UpdateLB();
            UpdateHourLabel();

            while (min <= max)
            {
                int mid = (min + max) / 2;
                // If the value is found, notify user, select the value in lb and exit function
                if (searchVal == neutrinoArr[mid])
                {
                    UpdateText(searchVal + " was found at hour " + (indexOrder[mid] + 1) + ".");
                    lbNeutrino.SelectedIndex = mid;
                    return;
                }
                else if (neutrinoArr[mid] >= searchVal)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            // If it was unable to find the requested value, notify user
            UpdateText("No values found matching " + searchVal + ".", Color.OrangeRed);
        }
    }
}
