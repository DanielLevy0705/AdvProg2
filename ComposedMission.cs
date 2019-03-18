using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        private List<Function> funcList = new List<Function>();
        public event EventHandler<double> OnCalculate;  // An Event of when a mission is activated
        public String Name { get; }
        //type property.
        public String Type { get { return "Composed"; } }
        //Constructor.
        public ComposedMission(string name)
        {
            Name = name;
        }
        //a function that adds functions to the delegates list.
        public ComposedMission Add(Function func)
        {
            funcList.Add(func);
            return this;
        }
        // a function that calculates the value with the functions received.
        public double Calculate(double value)
        {
            //calculate the value with the functions received.
            foreach (var func in funcList)
            {
                value = func(value);
            }
            //notify the event handler that the value was calculated.
            OnCalculate?.Invoke(this, value);
            //return the value.
            return value;
        }
    }
}
