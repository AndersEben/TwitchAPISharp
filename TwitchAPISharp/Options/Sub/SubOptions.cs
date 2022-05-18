using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAPISharp.Options.Sub
{
    public class SubOptions<T>
    {

        public string GetDataString(bool additional = false)
        {
            string result = "";

            if (additional)
                result += ",";

            bool start = true;

            if(typeof(T) == typeof(Subscription))
            {
                foreach (var field in typeof(T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance))
                {
                    if (!start)
                        result += ",";

                    switch(field.Name)
                    {
                        case "type":
                            result += "\'" + field.Name + "\'" + " : " + "\'" + field.GetValue(this) + "\'";
                            break;

                        case "version":
                            result += "\'" + field.Name + "\'" + " : " + "\'" + field.GetValue(this) + "\'";
                            break;

                        case "condition":
                            result += "\'" + field.Name + "\'" + " : " + field.GetValue(this);
                            break;

                        case "transport":
                            result += "\'" + field.Name + "\'" + " : " + field.GetValue(this);
                            break;
                    }

                    if (start)
                        start = !start;
                }
            }
            else
            {
                foreach (var field in typeof(T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance))
                {

                    if (!start)
                        result += ",";

                    if (field.GetValue(this) is string)
                    {
                        result += "\'" + field.Name + "\'" + " : " + "\'" + field.GetValue(this) + "\'";
                    }

                    if (field.GetValue(this) is int)
                    {
                        result += "\'" + field.Name + "\'" + " : " + field.GetValue(this);
                    }

                    if (field.GetValue(this) is bool)
                    {
                        result += "\'" + field.Name + "\'" + " : " + field.GetValue(this).ToString().ToLower();
                    }

                    if (start)
                        start = !start;

                }

            }

            return result;
        }

        public bool CheckProp()
        {
            foreach (var prop in typeof(T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance))
            {
                if (prop.GetValue(this) == null || prop.GetValue(this).ToString() == "")
                    return false;
            }

            return true;
        }
    }
}
