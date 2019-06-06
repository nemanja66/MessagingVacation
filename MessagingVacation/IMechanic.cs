using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingVacation
{
    public interface IMechanic
    {
        void CheckBrakes(Bus bus);
        void CheckEngine(Bus bus);
        void CheckTires(Bus bus);
    }
}
