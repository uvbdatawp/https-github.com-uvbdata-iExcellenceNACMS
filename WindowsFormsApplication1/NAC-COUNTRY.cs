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
            ParseClient.Initialize("RLJdSH6odw5PGsuwSzzxPHpHHJNnP3yeKJjhME6Y", "hJPNnmjcP5vzFrnLpMoWUCO6Y6HcmSjBK6huyEqD");
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            readData();           
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            var saveObject = new ParseObject("Language");
            saveObject["languageID"] = countryName.Text;
            saveObject["name"] = countryDescription.Text;
            await saveObject.SaveAsync();
            readData();
        }

      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CountryDescription_TextChanged(object sender, EventArgs e)
        {

        }
        private async void readData()
        {
            var query = ParseObject.GetQuery("Language");
            IEnumerable<ParseObject> result = new List<ParseObject>();
            try
            {
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
            catch (Exception ex) { }
            
        }
    }
}
