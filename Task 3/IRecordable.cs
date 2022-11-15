using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4__Abstract_Classes_and_Interfaces_.Task_3
{
    interface IRecordable : IPlayable
    {
        void Record();
        void Pause();
        void Stop();
    }
}
