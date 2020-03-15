using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TesteMercadinho.Droid
{
    public class FileAcesssHelp
    {
        public static string  GetLocalFilePath(string filename)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return System.IO.Path.Combine(path, filename);
            //local: /usr/var/appesqueci/data.db
        }
            

        
    }
}