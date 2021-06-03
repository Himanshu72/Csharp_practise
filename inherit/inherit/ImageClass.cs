using System;
using System.Collections.Generic;
using System.Text;

namespace inherit
{
    class ImagePost:Post
    {
        string ImageUrl;
        public ImagePost() {
            this.ImageUrl = "none";
            
        }
        public ImagePost(string title, string imageUrl, string sender) {
            this.ImageUrl = imageUrl;
            this.title = title;
            this.sender = sender;
            this.id = getNextID();
        }

        public override string ToString()
        {
            return string.Format("{0}-{1}-url:{2}-(by{3})", id, title, ImageUrl, sender);
        }
    }
}
