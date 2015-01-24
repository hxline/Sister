﻿namespace ClientChat.Models
{
    class Members
    {
        private string _name;
        private string _id;

        public Members(string name, string id)
        {
            _name = name;
            _id = id;
        }

        public override string ToString()
        { return _name; }

        public string id
        {
            get { return _id; }
        }

        public string name
        {
            get { return _name; }
        }

    }
}

