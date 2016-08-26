using CoreVerify.Color;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreVerify
{

    //public class NetRube_VerifyCode
    //{

    //    public bool GIF89a = false;
    //    public bool GlobalColorTableFlag = true;
    //    public NetRube_VerifyCode()
    //    {
    //        Image = "";
    //        var GlobalColorTable = new object[256];
    //        GlobalColorTableSize = 7;
    //        GlobalColorTable[2] = new RGB(255, 0, 0);
    //        GlobalColorTable[3] = new RGB(0, 255, 0);
    //        GlobalColorTable[4] = new RGB(0, 0, 255);
    //        GlobalColorTable[5] = new RGB(255, 255, 0);
    //        GlobalColorTable[6] = new RGB(0, 255, 255);
    //        GlobalColorTable[7] = new RGB(255, 0, 255);


    //        var LocalColorTable = new object[0];
    //        LocalColorTableSize = 0;
    //        LocalColorTableFlag = false;


    //        ColorResolution = 7;
    //        Bits = 7;
    //        CodeSize = 7;


    //        BGroundColorIndex = 0;
    //        FGroundColorIndex = 1;
    //        TransparentColorIndex = 0;
    //        UseTransparency = false;


    //        LeftPosition = 0;
    //        TopPosition = 0;
    //        Width_ = 20;
    //        Height_ = 20;


    //        Clear();


    //        PixelAspectRatio = 0;
    //        SortFlag = false;
    //        InterlaceFlag = false;
    //        Seperator = Encoding.UTF8.GetBytes(",");
    //        GraphicControl = (int)'!';
    //        Strings
    //        EndOfImage = Asc(";");


    //        Comment = "";


    //        Reserved = 0;







    //    }

    //    public object GlobalColorTable, LocalColorTable;
    //    public object TransparentColorIndex, UseTransparency;

    //    public object Commit;
    //    private object FGroundColorIndex, BGroundColorIndex;
    //    private object Image;
    //    private object GlobalColorTableSize, LocalColorTableSize, LocalColorTableFlag;
    //    private int Width_, Height_;
    //    private object LeftPosition, TopPosition;
    //    private object Bits, ColorResolution, CodeSize;
    //    private object PixelAspectRatio;
    //    private object SortFlag, InterlaceFlag;
    //    private object Seperator, GraphicControl, EndOfImage;
    //    private object Reserved;
    //    private object Font;
    //    private object[] Letter = new object[19];

    //    public void Clear()
    //    {
    //        Image = String(Width_ * (Height_ + 1) / 2, BitConverter.ToInt32((string)BGroundColorIndex) & ChrB(BGroundColorIndex));
    //    }


    //    private object _backGroundColor;
    //    public object BackGroundColor
    //    {
    //        get
    //        {
    //            return _backGroundColor;
    //        }
    //        set
    //        {
    //            _backGroundColor = value;
    //        }
    //    }
    //    private object _forgroundColor;
    //    public object ForgroundColor
    //    {
    //        get
    //        {
    //            return _forgroundColor;
    //        }
    //        set
    //        {
    //            _backGroundColor = value;
    //        }
    //    }
    //}

}
