using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Играет");
        }
        public void Record()
        {
            Console.WriteLine("Записывает");
        }
        public void Pause()
        {
            Console.WriteLine("Пауза");
        }
        public void Stop()
        {
            Console.WriteLine("Закончил");
        }
    }
}
