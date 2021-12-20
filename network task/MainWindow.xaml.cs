

using HtmlAgilityPack;
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
            string urlAddress = txt.Text;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;
                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                    string data = readStream.ReadToEnd();
                    var document = new HtmlWeb().Load(urlAddress);
                    var link = document.DocumentNode.Descendants("link");
                    var Pages = document.DocumentNode.Descendants("a")
                                                      .Select(a => a.GetAttributeValue("href", null))
                                                      .Where(n => !String.IsNullOrEmpty(n));
                    string[] pages = Pages.ToArray();
                    n1.Header  = txt.Text ;
                    n2.Header = pages[0];
                    n3.Header = pages[1];
                    n4.Header = pages[2];
                    response.Close();
                    readStream.Close();
                }
            }




        }
    }
    }

