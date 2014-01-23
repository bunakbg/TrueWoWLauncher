using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace TrueWoW_Launcher
{
    class News
    {
        private XmlNode _newsNode;
        private XmlNode _newsImgXML;
        private XmlNode _newsTittleXML;
        private XmlNode _newsTextXML;
        private XmlNode _newsLinkXML;
        private XmlDocument _xmlReader = new XmlDocument();
        private List<string> _newsImg = new List<string>();
        private List<string> _newsTittle = new List<string>();
        private List<string> _newsText = new List<string>();
        private List<string> _newsLink = new List<string>();
        private int _newsCount;

        public void Read(string _newsFileLocation = "news.xml")
        {
            try
            {
                _xmlReader.Load(@Directory.GetCurrentDirectory() + "\\news\\" + _newsFileLocation);
            }
            //file not found
            catch (FileNotFoundException)
            {
                MessageBox.Show("ERROR: news.xml not found in: \n\n'" + Directory.GetCurrentDirectory() + "\\news\\'. \n\n Re-run Launcher for news update.", "Error!");
            }
            //dir not found
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("ERROR: news.xml not found in: \n\n'" + Directory.GetCurrentDirectory() + "\\news\\'. \n\n Re-run Launcher for news update.", "Error!");
            }
            //no access
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("ERROR: no read/write access to news.xml in: \n\n '" + Directory.GetCurrentDirectory() + "\\news\\' \n\n Re-run Launcher with Administrator privileges, for news update.", "Error!");
            }

            //_serverXML = _xmlReader.SelectSingleNode("/settings/server");
            //_serverAddress = _serverXML.InnerText;

            _newsNode = _xmlReader.SelectSingleNode("/news");
            _newsCount = _newsNode.ChildNodes.Count;
            for (int i = 0; i < _newsCount ;i++)
            {
                _newsImgXML = _xmlReader.SelectSingleNode("/news/news" + i + "/img");
                _newsImg.Add(_newsImgXML.InnerText);
                _newsTittleXML = _xmlReader.SelectSingleNode("/news/news" + i + "/tittle");
                _newsTittle.Add(_newsTittleXML.InnerText);
                _newsTextXML = _xmlReader.SelectSingleNode("/news/news" + i + "/text");
                _newsText.Add(_newsTextXML.InnerText);
                _newsLinkXML = _xmlReader.SelectSingleNode("/news/news" + i + "/link");
                _newsLink.Add(_newsLinkXML.InnerText);
            }
        }

        public string newsImg(int _number = 0) { return _newsImg[_number]; }
        public string newsTittle(int _number = 0) { return _newsTittle[_number]; }
        public string newsText(int _number = 0) { return _newsText[_number]; }
        public string newsLink(int _number = 0) { return _newsLink[_number]; }
        public int newsCount() { return _newsCount; }
    }
}
