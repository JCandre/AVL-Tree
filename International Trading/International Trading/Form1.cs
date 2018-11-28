using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace International_Trading
{
    public partial class Form1 : Form
    {
        
        AVLTree<Country> AVL_tree_countries = new AVLTree<Country>();
        LinkedList<Country> list_countries = new LinkedList<Country>();               //Unordered List
        LinkedList<Country> orderedList_countries = new LinkedList<Country>();        //Ordered List
        Country selectedObject;

        string[] headers = new string[6]; //column headers
        string[] columns;

        public Form1()
        {
            InitializeComponent();

        }// End of Form1()




        /********************************************************************
         *Start if Form1_Load
         *
         * Loads the CSV file, read all countries in the file and split 
         * alld data into seperate columns.
         * Add each coloumn to country class LinkedList.
         ********************************************************************/
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                const int MAX_LINES_FILE = 50000;
                string[] AllLines = new string[MAX_LINES_FILE];

                //reads from bin/DEBUG subdirectory of project directory
                AllLines = File.ReadAllLines("countries.csv");
                foreach (string line in AllLines)
                {
                    if (line.StartsWith("Country")) //found first line - headers
                    {
                        headers = line.Split(',');
                    }
                    else
                    {
                        //split data using commas
                        columns = line.Split(',');

                        //Further split trade partner column with semicolon
                        string[] partners = columns[5].Split(';', '[', ']');

                        //store data in linkedList using country class
                        list_countries.AddLast(new Country(columns[0], 
                            Double.Parse(columns[1]), 
                            Double.Parse(columns[2]), 
                            Double.Parse(columns[3]), 
                            int.Parse(columns[4]), 
                            partners));
                    }
                }

                /**
                  *add Linkedlist to avl tree
                  *display countries names in GUI
                 */
                foreach (Country data in list_countries)
                {
                    AVL_tree_countries.InsertItem(data);
                    country_listbox.Items.Add(data.countryNameGS);
                }

            }
            catch
            {
                MessageBox.Show("Error. Unable to find file, check directory specified");
            }

            //Display tree depth as part of message
            Depth_label.Text = "AVL Tree depth: ( " + AVL_tree_countries.Height().ToString() + " )";

            //Display number of unique countries in tree as part of listBox label
            uniqueC_label.Text = "Countries ( " + AVL_tree_countries.nodeCount().ToString() + " unique)";

        } //End of Form1_load





        /***********************************************************
         * listBox selected index changed to populate other fields
         ***********************************************************/
        private void country_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Add avlTree node data to object for selected country in list
            selectedObject = AVL_tree_countries.selectNode(country_listbox.GetItemText(country_listbox.SelectedItem)).Data;

            //use node data to fill other corrosponding text boxes 
            gdpGrowth_textBox.Text = selectedObject.gdpGrowthGS.ToString();
            inflation_textBox.Text = selectedObject.InflationGS.ToString();
            tradeBalance_textBox.Text = selectedObject.tradeBalanceGS.ToString();
            hdiRanking_textBox.Text = selectedObject.hdiRankingGS.ToString();

            //add trade partners to seperate list box
            tradePartner_listBox.Items.Clear();
            foreach (string tp in selectedObject.tradePartnerGS)
            {
                tradePartner_listBox.Items.Add(tp);
            }

            //Remove empty space from tradePartner listBox
            int count = tradePartner_listBox.Items.Count;
            for (int i = count - 1; i >= 0; i--)
            {
                if (tradePartner_listBox.Items[i].ToString() == "")
                {
                    tradePartner_listBox.Items.RemoveAt(i);
                }
            }

        } //End of country_listbox




        /**********************************************************
         *Edit button controls
         *E
         **********************************************************/
        private void gdpGrowth_editButton_Click(object sender, EventArgs e)
        {
            double temp_gdpGrowth;
            //checks if the characters in the textBox is a double.
            //Outputs the confirmed double to be stored
            Boolean isDouble = Double.TryParse(gdpGrowth_textBox.Text, out temp_gdpGrowth);

            if (isDouble)
            {
                //set original value to temp value
                selectedObject.gdpGrowthGS = temp_gdpGrowth;
                MessageBox.Show("Change was Successful");
            } else {MessageBox.Show("Please enter a valid 'double' value");}

        } //End of dpGrowth_editButton

        private void Inflation_editButton_Click(object sender, EventArgs e)
        {
            double temp_Inflation;
            //checks if the characters in the textBox is a double.
            //Outputs the confirmed double to be stored
            Boolean isDouble = Double.TryParse(inflation_textBox.Text, out temp_Inflation);

            if (isDouble)
            {
                //set original value to temp value
                selectedObject.InflationGS = temp_Inflation;
                MessageBox.Show("Edit was Successful");
            } else { MessageBox.Show("Please enter a valid 'double' value"); }

        } //End of Inflation_editButton

        private void tradeBalance_editButton_Click(object sender, EventArgs e)
        {
            double temp_tradeBalance;
            //checks if the characters in the textBox is a double.
            //Outputs the confirmed double to be stored
            Boolean isDouble = Double.TryParse(tradeBalance_textBox.Text, out temp_tradeBalance);

            if (isDouble)
            {
                //set original value to temp value
                selectedObject.tradeBalanceGS = temp_tradeBalance;
                MessageBox.Show("Edit was Successful");
            } else { MessageBox.Show("Please enter a valid 'double' value"); }

        } //End of tradeBalance_editButton

        private void hdiRanking_editButton_Click(object sender, EventArgs e)
        {
            int temp_hdiRanking;
            //checks if the characters in the textBox is a double.
            //Outputs the confirmed int to be stored
            Boolean isInt = Int32.TryParse(hdiRanking_textBox.Text, out temp_hdiRanking);

            if (isInt)
            {
                //set original value to temp value
                selectedObject.hdiRankingGS = temp_hdiRanking;
                MessageBox.Show("Edit was Successful");
            } else { MessageBox.Show("Please enter a valid 'int' value"); }

        } //End of hdiRanking_editButton

        private void tradePartners_editButton_Click(object sender, EventArgs e)
        {
            LinkedList<string> temp_tradePartners = new LinkedList<string>();
            string setValue;

            //checks if an country has been selected to be edited
            if (tradePartner_listBox.SelectedIndex != -1)
            {
                //store returned string from form
                setValue = setText.ShowDialog("set Trade Partner", "Set");

                //checks if string containts characters ([a-zA-Z0-9)
                if (!string.IsNullOrWhiteSpace(setValue))
                {
                    //set selected country to new country
                    tradePartner_listBox.Items[tradePartner_listBox.SelectedIndex] = setValue;

                    foreach (string tp in tradePartner_listBox.Items)
                    {
                        temp_tradePartners.AddLast(tp);
                    }

                    selectedObject.tradePartnerGS = temp_tradePartners;

                }
                else
                {
                    MessageBox.Show("Value cannot be accepted");
                }


            }
            else
            {
                temp_tradePartners.Clear();
                MessageBox.Show("Select Partner First");
            }

        } //End of tradePartners_editButton




        /**********************************************************
         *Remove button controls
         *Removes country from the avl tree and listBox
         **********************************************************/
        private void Remove_button_Click(object sender, EventArgs e)
        {
            //checks if an country has been selected to be edited
            if (country_listbox.SelectedIndex != -1)
            {
                AVL_tree_countries.RemoveItem(selectedObject);
                list_countries.Remove(selectedObject);
                country_listbox.Items.Clear();
                gdpGrowth_textBox.Clear();
                inflation_textBox.Clear();
                hdiRanking_textBox.Clear();
                tradeBalance_textBox.Clear();
                tradePartner_listBox.Items.Clear();

                foreach (Country data in list_countries)
                {
                    country_listbox.Items.Add(data.countryNameGS);
                }

                //update number of unique countries and tree depth
                Depth_label.Text = "AVL Tree depth: ( " + AVL_tree_countries.Height().ToString() + " )";
                uniqueC_label.Text = "Countries ( " + AVL_tree_countries.nodeCount().ToString() + " unique)";

            }
            else
            {
                MessageBox.Show("Select Country First");
            }

        } //End of Remove_button




        /**********************************************************
         *Order checkBox controls
         *reorders the countries listBox
         **********************************************************/
        private void order_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (order_checkBox.Checked == true)
            {
                country_listbox.Items.Clear();
                orderedList_countries.Clear();
                //use returnAll method to return all nodes in the avlTree but in order
                //adds returned nodes to seperate linkedList
                AVL_tree_countries.returnAll(orderedList_countries);
                foreach (Country data in orderedList_countries)
                {
                    //repopulate countries listBox with names in alphebical order
                    country_listbox.Items.Add(data.countryNameGS);
                }

            }

            if (order_checkBox.Checked == false)
            {
                country_listbox.Items.Clear();
                foreach (Country data in list_countries)
                {
                    country_listbox.Items.Add(data.countryNameGS);
                }
            }
        } //End of order_checkBox




        /*********************************************************************
         *search Button Controls
         *Opens new Form to handle query input.
         *Query used to select country in list, displaying other information.
         *********************************************************************/
        private void Search_Button_Click(object sender, EventArgs e)
        {
            //set country listBox names to alphabetical order, showing other countries with similar starting name.
            order_checkBox.CheckState = CheckState.Indeterminate;

            //store returned string from form
            string searchValue = searchPrompt.ShowDialog("LookUp country", "Search");

            //locates the countries name in the countries listBox
            int set = country_listbox.FindString(searchValue);
            if (set != -1)
            {
                //set selected country in listBox to search value
                country_listbox.SetSelected(set, true);
            }

        } //End of Search_Button

    } //End of public partial class Form1 : Form




    /*********************************************************************
     * Create second form
     *********************************************************************/
    public static class searchPrompt
    {
        public static string ShowDialog(string text, string caption)
        {
            //Form properties
            Form searchPrompt = new Form()
            {
                Width = 350,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label textLabel = new Label() { Left = 125, Top = 20, Text = text };
            TextBox search_textBox = new TextBox() { Left = 50, Top = 45, Width = 250 };
            Button searchButton = new Button() { Text = "Search", Left = 175, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            Button cancelButton = new Button() { Text = "Cancel", Left = 50, Width = 100, Top = 70, DialogResult = DialogResult.OK };

            searchButton.Click += (sender, e) => { searchPrompt.Close(); };
            cancelButton.Click += (sender, e) => { searchPrompt.Close(); };

            //Display control objects on form
            searchPrompt.Controls.Add(search_textBox);
            searchPrompt.Controls.Add(searchButton);
            searchPrompt.Controls.Add(cancelButton);
            searchPrompt.Controls.Add(textLabel);

            //set which button gets triggered when enter is pressed on keyboard
            searchPrompt.AcceptButton = searchButton;

            return searchPrompt.ShowDialog() == DialogResult.OK ? search_textBox.Text : "";
        }

    } //End of public static class searchPrompt

    public static class setText
    {
        public static string ShowDialog(string text, string caption)
        {
            //Form properties
            Form setText = new Form()
            {
                Width = 350,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label textLabel = new Label() { Left = 125, Top = 20, Text = text };
            TextBox search_textBox = new TextBox() { Left = 50, Top = 45, Width = 250 };
            Button setButton = new Button() { Text = "Set", Left = 175, Width = 100, Top = 70, DialogResult = DialogResult.OK };

            setButton.Click += (sender, e) => { setText.Close(); };

            //Display control objects on form
            setText.Controls.Add(search_textBox);
            setText.Controls.Add(setButton);
            setText.Controls.Add(textLabel);

            //set which button gets triggered when enter is pressed on keyboard
            setText.AcceptButton = setButton;

            return setText.ShowDialog() == DialogResult.OK ? search_textBox.Text : "";
        }

    } //End of public static class setText
}
