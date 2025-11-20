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
        /// Util function for updating text with varying color messages, 
        /// default is black
        /// </summary>
        /// <param name="text"></param>
        /// <param name="col"></param>
        private void UpdateText(string text, Color col = default)
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
            if (String.Equals(type, "licence"))
            {
                licencePlates.Sort();
                lbLicPlates.DataSource = null; // Reset
                lbLicPlates.DataSource = licencePlates;
            }
            else if (String.Equals(type, "tagged"))
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
            string validity = ValidPlate(input, true);
            if (String.Equals(validity, "true"))
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

        private string ValidPlate(string plate, bool unique = false)
        {
            if (!Regex.IsMatch(plate, "^1[A-Z]{3}-[0-9]{3}$"))
            {
                return "License Plate is not valid, correct format: 1ABC-123";
            }
            if (unique && licencePlates.Contains(plate))
            {
                return "License Plate already exists in licence listbox";
            }
            else if (unique && taggedPlates.Contains(plate))
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
                string validity = ValidPlate(input, true);
                if (String.Equals(validity, "true"))
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
            if (String.Equals(validity, "true"))
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

        private int BinarySearch(string type, string input)
        {
            List<string> localList = String.Equals(type, "licence") ? licencePlates : taggedPlates;
            int min = 0;
            int max = localList.Count - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                // If the value is found, notify user, select the value in lb and exit function
                if (localList[mid].CompareTo(input) == 0)
                {
                    return mid;
                }
                else if (licencePlates[mid].CompareTo(input) > 0)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }

        private void btnSearchBin_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.ToUpper();
            string validity = ValidPlate(input);
            if (String.Equals(validity, "true"))
            {
                int result = BinarySearch("licence", input);
                if (result < 0)
                {
                    if (BinarySearch("tagged", input) < 0)
                    {
                        // If it was unable to find the requested value, notify user
                        UpdateText("No licence plates found matching " + input + ".", Color.OrangeRed);
                    }
                    else
                    {
                        UpdateText(input + " found in tagged plates at index " + result);
                        lbTagPlates.SelectedIndex = result;
                    }
                }
                else
                {
                    UpdateText(input + " found in licence plates at index " + result);
                    lbLicPlates.SelectedIndex = result;
                }
            }
            else
            {
                UpdateText(validity, Color.Red);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear all licence " +
                "plates (including tagged)?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                licencePlates.Clear();
                taggedPlates.Clear();
                UpdateLB();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog search = new OpenFileDialog()) 
            {
                search.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                search.RestoreDirectory = true;

                if (search.ShowDialog() == DialogResult.OK)
                {
                    var path = search.FileName;
                    var fileStream = search.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        var content = reader.ReadToEnd();
                        List<string> lic;

                    }
                }
            }
    }
}
