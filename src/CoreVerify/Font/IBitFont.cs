using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KAdmin.KVerifyCode.Font
{
    public interface IBitFont
    {
        int Width { get; set; }
        int Height { get; set; }
        string[] this[char c] { get; }
    }
}
