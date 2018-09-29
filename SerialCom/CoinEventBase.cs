using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SerialCom
{
    public delegate void ReceiveCointEventHandler(object sender, CoinEventArgs e);
    public class CoinEventBase
    {
    }
    //private Thread workerThread;
}
