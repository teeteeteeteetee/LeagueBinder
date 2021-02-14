using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Drawing;

namespace LeagueBinder
{
    public class Methods
    {
        public PrivateFontCollection LoadFont(int FontLength, byte[] FontData)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            int fontLength = FontLength;
            byte[] fontdata = FontData;
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);
            return pfc;
        }
        public FontFamily Lato_Light()
        {
            return LoadFont(Properties.Resources.Lato_Light.Length, Properties.Resources.Lato_Light).Families[0];
        }
    }

}
