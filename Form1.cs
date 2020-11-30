using MaterialSkin;
using MaterialSkin.Controls;
using System;
using BloodSugar.Models;
using System.Collections.Generic;

namespace CSCI363Final
{
    public partial class Form1 : MaterialForm
    {
        private User user; 

        public Form1()
        {
            InitializeComponent();
            this.user = User.newFakerInstance();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red400, Primary.Red400, Primary.Red700, Accent.Teal700, TextShade.WHITE); ;
            setBootApplicationData();
        }

        private void setBootApplicationData()
        {
            this.setHomePage();
            this.setAccountPage();
            this.setModePage();
            this.setManualEntryPage();
        }
        private void setHomePage()
        {
            Reading lastReading = user.readingHistory[user.readingHistory.Count - 1];
            HomeCurrentReading.Text = lastReading.reading.ToString();
            HomeCurrentReadingTime.Text = "Taken at " + lastReading.timestamp.ToShortTimeString();
            HomeCurrentReadingDescription.Text = lastReading.getReadingDescription();

            Dosage lastDosage = user.dosageHistory[user.dosageHistory.Count - 1];
            HomePreviousDosageAmount.Text = lastDosage.amount.ToString();
            HomePreviousDosageDescription.Text = lastDosage.getDosageDescription();
            HomePreviousDosageTime.Text = "Administered at " + lastDosage.timeStamp.ToShortTimeString();
        }

        private void setAccountPage()
        {
            AccountName.Text = user.profile.firstName + " " + user.profile.lastName;
            AccountEmail.Text = user.profile.email;
            AccountPhoneNumber.Text = user.profile.phoneNumber;

            List <List<MaterialLabel>> contactSlots = new List<List<MaterialLabel>>();
            contactSlots.Add(new List<MaterialLabel> { Contact1Name, Contact1Phone });
            contactSlots.Add(new List<MaterialLabel> { Contact2Name, Contact2Phone });
            contactSlots.Add(new List<MaterialLabel> { Contact3Name, Contact3Phone });
            int count = 0; 
            while(!(contactSlots.Count < count + 1) && count < user.advisors.Count - 1)
            {
                Contact advisor = user.advisors[count];
                contactSlots[count][0].Text = advisor.firstName + " " + advisor.lastName;
                contactSlots[count][1].Text = advisor.phoneNumber;
                contactSlots[count][0].Visible = true;
                contactSlots[count][1].Visible = true; 

                count++;
            }

            if(count < 3)
            {
                Contact3Name.Visible = false;
                Contact3Phone.Visible = false;
                Contact3Details.Text = "Add";
            }
        }

        private void setModePage()
        {
            ModeCurrentModeHeading.Text = user.operatingState.getCurrentModeDescription();
        }

        private void setManualEntryPage()
        {
            Reading lastReading = user.readingHistory[user.readingHistory.Count - 1];
            ManualEntryCurrentReading.Text = lastReading.reading.ToString();
        }

        private void manualEntryClick(object sender, EventArgs e)
        {
            this.PagesTabControl.SelectedTab = ManualEntryPage;
        }

        private void materialButton8_Click(object sender, EventArgs e)
        {
            this.PagesTabControl.SelectedTab = AccountPage;
        }
    }
}
