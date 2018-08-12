using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FIT5032_Week06B.Util
{
    // C# does not have String enums
    // If you are interested, there is something known as type-safe enum pattern.
    public enum State
    {
        NSW, QLD, SA, TAS, VIC, WA, ACT
    }
    public class RegexLib
    {
        public const string PATTERN_VIC = "^1[A-Za-z]{2}[0-9][A-Za-z]{2}$";
        public const string PATTERN_QLD = "^[0-9]{3}[A-Za-z]{3}$";
        public const string PATTERN_ACT = "^Y{1}[0-9]{2}[0-9]{2}[A-Za-z]$";

        public static Dictionary<State, String> patterns = new Dictionary<State, string>
        {
            { State.VIC, PATTERN_VIC },
            { State.QLD, PATTERN_QLD },
            { State.ACT, PATTERN_ACT }
        };

        public static bool IsValidCarPlate(string patternToValidate, State state)
        {
            patterns.TryGetValue(state, out string pattern);
            if (null != pattern)
                return Regex.IsMatch(patternToValidate, pattern);
            return false;
        }

    }
}