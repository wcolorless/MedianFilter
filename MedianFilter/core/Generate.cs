using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedianFilter
{
    public class GenerateNumbers
    {
        public static byte[] Generate(int size)
        {
            byte[] Buff = new byte[size];
            Random ran = new Random();
            int CurrentNum = 1;
            bool Direction = true;
            int Step = 2;
            for (int i = 0; i < size; i++)
            {
                if(CurrentNum >= 250)
                {
                    Direction = false;
                }
                else if(CurrentNum <= 0)
                {
                    Direction = true;
                }
                if(Direction)
                {
                    Buff[i] = (byte)CurrentNum;
                    CurrentNum += Step;
                }
                else
                {
                    Buff[i] = (byte)CurrentNum;
                    CurrentNum -= Step;
                }
                //
                var Probability = ((byte)ran.Next(1, 250)) > 125 ? true : false;
                if(Probability)
                {
                    while(true)
                    {
                        byte Num = (byte)ran.Next(1, 50);
                        if (Buff[i] + Num <= 255)
                        {
                            Buff[i] += Num;
                            break;
                        }
                        else if (Buff[i] >= 250) break;
                    }
                }
            }
            return Buff;
        }
    }
}
