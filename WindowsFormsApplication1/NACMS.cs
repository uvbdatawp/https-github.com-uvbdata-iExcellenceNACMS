using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parse;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Initialize the Parse client with your Application ID and .NET Key found on
            // your Parse dashboard
            ParseClient.Initialize("GhZW5TeexOzlSAq76ScwY5hEscD6cx5VsuUwCTqb", "9Wnq24YaQlPJ1OCUXK3hFVDHK9K28jEhFYzbIb87");
         }

      
        // Start first Page
        private void Form1_Load(object sender, EventArgs e)
        {
            readCountryData();
            readHotlineData();
            readHotlineLanguageComboBox();     
            // test    
        }
        
        private async void Form1_Reload(object sender, EventArgs e)
        {
            readHotlineLanguageComboBox();
            
        }


    //
    //
    //
    // Country Stuff
    //
    //
    //
    private async void readCountryData()
        {
            try
            {
                var query = ParseObject.GetQuery("Language");
                IEnumerable<ParseObject> result = new List<ParseObject>();
                result = await query.FindAsync();

                var listItems = new List<MagicList>();
                foreach (var listItemParseObject in result)
                {
                    var listItem = await MagicList.CreateFromParseObject(listItemParseObject);

                    listItems.Add(listItem);
                }
                
                var datatable = new DataTable();
                dataGridView1.DataSource = listItems;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("NAC - Read Operation Country Table has failed." + ex);
            }

        }

        private async void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                string selectedItemID = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                var query = from getlanguage in ParseObject.GetQuery("Language")
                            where getlanguage.Get<string>("languageID") == selectedItemID
                            select getlanguage;
                ParseObject obj = await query.FirstAsync();

              

                var saveObject = new ParseObject("Deleted");
                saveObject["deletedObjectId"] = obj.ObjectId.ToString();                 
                saveObject["fromClass"] = "Language";
                await saveObject.SaveAsync();
               


                await obj.DeleteAsync();
                readCountryData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("NAC - Delete Operation Country Table has failed. " + ex);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            readCountryData();
        }

           

        private async void btnRefreshCountry_Click(object sender, EventArgs e)
        {
            readCountryData();
        }

        private void btnSaveCountry_Click(object sender, EventArgs e)
        {
            saveCountryData();   
        }

        private async void saveCountryData()
        {
            try
            {
                var saveObject = new ParseObject("Language");
                saveObject["languageID"] = countryName.Text;
                saveObject["name"] = countryDescription.Text;
                await saveObject.SaveAsync();
                readCountryData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("NAC - Save Operation Country Table has failed." + ex);
            }
        }


        //
        //
        //
        // Hotline Stuff
        //
        //
        //

        // Select TabControl Hotline Page
        private void TabControl2_Selected(object sender, TabControlEventArgs e)
        {
            readHotlineLanguageComboBox();
        }


        private void tabPage2_Click(object sender, EventArgs e)
        {
            readHotlineData();
            readHotlineLanguageComboBox();
        }

        private async void btnRefreshHotline_Click(object sender, EventArgs e)
        {
            readHotlineData();
        }

        private void btnSaveHotline_Click(object sender, EventArgs e)
        {
            saveHotlineData();
            readHotlineLanguageComboBox();
        }


        private async void saveHotlineData()
        {
            try
            {

                if (languageComboBoxHotline.SelectedItem == null) return;
                string s = languageComboBoxHotline.SelectedItem.ToString();
                if (s != null)
                {
                    var query = from hotlineLanguage in ParseObject.GetQuery("Language")
                                where hotlineLanguage.Get<string>("languageID") == s
                                select hotlineLanguage;

                    ParseObject result = await query.FirstAsync();
                
                    var saveObject = new ParseObject("Hotline");
                    saveObject["email"] = hotlineEmail.Text;
                    saveObject["phone"] = hotlinePhone.Text;
                    saveObject["fax"] = hotlineFax.Text;
                    // To Get the ObjectId from parse
                    //saveObject["languageID"] = result.ObjectId;
                    // to Get the releationship Pointer from the ObjectId
                    saveObject["languageID"] = ParseObject.CreateWithoutData("Language", result.ObjectId);
                    await saveObject.SaveAsync();
                    readHotlineData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NAC - Save Operation Hotline Table has failed." + ex);
            }

        }

        private async void readHotlineData()
        {
            try
            {
                var query = ParseObject.GetQuery("Hotline");
                IEnumerable<ParseObject> result = new List<ParseObject>();
                result = await query.FindAsync();

                var listItems = new List<MagicList.MagicListHotline>();
                foreach (var listItemParseObject in result)
                {
                    var listItem = await MagicList.MagicListHotline.CreateHotlineFromParseObject(listItemParseObject);

                    listItems.Add(listItem);
                }

                var datatable = new DataTable();
                dataGridView2.DataSource = listItems;


            }
            catch (Exception ex)
            {
                MessageBox.Show("NAC - Read Operation Hotline Table has failed." + ex);
            }

        }


        private async void readHotlineLanguageComboBox()
        {
            try
            {
               languageComboBoxHotline.Items.Clear();
                var query = ParseObject.GetQuery("Language");
                IEnumerable<ParseObject> result = new List<ParseObject>();
                result = await query.FindAsync();

                var listItems = new List<MagicList>();
                foreach (var listItemParseObject in result)
                {
                    var listItem = await MagicList.CreateFromParseObject(listItemParseObject);

                    languageComboBoxHotline.Items.Add(listItem.CountryName);
                    
                }
                languageComboBoxHotline.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("NAC - Read Operation Hotline / Language Table for ComboBox has failed." + ex);
            }

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create and Show Modal UserSettingsMenu Form to entry backend username & userpassword
            FormUserSettings fus = new FormUserSettings();
            fus.ShowDialog();
        }

        private void versionInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create and Show Modal App Info Form to get product version and copyrights
            FormAppInfo fai = new FormAppInfo();
            fai.ShowDialog();
        }

        private async void contextMenuStripItemDelete_Opening(object sender, CancelEventArgs e)
        {

            try
            {
                string selectedItemID = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                var query = from getlanguage in ParseObject.GetQuery("Language")
                            where getlanguage.Get<string>("languageID") == selectedItemID
                            select getlanguage;
                ParseObject obj = await query.FirstAsync();

                var saveObject = new ParseObject("Deleted");
                saveObject["deletedObjectId"] = obj.ObjectId.ToString();
                saveObject["fromClass"] = "Language";
                await saveObject.SaveAsync();


                await obj.DeleteAsync();
                readCountryData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("NAC - Delete Operation Country Table has failed. " + ex);
            }
        }

        private void countryName_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
