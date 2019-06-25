using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingVacation
{
    public interface IGuestsOrganizable
    {
        IEnumerable<Guest> Guests { get; }
    }
}
