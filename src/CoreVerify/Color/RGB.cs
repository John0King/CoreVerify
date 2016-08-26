using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreVerify.Color
{
    public class RGB
    {
        public RGB(string hexString)
        {
            if (hexString == null)
            {
                throw new ArgumentNullException(nameof(hexString));
            }
            if (hexString[0] != '#')
            {
                throw new NotSupportedException("不支持的颜色格式");
            }
            if (hexString.Length == 4)
            {
                char[] nstr = new char[7];
                nstr[0] = '#';
                for(var i = 1; i < hexString.Length; i++)
                {
                    nstr[2 * i - 1] = hexString[i];
                    nstr[2 * i] = hexString[i];
                }
                hexString = new string(nstr);
            }
            if (hexString.Length == 7)
            {
                var _r = hexString[1].ToString() + hexString[2].ToString();
                var _g = hexString[3].ToString() + hexString[4].ToString();
                var _b = hexString[5].ToString() + hexString[6].ToString();
                R = Convert.ToInt32(_r,16);
                G = Convert.ToInt32(_g, 16);
                B = Convert.ToInt32(_b, 16);
                CheckBound(R);
                CheckBound(G);
                CheckBound(B);
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(hexString), "not a color value");
            }
        }
        public RGB(int R, int G, int B)
        {
            CheckBound(R);
            CheckBound(G);
            CheckBound(B);
            this.R = R;
            this.G = G;
            this.B = B;
        }
        public int R { get; private set; }
        public int G { get; private set; }
        public int B { get; private set; }

        protected static int MinBound = 0;
        protected static int MaxBound = 255;
        protected virtual void CheckBound(int item)
        {
            if (item < MinBound || item > MaxBound)
            {
                throw new ArgumentOutOfRangeException(nameof(item), $"param {nameof(item)} out of range ({MinBound}-{MaxBound})");
            }
        }

        public static RGB Red => new RGB(255, 0, 0);
        public static RGB Green => new RGB(0, 255, 0);
        public static RGB Blue => new RGB(0, 0, 255);
        public static RGB White => new RGB(255, 255, 255);
        public static RGB Black => new RGB(0, 0, 0);

        #region Operators
        public static RGB operator +(RGB left,RGB right)
        {
            var r = left.R + right.R;
            var g = left.G + right.G;
            var b = left.B + right.B;
            TrimBound(ref r);
            TrimBound(ref g);
            TrimBound(ref b);
            return new RGB(r,g,b);
        }
        public static RGB operator -(RGB left, RGB right)
        {
            var r = left.R - right.R;
            var g = left.G - right.G;
            var b = left.B - right.B;
            TrimBound(ref r);
            TrimBound(ref g);
            TrimBound(ref b);
            return new RGB(r, g, b);
        }

        private static  void TrimBound(ref int item)
        {
            if(item < MinBound)
            {
                item = MinBound;
            }
            if (item > MaxBound)
            {
                item = MaxBound;
            }
        }

        #endregion
    }
}
