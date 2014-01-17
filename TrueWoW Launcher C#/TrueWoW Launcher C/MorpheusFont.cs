using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
namespace TrueWoW_Launcher
{
    class MorpheusFont
    {
        //MORPHEUS.TTF
        private PrivateFontCollection _pfc = new PrivateFontCollection();
        private FontFamily _fontFamily;
        public void Load(string _fontName = "MORPHEUS.TTF")
        {
            try
            {
                _pfc.AddFontFile(@Directory.GetCurrentDirectory() + "\\fonts\\" + _fontName);
                _fontFamily = _pfc.Families[0];
            }
            catch (FileNotFoundException)
            {
                
            }
            //label1.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
        }

        public FontFamily fontFamily() { return _fontFamily; }
        public PrivateFontCollection font() { return _pfc; }
    }
}
