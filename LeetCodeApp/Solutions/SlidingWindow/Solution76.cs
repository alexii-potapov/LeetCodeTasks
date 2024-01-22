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

            var window = new Dictionary<char, List<int>>();
            var z = t.GroupBy(c => c);
            var pats = z.ToDictionary(g => g.Key, g => g.Count());
            var charSet = pats.Keys.ToHashSet();
            var startIndex = -1;
            var endIndex = -1;

            var slide = new List<int>();

            for (var i = 0; i < s.Length; i++)
            {
                var letter = s[i];

                if (!charSet.Contains(letter)) continue;

                var isAlreadyFound = pats.Count == 0 || !pats.TryGetValue(letter, out var count) || count == 0;

                if (isAlreadyFound)
                {
                    var firstLetterIndex = window[letter].First();

                    var needToCheck = slide.First() == firstLetterIndex;

                    slide.Remove(firstLetterIndex);
                    slide.Add(i);

                    if (needToCheck)
                    {
                        var currentLength = i - slide.First() + 1;
                        var resultLength = endIndex - startIndex + 1;
                        if (currentLength < resultLength)
                        {
                            startIndex = slide.First();
                            endIndex = i;
                        }
                    }

                    window[letter].RemoveAt(0);
                    window[letter].Add(i);
                }
                else if (pats[letter] == 1)
                {
                    if (!window.TryAdd(letter, [i]))
                    {
                        window[letter].Add(i);
                    }

                    slide.Add(i);
                    pats.Remove(letter);

                    if (pats.Count == 0)
                    {
                        startIndex = slide.First();
                        endIndex = i;
                    }
                }
                else
                {
                    pats[letter] -= 1;
                    slide.Add(i);

                    if (!window.TryAdd(letter, [i]))
                    {
                        window[letter].Add(i);
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
// result = window.Values.MinBy(x => x[0]).Aggregate(result, (current, x) => current + s.Substring(x[0], x[1] - x[0] + 1));