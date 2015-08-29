
using Parse;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   
public class MagicList : INotifyPropertyChanged
{
    public MagicList()
    {

    }
    public MagicList(String countryname, String countrydescription)
    {
        this.CountryName = countryname;
        this.CountryDescription = countrydescription;
     }


    
    //private bool _unread;

    private string _countryname;
    public string CountryName
        {
            get { return _countryname; }

            set
            {
                _countryname = value;
                NotifyPropertyChanged("CountryName");
            }
        }
    public string CountryDescription { get; private set; }

    public event PropertyChangedEventHandler PropertyChanged;

    private void NotifyPropertyChanged(String info)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
    }

    public static async Task<MagicList> CreateFromParseObject(ParseObject parseObject)
    {
        return await Task.Run<MagicList>(() =>
        {
            var mlist = new MagicList();

            mlist.CountryName = parseObject.ObjectId;
            if (parseObject.ContainsKey("languageID"))
            {
                mlist.CountryName = (string)parseObject["languageID"];
            }


            if (parseObject.ContainsKey("name"))
            {
                mlist.CountryDescription = (string)parseObject["name"];
            }
            return mlist;
        });
    }
}

    }

