using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EncrytLibrary;

namespace AdminClientDAC
{
    public class Connstring : ConnDB
    {
        static AES eS = new AES();
        public static string conn = eS.AESDecrypt256(ConnectionDBs);
    }
}
