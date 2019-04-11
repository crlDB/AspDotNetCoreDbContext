using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetCoreDbContext
{
    public class ToServer1
    {
        public int CmdNbr { get; set; }

    }


    public class ToClient1
    {
        public int CountRec { get; set; }
        public int CtxCtor { get; set; }
    }
}
