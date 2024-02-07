using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EB_BillManagement
{
    public interface IBillMethod
    {
        void GenerateBill(int Old_Reading, int New_Reading);
    }
}
