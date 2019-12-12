using System;

namespace Calculator
{
    public class Class1
    {
        public int Calc(int[] colors)
        {
            if(colors.Length != 4){
                return -1;
            }
            for(int i = 0; i < colors.Length-1; i++)
            {
                if (colors[i] < 0 || colors[i] > 9)
                {
                    return -1;
                }
            }
            return (colors[0]*10+colors[1])*((int)Math.Pow(10, colors[2]));
        }
    }
}
