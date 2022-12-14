using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisCheckPulse
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Net.WebClient client = new System.Net.WebClient();
            client.DownloadData(new Uri("http://192.168.1.187/vischeck/process.aspx"));
        }
    }
}
