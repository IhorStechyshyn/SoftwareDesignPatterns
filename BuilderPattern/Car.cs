using System.Collections.Generic;

namespace SoftwareDesignPatterns
{
    public class Car
    {
        private List<object> _options = new List<object>();

        public void Add(string part)
        {
            _options.Add(part);
        }

        public string ListOptions()
        {
            string str = null;
            for (int i = 0; i < _options.Count; i++)
            {
                str += _options[i] + ", ";
            }
            str = str.Remove(str.Length - 2);

            return "Car options: " + str + "\n";
        }
    }
}
