using System;
using System.Collections.Generic;
using System.Text;

namespace inherit
{
    class VideoPost:Post
    {
        string videoURL;
        int length;
        public VideoPost() {
            this.videoURL = "none";
            this.length = 0;
        }
        public VideoPost(string title,string url,int length,string sender) {
            this.title = title;
            this.videoURL = url;
            this.length = length;
            this.sender = sender;
            this.id = getNextID();
        }
        public override string ToString()
        {
            return string.Format("{0}-{1}-url:{2}-len:{3}-by({4})", id,title, videoURL, length, sender);
        }
    }
}
