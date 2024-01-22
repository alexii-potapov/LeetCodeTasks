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
            const string result = "";

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

            var foundCharsIndexes = new Dictionary<char, List<int>>();
            var charsLeftToFound = t.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
            var uniqChars = charsLeftToFound.Keys.ToHashSet();
            var startIndex = -1;
            var endIndex = -1;

            var slidingWindow = new List<int>();

            for (var i = 0; i < s.Length; i++)
            {
                var letter = s[i];

                if (!uniqChars.Contains(letter)) continue;

                var isAlreadyFound = charsLeftToFound.Count == 0 || !charsLeftToFound.ContainsKey(letter);

                if (isAlreadyFound)
                {
                    var firstLetterIndex = foundCharsIndexes[letter].First();

                    var needToCheck = slidingWindow.First() == firstLetterIndex;

                    slidingWindow.Remove(firstLetterIndex);
                    slidingWindow.Add(i);

                    if (needToCheck)
                    {
                        var currentLength = i - slidingWindow.First() + 1;
                        var resultLength = endIndex - startIndex + 1;
                        if (currentLength < resultLength)
                        {
                            startIndex = slidingWindow.First();
                            endIndex = i;
                        }
                    }

                    foundCharsIndexes[letter].RemoveAt(0);
                    foundCharsIndexes[letter].Add(i);
                }
                else if (charsLeftToFound[letter] == 1)
                {
                    if (!foundCharsIndexes.TryAdd(letter, [i]))
                    {
                        foundCharsIndexes[letter].Add(i);
                    }

                    slidingWindow.Add(i);
                    charsLeftToFound.Remove(letter);

                    if (charsLeftToFound.Count == 0)
                    {
                        startIndex = slidingWindow.First();
                        endIndex = i;
                    }
                }
                else
                {
                    charsLeftToFound[letter] -= 1;
                    slidingWindow.Add(i);

                    if (!foundCharsIndexes.TryAdd(letter, [i]))
                    {
                        foundCharsIndexes[letter].Add(i);
                    }
                }
            }

            if (startIndex == -1)
            {
                return result;
            }

            return s.Substring(startIndex, endIndex - startIndex + 1);
        }
    }
}