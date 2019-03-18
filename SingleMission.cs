using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        //a delegate of certain type of functions.
        private Function func;
        public event EventHandler<double> OnCalculate;  // An Event of when a mission is activated
        public String Name { get;}
        // type property.
        public String Type { get { return "Single"; } }
        //constructor.
        public SingleMission(Function function,string name)
        {
            func = function;
            Name = name;
        }
        // a function that calculates the value with the function received.
        public double Calculate(double value)
        {
            //calculate the value with the function received.
            value = func(value);
            //notify the event handler that the value was calculated.
            OnCalculate?.Invoke(this,value);
            //return the value.
            return value;
        }
    }
}
