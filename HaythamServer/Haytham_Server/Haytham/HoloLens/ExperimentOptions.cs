using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haytham.HoloLens
{
    public static class ExperimentOptions
    {
        public const int ObjectAlign = 1;
        public const int CommandAlign = 2;
        public const int HeadAlign = 3;

        public static Dictionary<int, string> AlignmentDictionary()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(ObjectAlign, "Object");
            dict.Add(CommandAlign, "Command");
            dict.Add(HeadAlign, "Head");

            return dict;
        }

        public const int NearDistance = 2;
        public const int FarDistance = 4;

        public static Dictionary<int, string> DistanceDictionary()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(NearDistance, "Near");
            dict.Add(FarDistance, "Far");

            return dict;
        }

        public const int FourChoices = 4;
        public const int EightChoices = 8;

        public static Dictionary<int, string> ChoicesDictionary()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(FourChoices, "Four");
            dict.Add(EightChoices, "Eight");

            return dict;
        }

    }
}
