using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedianFilter
{
    public class MedianFilterSequence
    {
        public static byte[] Filter(byte[] Buffer, int WindowSize)
        {
            List<byte> LocalBuff = Buffer.ToList();
            byte[] ResultBuff = new byte[Buffer.Length];
            byte[] Window = new byte[WindowSize];
            for (int i = 0; i < Buffer.Length; i++)
            {
                int WinSize = (Buffer.Length - (WindowSize + 1));
                if (i > WinSize)   WindowSize = Buffer.Length - (i + 1);
                for (int j = 0; j < WindowSize; j++)   Window[j] = LocalBuff[i + j];
                Window = (from s in Window orderby s select s).ToArray();
                ResultBuff[i] = Window[((WindowSize)/2)];
            }
            return ResultBuff;
        }
    }
    
}
