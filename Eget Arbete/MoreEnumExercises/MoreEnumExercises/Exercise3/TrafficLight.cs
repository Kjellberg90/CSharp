using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreEnumExercises.Exercise3
{
    class TrafficLight
    {
        private Status _lastStatus;
        public Status Status { get; private set; }

        public TrafficLight()
        {
            _lastStatus = Status.Yellow;
            Status = Status.Red;
        }

        public void NextStatus()
        {
            if (Status == Status.Red || Status == Status.Green)
            {
                _lastStatus = Status;
                Status = Status.Yellow;
            }
            else if (Status == Status.Yellow)
            {
                if (_lastStatus == Status.Red)
                {
                    Status = Status.Green;
                }
                else if (_lastStatus == Status.Green)
                {
                    Status = Status.Red;
                }
                else
                {
                    Console.WriteLine($"ERROR: unknown last status: {_lastStatus}");
                }
                _lastStatus = Status.Yellow;
            }
            else
            {
                Console.WriteLine($"ERROR: unknown status: {Status}");
            }
        }
    }
}
