namespace LeetCodeApp.Solutions.SlidingWindow
{

    /*
       Given two strings s and t of lengths m and n respectively, return the minimum window 
       substring
        of s such that every character in t (including duplicates) is included in the window. If there is no such substring, return the empty string "".
       
       The testcases will be generated such that the answer is unique.  
    
       // Input: s = "ADOBBECODEBANC", t = "ABC"
       // Output: "BANC"

    Take first letter - A from t = "ABC" -> "BC"
    Search for it in s - ADOBECODEBANC

    found A - 0 - Mark index
     go one by one and remove from pattern
    if pattern is empty remember last index  - count length - store

    search next A, found A - 10

    if empty - compare with max Length - rewrtie if found

    in the end check if found 

     */

    public class Solution76
    {
        public static string MinWindow(string s, string t)
        {
            var result = "";

            if (s == t)
            {
                return s;
            }

            if (s.Length < t.Length)
            {
                return result;
            }


            if (t.Length == 1)
            {
                return s.Contains(t[0], StringComparison.Ordinal) ? t[0].ToString() : result;
            }



            if (s.Contains(t, StringComparison.Ordinal))
            {
                return t;
            }

            var patterns = t.ToHashSet();

            var indexList = new List<int>();
            var letter = ' ';

            var canSkipSecond = true;
            for (int i = 0; i < s.Length; i++)
            {
                letter = s[i];
                //ADOBBECODEBANC contains A

                if (patterns.Contains(letter))
                {

                    // [0]
                    indexList.Add(i);
                    //if (indexList.Count == 1 && patterns.Contains(letter))
                    //{
                    //    canSkipFirst = false;
                    //}
                    // A - removed, "BC" - left
                    patterns.Remove(letter);

                }

                // Use last index of B we found (4 instead of 3)
                else if (indexList.Count == 1 && s[indexList[0]] == letter)
                {
                    indexList.RemoveAt(0);
                    indexList.Add(i);
                }
                else if (indexList.Count == 2 && s[indexList[0]] == letter && canSkipSecond && s[indexList[0]] == s[indexList[1]])
                {
                    indexList.RemoveAt(0);
                    indexList.Add(i);
                }
                else if (indexList.Count == 2 && s[indexList[1]] == letter && canSkipSecond)
                {
                    indexList.RemoveAt(1);
                    indexList.Add(i);
                }
                else if (indexList.Count > 1 && letter == s[indexList[0]])
                {
                    canSkipSecond = false;
                    continue;
                }
                else
                {
                    continue;
                }

                if (patterns.Count != 0)
                {
                    continue;
                }

                // "ABC" found , nothing left ""

                //[0,3,5]
                var startIndex = indexList[0];
                var lastIndex = indexList[^1];
                // 0 - 5 => ADOBEC
                var currentString = s.Substring(startIndex, lastIndex - startIndex + 1);
                if (result.Length == 0 || currentString.Length < result.Length)
                {
                    result = currentString;
                }

                // set initial state
                patterns = t.ToHashSet();
                // Remove second found - "B"
                var secondIndex = indexList[1];
                var secondLetter = s[secondIndex];
                // new pattern set without B "AC"
                patterns.Remove(secondLetter);
                canSkipSecond = true;
                indexList.Clear();
                indexList.Add(secondIndex);

                i = secondIndex;

            }


            return result;
        }
    }
}
