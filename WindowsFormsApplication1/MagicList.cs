
using Parse;
using System;
using System.CodeDom.Compiler;
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
        public MagicList(String countryname, String countrydescription, String countryobjectid)
        {
            this.CountryName = countryname;
            this.CountryDescription = countrydescription;
            this.CountryObjectId = countryobjectid;
        }



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

        public string CountryObjectId { get; private set; }




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
                mlist.CountryObjectId = parseObject.ObjectId;
                if (parseObject.ContainsKey("languageID"))
                {
                    mlist.CountryName = (string)parseObject["languageID"];
                }
                if (parseObject.ContainsKey("objectId"))
                {
                    mlist.CountryObjectId = (string) parseObject["objectId"];
                }

                if (parseObject.ContainsKey("name"))
                {
                    mlist.CountryDescription = (string)parseObject["name"];
                }
                return mlist;
            });
        }





        public class MagicListHotline
        {

            public MagicListHotline()
            {
            }

            public MagicListHotline(String hotlinelanguage, String hotlinephone, String hotlineemail, String hotlinefax)
            {
                this.HotlineLanguage = hotlinelanguage;
                this.HotlineEmail = hotlineemail;
                this.HotlinePhone = hotlinephone;
                this.HotlineFax = hotlinefax;
            }

            public string HotlineLanguage { get; private set; }
            public string HotlineEmail { get; private set; }
            public string HotlinePhone { get; private set; }
            public string HotlineFax { get; private set; }

            public static async Task<MagicListHotline> CreateHotlineFromParseObject(ParseObject parseObject)
            {
                return await Task.Run<MagicListHotline>(async () =>
                {
                    var mlist = new MagicListHotline();
              

                    if (parseObject.ContainsKey("languageID"))
                    {
                        var rel = parseObject.Get<ParseObject>("languageID");
                        String rel2 = rel.ObjectId;
                        var query = from language in ParseObject.GetQuery("Language")
                            where language.Get<string>("objectId") == rel2
                            select language;


                        ParseObject obj = await query.FirstAsync();
                        mlist.HotlineLanguage = (string)obj["name"];
                        

                    }

                    if (parseObject.ContainsKey("email"))
                    {
                        mlist.HotlineEmail = (string)parseObject["email"];
                    }
                    if (parseObject.ContainsKey("fax"))
                    {
                        mlist.HotlineFax = (string)parseObject["fax"];
                    }
                    if (parseObject.ContainsKey("phone"))
                    {
                        mlist.HotlinePhone = (string)parseObject["phone"];
                    }
                    return mlist;
                });
            }
        }

    }

    public class superstr
    {
    }
}
