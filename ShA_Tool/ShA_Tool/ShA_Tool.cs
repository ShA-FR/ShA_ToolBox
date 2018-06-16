using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PS4Lib;


namespace ShA_Tool
{
    public partial class ShA_Tool : MetroFramework.Forms.MetroForm

    {
        private readonly PS4API PS4 = new PS4API();
        public ShA_Tool()
        {
            InitializeComponent();
            if (Properties.Settings.Default.saved_ip != string.Empty) 
            {
                IpAdressTxt.Text = Properties.Settings.Default.saved_ip; // Load saved IP.

            }
        }
     

        

        

       

      


        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if (SaveIPCheckbox.Checked == true)
            {
                Properties.Settings.Default.saved_ip = IpAdressTxt.Text; // Upon connection to the PS4 it will save the IP.
                Properties.Settings.Default.Save();
            }

            if (!PS4.ConnectTarget(IpAdressTxt.Text)) //If fails to connect display.
            {
                MetroFramework.MetroMessageBox.Show(this, "Could not connect to target (" + IpAdressTxt.Text + ")"); 

            }
            else // If success.
            {
                PS4.Notify(222, "@ShA_ToolBox - Connected");
                DisconnectBtn.Enabled = true;
                SendNotificationBtn.Enabled = true;
                AttachBtn.Enabled = true;
                NotifMsgTxt.Enabled = true;

                materialLabel2.Text = "Please attach.";

                materialLabel2.ForeColor = Color.Red;

            }
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            PS4.Notify(222, "@ShA_ToolBox - Disconnected");

            PS4.DisconnectTarget(); // Disconnect to the PS4.
        }

        private void SendNotificationBtn_Click(object sender, EventArgs e)
        {
            PS4.Notify(222, NotifMsgTxt.Text); // Will do a notification with your text.
        }

        private void AttachBtn_Click(object sender, EventArgs e)
        {
            if (!PS4.AttachProcess())
            {
                MetroFramework.MetroMessageBox.Show(this, "Could not attach to target (" + IpAdressTxt.Text + ")");
            }
            else
            {
                PS4.Notify(222, "Succesfully attached!");
                UnlimitedPrimaryAmmoBtn.Enabled = true;

                materialLabel2.ForeColor = Color.Green;
                materialLabel2.Text = "Attached!";

            }
        }

        private void UnlimitedPrimaryAmmoBtn_Click(object sender, EventArgs e)
        {
            PS4.SetMemory(0xB5D245C, new byte[] { 0x25, 0x3E, 0x45, 0xC }); // Write to the proper address.

        }
    }
}
