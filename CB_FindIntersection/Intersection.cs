using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CB_FindIntersection
{
    public class Intersection
    {
        public string FindIntersection(string[] strArr)
        {
            var firstList = strArr[0].Split(", ").ToList();
            var secondList = strArr[1].Split(", ").ToList();
            var result = new List<int>();

            foreach (var i in firstList)
            {
                var iToInt = int.Parse(i);
                foreach (var j in secondList)
                {
                    var jToInt = int.Parse(j);
                    if (iToInt == jToInt)
                    {
                        result.Add(iToInt);
                        break;
                    }
                }
            }
            result.Sort();
            return string.Join(", ", result);

        }
    }
}
