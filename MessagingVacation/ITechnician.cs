using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingVacation
{
    public interface ITechnician
    {
        void SetupSpeakers(Equipment equipment);
        void SetupMixer(Equipment equipment);
        void SetupLighting(Equipment equipment);
    }
}
