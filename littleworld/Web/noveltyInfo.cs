using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace littleworld.Web
{
    public class noveltyInfo
    {
        private int _novID;

        public int NovID
        {
            get { return _novID; }
            set { _novID = value; }
        }
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        private string _contents;

        public string Contents
        {
            get { return _contents; }
            set { _contents = value; }
        }

       
        private string _time;

        public string Time
        {
            get { return _time; }
            set { _time = value; }
        }
        private int _supportnum;

        public int Supportnum
        {
            get { return _supportnum; }
            set { _supportnum = value; }
        }
        private int _transmitnum;

        public int Transmitnum
        {
            get { return _transmitnum; }
            set { _transmitnum = value; }
        }
        private int _commentnum;

        public int Commentnum
        {
            get { return _commentnum; }
            set { _commentnum = value; }
        }
        private string _headurl;

        public string Headurl
        {
            get { return _headurl; }
            set { _headurl = value; }
        }
        private int _typeID;

        public int TypeID
        {
            get { return _typeID; }
            set { _typeID = value; }
        }
    }
}