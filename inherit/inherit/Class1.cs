using System;
using System.Collections.Generic;
using System.Text;

namespace inherit
{
    class Post
    {
        public static int idcount = 0;
       public  int id;    
        public string title, sender;
        public Post() {
            id = 0;
            title = "title";
         
            sender = "hj";

        }
       public  Post(string title, string sender) {
            this.id = getNextID();
            this.title = title;
            this.sender = sender;
        }

        static public  int getNextID() {
            return ++idcount;
        }
        public override string ToString()
        {
            return String.Format("{0}-{1}-(by {2})",this.id,this.title,this.sender);
        }

    }
}
