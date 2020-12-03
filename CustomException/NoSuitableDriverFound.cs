using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlpsFrameWork.CustomException
{
    class NoSuitableDriverFound :Exception
    {
        public NoSuitableDriverFound(string message) : base(message)
        {
        }
    }
}
