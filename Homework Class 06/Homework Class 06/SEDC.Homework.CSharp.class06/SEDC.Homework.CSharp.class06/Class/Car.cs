using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Homework.CSharp.class06.Class
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Racer { get; set; } = new Driver();
        public Car()
        {

        }
        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }
        public int CalculateSpeed(Driver speed)
        {
            return speed.Skill * Speed;
        }
    }
}
