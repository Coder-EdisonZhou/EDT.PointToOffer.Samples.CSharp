using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobey.PointToOffer.StringToInt
{
    public struct ConvertResult
    {
        public ConvertState State;
        public int Number;
    }

    public enum ConvertState
    {
        // 输入不合法
        InValid = 0,
        // 输入合法
        Valid = 1
    }
}
