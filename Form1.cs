using System.Text.RegularExpressions;

namespace Licence_Plate_Management
{
    public partial class Form1 : Form
    {
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidPlate(txtInput.Text)) {
                rtbRegistrationInfo.Text = txtInput.Text;
            }else
            {
                UpdateText("License Plate is not valid, correct format: 1ABC-123", Color.Red);
            }

        }

        private bool ValidPlate(string plate)
        {
            return Regex.IsMatch(plate, "^1[a-zA-Z]{3}-[0-9]{3}$");
        }
    }
}
