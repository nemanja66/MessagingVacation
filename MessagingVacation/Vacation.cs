using System;

namespace MessagingVacation
{
    class Vacation
    {
        public Vacation(Bus bus)
        {
            Bus = bus ?? throw new ArgumentNullException("bus");
        }

        public Bus Bus { get; }

        public void PrepareVacation(IMechanic mechanic)
        {
            mechanic.CheckBrakes(Bus);
            mechanic.CheckEngine(Bus);
            mechanic.CheckTires(Bus);
        }
    }
}
