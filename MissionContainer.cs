using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public delegate double Function(double num);
    public class FunctionsContainer
    {
        // create a dictionary to hold the functions.
        private Dictionary<string,Function> funcDict = new Dictionary<string,Function>();
        // Indexer that return a Function with the given name, or creating one.
        public Function this[string name]
        {
            get
            {
                // check if the dictionary contain that mission.
                if (funcDict.ContainsKey(name))
                {
                    //return the Function if it does.
                    return funcDict[name];
                }
                else
                {
                    //create an empty mission o.w
                    funcDict[name] = val => val;
                    return funcDict[name];
                }
            }
            //add the mission to the dictionary.
            set
            {
                funcDict[name] = value;
            }
        }
        //a function that return a list of mission names.
        public List<string> getAllMissions()
        {
            List<string> missions = new List<string>();
            //get the list of keys from the dictionary.
            var keys = funcDict.Keys;
            //for every key, add the key to the list of mission names.
            foreach(var key in keys)
            {
                missions.Add(key);
            }
            //return the list.
            return missions;
        }

    }
}
