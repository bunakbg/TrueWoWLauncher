using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace TrueWoW_Launcher
{
    class WriteSettingsFile
    {
        //private XmlNode _parrentRootXML;

        private XmlNode _startUpSoundXML;
        private XmlNode _minimizeToTrayXML;
        private XmlNode _wowPathXML;
        private XmlDocument _xmlReader = new XmlDocument();

        public void Load(string _settingsFileLocation = "localsettings.xml")
        {
            try
            {
                _xmlReader.Load(@Directory.GetCurrentDirectory() + "\\" + _settingsFileLocation);
            }
            //file not found
            catch (FileNotFoundException)
            {
                DialogResult answer = MessageBox.Show("ERROR: localsettings.xml not found in: \n\n '" + Directory.GetCurrentDirectory() + "\\' \n\n Re-download TrueWoW Launcher from http://www.truewow.org/ ?", "Error!", MessageBoxButtons.YesNo);
                if (answer == DialogResult.No)
                {
                    Environment.Exit(0);
                }
                else
                {
                    System.Diagnostics.Process.Start("http://www.truewow.org");
                    Environment.Exit(0);
                }

            }
            //dir not found
            catch (DirectoryNotFoundException)
            {
                DialogResult answer = MessageBox.Show("ERROR: localsettings.xml not found in: \n\n'" + Directory.GetCurrentDirectory() + "\\'. \n\n Re-download TrueWoW Launcher from http://www.truewow.org/ ?", "Error!", MessageBoxButtons.YesNo);
                if (answer == DialogResult.No)
                {
                    Environment.Exit(0);
                }
                else
                {
                    System.Diagnostics.Process.Start("http://www.truewow.org");
                    Environment.Exit(0);
                }
            }
            //no access
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("ERROR: no read/write access to localsettings.xml in: \n\n '" + Directory.GetCurrentDirectory() + "\\' \n\n Re-run Launcher with Administrator privileges please.", "Error!");
                Environment.Exit(0);
            }
        }

        public void SetWoWPath(string _wowPath)
        {
            //create node and append
            //XmlElement another = _xmlReader.CreateElement("another");
            //_parrentRootXML.AppendChild(_wowPathXML);
            //_parrentRootXML = _xmlReader.SelectSingleNode("/settings");
            
            _wowPathXML = _xmlReader.SelectSingleNode("/settings/wowPath");
            _wowPathXML.InnerText = _wowPath;

            SaveXML();
        }
        public void SetStartUpSound(bool _startUpSoundBool = false)
        {
            //create node and append
            //XmlElement another = _xmlReader.CreateElement("another");
            //_parrentRootXML.AppendChild(_wowPathXML);
            //_parrentRootXML = _xmlReader.SelectSingleNode("/settings");

            _startUpSoundXML = _xmlReader.SelectSingleNode("/settings/startUpSound");
            if (_startUpSoundBool == true)
            {
                _startUpSoundXML.InnerText = "true";
            }
            else
            {
                _startUpSoundXML.InnerText = "false";
            }

            SaveXML();
        }
        public void MinimizeToTray(bool _minimizeToTray = false)
        {
            //create node and append
            //XmlElement another = _xmlReader.CreateElement("another");
            //_parrentRootXML.AppendChild(_wowPathXML);
            //_parrentRootXML = _xmlReader.SelectSingleNode("/settings");

            _minimizeToTrayXML = _xmlReader.SelectSingleNode("/settings/minimizeToTray");
            if (_minimizeToTray == true)
            {
                _minimizeToTrayXML.InnerText = "true";
            }
            else
            {
                _minimizeToTrayXML.InnerText = "false";
            }

            SaveXML();
        }
        private void SaveXML(string _settingsFileLocation = "localsettings.xml")
        {
            try
            {
                _xmlReader.Save(@Directory.GetCurrentDirectory() + "\\" + _settingsFileLocation);
            }
            //file not found
            catch (FileNotFoundException)
            {
                DialogResult answer = MessageBox.Show("ERROR: localsettings.xml not found in: \n\n '" + Directory.GetCurrentDirectory() + "\\' \n\n Re-download TrueWoW Launcher from http://www.truewow.org/ ?", "Error!", MessageBoxButtons.YesNo);
                if (answer == DialogResult.No)
                {
                    Environment.Exit(0);
                }
                else
                {
                    System.Diagnostics.Process.Start("http://www.truewow.org");
                    Environment.Exit(0);
                }
            }
            //dir not found
            catch (DirectoryNotFoundException)
            {
                DialogResult answer = MessageBox.Show("ERROR: localsettings.xml not found in: \n\n'" + Directory.GetCurrentDirectory() + "\\'. \n\n Re-download TrueWoW Launcher from http://www.truewow.org/ ?", "Error!", MessageBoxButtons.YesNo);
                if (answer == DialogResult.No)
                {
                    Environment.Exit(0);
                }
                else
                {
                    System.Diagnostics.Process.Start("http://www.truewow.org");
                    Environment.Exit(0);
                }
            }
            //no access
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("ERROR: no read/write access to localsettings.xml in: \n\n '" + Directory.GetCurrentDirectory() + "\\' \n\n Re-run Launcher with Administrator privileges please.", "Error!");
                Environment.Exit(0);
            }
        }
    }
}
