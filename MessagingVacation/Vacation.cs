using System;
using System.Collections.Generic;

namespace MessagingVacation
{
    class Vacation
    {
        public Vacation(Bus bus, List<Tourist> tourists)
        {
            Bus = bus ?? throw new ArgumentNullException("bus");
            Tourists = tourists ?? throw new ArgumentNullException("tourists");
        }

        public Bus Bus { get; }
        public List<Tourist> Tourists { get; }

        public void PrepareVacation(Mechanic mechanic, TravelAgent travelAgent, Chef chef)
        {
            mechanic.PrepareVacation(Bus);
            travelAgent.BookHotel(Tourists);
            chef.PrepareMenu(Tourists);
        }
    }
}
