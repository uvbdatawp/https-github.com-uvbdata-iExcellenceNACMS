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
using System.Net.Http;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Initialize the Parse client with your Application ID and .NET Key found on
            // your Parse dashboard
            ParseClient.Initialize("vANM1xZYLV4CYZoY0aRgb1igo05C5K06BVNLWIjP",
                "inmw4qOET9diWVTcnLsk4Gwm3HfPzT9OqcjAAJf1");
        }



        // Start first Page
        private void Form1_Load(object sender, EventArgs e)
        {
            readCountryData();
            readHotlineData();
            readBrandData();
            readHotlineLanguageComboBox();
            readBrandLanguageComboBox();   
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
        private async Task readCountryData()
        {
            try
            {
                var query = ParseObject.GetQuery("Language");
                IEnumerable<ParseObject> result = new List<ParseObject>();
                result = await query.FindAsync();
                var listItems = new List<tbcLanguage>();
                foreach (var listItemParseObject in result)
                {
                    ParseObject parseObject = listItemParseObject;
                    tbcLanguage tbcObject = new tbcLanguage();
                    if (parseObject.ContainsKey("languageID"))
                    {
                        tbcObject.Countrycode = (string) parseObject.Get<string>("languageID");
                    }

                    if (parseObject.ContainsKey("name"))
                    {
                        tbcObject.Description = (string) parseObject.Get<string>("name");
                    }
                    listItems.Add(tbcObject);
                }

                dataGridView1.DataSource = listItems;
                dataGridView1.DisplayedRowCount(true);

            }
            catch (Exception ex)
            {
                MessageBox.Show("NAC - Read Operation Country Table has failed." + ex);
            }

        }

        /*
        private async void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

            return;

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
        */

        private void tabPage1_Click(object sender, EventArgs e)
        {
            readCountryData();
        }



        private void btnRefreshCountry_Click(object sender, EventArgs e)
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

        private void btnRefreshHotline_Click(object sender, EventArgs e)
        {
            readHotlineData();
        }

        private void btnSaveHotline_Click(object sender, EventArgs e)
        {
            saveHotlineData();
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
                    saveObject["languageID"] = ParseObject.CreateWithoutData("Language", result.ObjectId);
                    await saveObject.SaveAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NAC - Save Operation Hotline Table has failed." + ex);
            }
            readHotlineLanguageComboBox();
            readHotlineData();
        }

        private async void readHotlineData()
        {
            try
            {
                var query = ParseObject.GetQuery("Hotline");
                IEnumerable<ParseObject> result = new List<ParseObject>();
                result = await query.FindAsync();
                var listItems = new List<tbcHotline>();
                foreach (var listItemParseObject in result)
                {
                    ParseObject parseObject = listItemParseObject;
                    tbcHotline tbcObject = new tbcHotline();
                    if (parseObject.ContainsKey("phone"))
                    {
                        tbcObject.Phonenumber = (string) parseObject.Get<string>("phone");
                    }

                    if (parseObject.ContainsKey("email"))
                    {
                        tbcObject.EMail = (string) parseObject.Get<string>("email");
                    }
                    listItems.Add(tbcObject);
                }
                dataGridView2.DataSource = listItems;
                dataGridView2.DisplayedRowCount(true);


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

        private void btnRefreshHotline_Click_1(object sender, EventArgs e)
        {
            readHotlineData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        //
        //
        //
        // Brand Stuff
        //
        //
        //

        // Select TabControl Brand Page
        private void TabControl3_Selected(object sender, TabControlEventArgs e)
        {
            readBrandLanguageComboBox();
        }


        private void tabPage3_Click(object sender, EventArgs e)
        {
            readBrandData();
            readBrandLanguageComboBox();
        }

        private void btnRefreshBrand_Click(object sender, EventArgs e)
        {
            readBrandData();
        }

        private void btnSaveBrand_Click(object sender, EventArgs e)
        {
            saveBrandData();
        }


        private async void saveBrandData()
        {
            try
            {

                if (BrandComboBoxHotline.SelectedItem == null) return;
                string s = BrandComboBoxHotline.SelectedItem.ToString();
                if (s != null)
                {
                    var query = from brandLanguage in ParseObject.GetQuery("Language")
                        where brandLanguage.Get<string>("languageID") == s
                        select brandLanguage;
                    ParseObject result = await query.FirstAsync();
                    var saveObject = new ParseObject("Brand");
                    saveObject["name"] = brandname.Text;
                    saveObject["image"] = brandImage.Image;
                    //if (data != null)
                    //{
                    //    ParseFile file = new ParseFile(System.IO.Path.GetFileName(filename), data);
                    //    await file.SaveAsync();
                    //    //then assign the ParseFile into a ParseObject, like the doc says...
                    //}
                    saveObject["sortRank"] = brandSortRank.Text;
                    await saveObject.SaveAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NACMS - Save Operation Brand Table has failed." + ex);
            }
            readBrandLanguageComboBox();
            readBrandData();
        }

        private async void readBrandData()
        {
            try
            {
                var query = ParseObject.GetQuery("Brand");
                IEnumerable<ParseObject> result = new List<ParseObject>();
                result = await query.FindAsync();
                var listItems = new List<tbcBrand>();
                foreach (var listItemParseObject in result)
                {
                    ParseObject parseObject = listItemParseObject;
                    tbcBrand tbcObject = new tbcBrand();
                    if (parseObject.ContainsKey("name"))
                    {
                        tbcObject.Brandname = (string) parseObject.Get<string>("name");
                    }

                    if (parseObject.ContainsKey("image"))
                    {
                        var applicantResumeFile = parseObject.Get<ParseFile>("image");
                        tbcObject.Image = await new HttpClient().GetByteArrayAsync(applicantResumeFile.Url);
                    }
                    if (parseObject.ContainsKey("sortRank"))
                    {
                        tbcObject.Sortrank = (int) parseObject.Get<int>("sortRank");
                    }
                    listItems.Add(tbcObject);
                }
                dataGridView3.DataSource = listItems;
                dataGridView3.DisplayedRowCount(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("NACMS - Read Operation Brand Table has failed." + ex);
            }
        }


        private async void readBrandLanguageComboBox()
        {
            try
            {
                BrandComboBoxHotline.Items.Clear();
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
                MessageBox.Show("NACMS - Read Operation Brand / Language Table for ComboBox has failed." + ex);
            }
        }
    }

    public class tbcLanguage
    {
        public string Countrycode { get; set; }
        public string Description { get; set; }
    }

    public class tbcHotline
    {
        public string Phonenumber { get; set; }
        public string EMail { get; set; }
    }
    public class tbcBrand
    {
        public string Country { get; set; }
        public byte[] Image { get; set; }
        public string Brandname { get; set; }
        public int Sortrank { get; set; }
        public string Description { get; set; }     
    }
}
