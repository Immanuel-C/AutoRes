namespace AutoRes
{
    public partial class Form1 : Form
    {

        string fortniteGameName = "Fortnite";
        string fortniteSettingsFileName = "\\FortniteGame\\Saved\\Config\\WindowsClient\\GameUserSettings.ini";
        string apexGameName = "Apex Legends";
        string apexSettingsFileName = "";

        string[] ApexSupportedResolutions = new string[] {
                "1680x1050",
                "1600x1024",
                "1440x900",
                "1280x800",
                "1280x768",
                "1440x1080",
                "1280x1024",
                "1280x960"
        };

        string currentGame = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            string desktopName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string username = desktopName.Substring(desktopName.IndexOf('\\') + 1);
            apexSettingsFileName = "C:\\Users\\" + username + "\\Saved Games\\Respawn\\Apex\\local\\videoconfig.txt";
            Console.WriteLine(apexSettingsFileName);

            fortniteSettingsFileName = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + fortniteSettingsFileName;
            Console.WriteLine(fortniteSettingsFileName);

            GameDropDown.Items.Add(fortniteGameName);
            GameDropDown.Items.Add(apexGameName);

            ApexResolutionDropDown.Visible = false;

            CustomWidthLabel.Visible = false;
            CustomWidthTextBox.Visible = false;
            CustomHeightLabel.Visible = false;
            CustomHeightTextBox.Visible = false;

            CustomResolutionCheckBox.Visible = false;

            FPSLimitLabel.Visible = false;
            FPSLimitTextBox.Visible = false;

            ApexResolutionDropDown.DataSource = ApexSupportedResolutions;
        }

        private void ApexElementsVisible(bool visible)
        {
            ApexResolutionDropDown.Visible = visible;
        }

        private void FortniteElementsVisible(bool visible)
        {
            FPSLimitLabel.Visible = visible;
            FPSLimitTextBox.Visible = visible;
        }


        private void CustomElementsVisible(bool visible)
        {
            CustomWidthLabel.Visible = visible;
            CustomWidthTextBox.Visible = visible;
            CustomHeightLabel.Visible = visible;
            CustomHeightTextBox.Visible = visible;
        }

        private void LineChanger(string newText, string fileName, int lineToEdit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[lineToEdit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        private void GameDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GameDropDown.SelectedIndex == 0)
            {
                currentGame = fortniteGameName;
                ApexElementsVisible(false);
                CustomElementsVisible(true);
                FortniteElementsVisible(true);
                CustomResolutionCheckBox.Visible = false;
            }
            else
            {
                currentGame = apexGameName;
                FortniteElementsVisible(false);
                if (!CustomResolutionCheckBox.Checked)
                {
                    CustomElementsVisible(false);
                    ApexElementsVisible(true);
                }
                else
                {
                    CustomElementsVisible(true);
                    ApexElementsVisible(false);
                }

                CustomResolutionCheckBox.Visible = true;
            }
            Console.WriteLine("Current Game Selected: " + currentGame);
        }

        private void FileToReadOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("File Read Only: " + FileToReadOnlyCheckBox.Checked);
        }

        private void ApexResolutionDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void SetSettingsButton_Click(object sender, EventArgs e)
        {

            string width;
            string height;

            if (GameDropDown.SelectedIndex == 0)
            {
                width = CustomWidthTextBox.Text;
                height = CustomHeightTextBox.Text;

                Console.WriteLine("Width: " + width + " Height: " + height);

                File.SetAttributes(fortniteSettingsFileName, File.GetAttributes(fortniteSettingsFileName) & ~FileAttributes.ReadOnly);

                int i = 0;
                foreach (string line in File.ReadAllLines(fortniteSettingsFileName))
                {
                    i++;
                    if (line.Contains("LastUserConfirmedResolutionSizeX="))
                    {
                        LineChanger("LastUserConfirmedResolutionSizeX=" + width, fortniteSettingsFileName, i);
                    }
                    else if (line.Contains("LastUserConfirmedResolutionSizeY="))
                    {
                        LineChanger("LastUserConfirmedResolutionSizeY=" + height, fortniteSettingsFileName, i);
                    }
                    else if (line.Contains("ResolutionSizeX="))
                    {
                        LineChanger("ResolutionSizeX=" + width, fortniteSettingsFileName, i);
                    }
                    else if (line.Contains("ResolutionSizeY="))
                    {
                        LineChanger("ResolutionSizeY=" + height, fortniteSettingsFileName, i);
                    }
                    else if (line.Contains("LastUserConfirmedDesiredScreenWidth="))
                    {
                        LineChanger("LastUserConfirmedDesiredScreenWidth=" + width, fortniteSettingsFileName, i);
                    }
                    else if (line.Contains("LastUserConfirmedDesiredScreenHeight="))
                    {
                        LineChanger("LastUserConfirmedDesiredScreenHeight=" + height, fortniteSettingsFileName, i);
                    }
                    else if (line.Contains("DesiredScreenWidth="))
                    {
                        LineChanger("DesiredScreenWidth=" + width, fortniteSettingsFileName, i);
                    }
                    else if (line.Contains("DesiredScreenHeight="))
                    {
                        LineChanger("DesiredScreenHeight=" + height, fortniteSettingsFileName, i);
                    }
                    else if (line.Contains("FrontendFrameRateLimit="))
                    {
                        LineChanger("FrontendFrameRateLimit=" + FPSLimitTextBox.Text, fortniteSettingsFileName, i);
                    }
                    else if (line.Contains("FrameRateLimit="))
                    {
                        LineChanger("FrameRateLimit=" + FPSLimitTextBox.Text, fortniteSettingsFileName, i);
                    }

                }

                if (FileToReadOnlyCheckBox.Checked)
                    File.SetAttributes(fortniteSettingsFileName, FileAttributes.ReadOnly);
            }
            else if (GameDropDown.SelectedIndex == 1)
            {

                if (!CustomResolutionCheckBox.Checked)
                {
                    width = ApexSupportedResolutions[ApexResolutionDropDown.SelectedIndex].Substring(0, ApexSupportedResolutions[ApexResolutionDropDown.SelectedIndex].IndexOf('x'));
                    height = ApexSupportedResolutions[ApexResolutionDropDown.SelectedIndex].Substring(ApexSupportedResolutions[ApexResolutionDropDown.SelectedIndex].IndexOf('x') + 1);
                }
                else
                {
                    width = CustomWidthTextBox.Text;
                    height = CustomHeightTextBox.Text;

                }

                Console.WriteLine("Width: " + width + " Height: " + height);

                File.SetAttributes(apexSettingsFileName, File.GetAttributes(apexSettingsFileName) & ~FileAttributes.ReadOnly);


                int i = 0;
                foreach (string line in File.ReadAllLines(apexSettingsFileName))
                {
                    i++;
                    if (line.Contains("\"setting.defaultres\""))
                    {
                        LineChanger("\t\"setting.defaultres\"\t\t\"" + width + "\"", apexSettingsFileName, i);
                    }
                    else if (line.Contains("\"setting.defaultresheight\""))
                    {
                        LineChanger("\t\"setting.defaultresheight\"\t\t\"" + height + "\"", apexSettingsFileName, i);
                    }
                }

                if (FileToReadOnlyCheckBox.Checked)
                    File.SetAttributes(apexSettingsFileName, FileAttributes.ReadOnly);
            }
        }

        private void CustomResolutionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomResolutionCheckBox.Checked)
            {
                ApexElementsVisible(false);
                CustomElementsVisible(true);
            }
            else
            {
                ApexElementsVisible(true);
                CustomElementsVisible(false);
            }
        }


    }
}
