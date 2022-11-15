using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4__Abstract_Classes_and_Interfaces_.Task_3
{
    class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("The music is playinig...");
        }
        //------------------------------------------------------------

        public void Record()
        {
            Console.WriteLine("The song is recording...");
        }
        //------------------------------------------------------------

        void IPlayable.Pause()
        {
            Console.WriteLine("The musing on pause! (IPlayable.Pause();)");
        }
        //------------------------------------------------------------

        void IPlayable.Stop()
        {
            Console.WriteLine("The music is stoped! (IPlayable.Stop();)");
        }
        //------------------------------------------------------------

        void IRecordable.Pause()
        {
            Console.WriteLine("The musing on pause! (IRecordable.Pause();)");
        }
        //------------------------------------------------------------

        void IRecordable.Stop()
        {
            Console.WriteLine("The music is stoped! (IRecordable.Stop();)");
        }
        //------------------------------------------------------------
    }
}
