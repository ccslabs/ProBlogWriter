using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using POSSIBLE.WordPress.XmlRpcClient;
using POSSIBLE.WordPress.XmlRpcClient.Models;
using System.Collections;

namespace ProBlogWriter.Classes.Wordpress
{
    class Wordpress
    {

        private WordPressXmlRpcClient wpClient = null;
        private const string baseURL = "";
        internal string wpUsername { get; set; }
        internal string wpPassword { get; set; }

        public Wordpress()
        {

        }

        internal ArrayList GetBlogs()
        {
            ArrayList alBlogs = new ArrayList();
            using (wpClient = new WordPressXmlRpcClient(baseURL, wpUsername, wpPassword))
            {
                UserBlog[] blogs = wpClient.GetUsersBlogs(wpUsername, wpPassword);
                foreach (UserBlog blog in blogs)
                {
                    alBlogs.Add(blog.blogName);
                }
            }

            return alBlogs;
        }

    }
}
