using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace littleworld.Model
{
    public  class getmessage
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _contents;

        public string Contents
        {
            get { return _contents; }
            set { _contents = value; }
        }
        private string _headimgUrl;

        public string HeadimgUrl
        {
            get { return _headimgUrl; }
            set { _headimgUrl = value; }
        }
        private DateTime? _publishtime;

        public DateTime? Publishtime
        {
            get { return _publishtime; }
            set { _publishtime = value; }
        }
        private string _ownedName;

        public string OwnedName
        {
            get { return _ownedName; }
            set { _ownedName = value; }
        }
    }
}
