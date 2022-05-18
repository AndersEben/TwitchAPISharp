using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchAPISharp.Data.JsonPost;

namespace TwitchAPISharp.Data
{
    public class OptionSet<T>
    {
        public string GetString(bool additional = false)
        {
            string result = "";

            if (!additional)
                result += "?";

            bool start = true;

            foreach (var field in typeof(T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance))
            {

                if (!(field.GetValue(this) is List<string>))
                {
                    if (field.GetValue(this) != null)
                    {

                        if (!start)
                            result += "&";

                        result += field.Name + "=" + field.GetValue(this);

                        if (start)
                            start = !start;
                    }
                }
                else
                {
                    List<string> liste = (List<string>)field.GetValue(this);
                    for (int i = 0; i < liste.Count; i++)
                    {
                        if (!start)
                            result += "&";

                        result += field.Name + "=" + liste[i];

                        if (start)
                            start = !start;
                    }
                }

            }

            return result;
        }

        public string GetDataString(bool additional = false)
        {
            string result = "";

            if (additional)
                result += ",";

            bool start = true;

            if (typeof(T) == typeof(PostCreateEventSubSubscription))
            {
                foreach (var field in typeof(T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance))
                {
                    if (!start)
                        result += ",";

                    switch (field.Name)
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

                    if (field.GetValue(this) is PostCost)
                    {
                        result += "{";

                        bool addstart = true;
                        foreach (var addfield in typeof(PostCost).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance))
                        {

                            if (!addstart)
                                result += ",";

                            if (field.GetValue(this) is string)
                            {
                                result += "\'" + addfield.Name + "\'" + " : " + "\'" + addfield.GetValue(this) + "\'";
                            }

                            if (field.GetValue(this) is int)
                            {
                                result += "\'" + addfield.Name + "\'" + " : " + addfield.GetValue(this);
                            }

                            if (field.GetValue(this) is bool)
                            {
                                result += "\'" + addfield.Name + "\'" + " : " + addfield.GetValue(this).ToString().ToLower();
                            }

                            if (addstart)
                                addstart = !addstart;
                        }

                        result += "}";
                    }

                    if (field.GetValue(this) is List<string>)
                    {

                        result += "\'" + field.Name + "\'" + " : ";
                        result += "[";

                        List<string> liste = (List<string>)field.GetValue(this);
                        for (int i = 0; i < liste.Count; i++)
                        {
                            if (!start)
                                result += ",";

                            result += "\'" + liste[i] + "\'";

                            if (start)
                                start = !start;
                        }
                        result += "]";
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
