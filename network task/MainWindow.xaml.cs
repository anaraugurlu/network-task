

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace network_task
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
       
        
           
        
            private void btn_Click(object sender, RoutedEventArgs e)
        {
            //string urlAddress = txt.Text  ;

            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //if (response.StatusCode == HttpStatusCode.OK)
            //{
            //    Stream receiveStream = response.GetResponseStream();
            //    StreamReader readStream = null;
            //    if (response.CharacterSet == null)
            //    {
            //        readStream = new StreamReader(receiveStream);
            //    }
            //    else
            //    {
            //        readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
            //        string data = readStream.ReadToEnd();
            //        response.Close();
            //        readStream.Close();
            //    }
            //}

 string url = txt.Text;
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);
            myRequest.Method = "GET";
            WebResponse myResponse = myRequest.GetResponse();
            StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
            string result = sr.ReadToEnd();
            sr.Close();
            myResponse.Close();
            if (result.StartsWith("<") && result.EndsWith("a"))
            {


            }
             
               
            }
    }
    }

