public class Solution {
    public bool IsAnagram(string s, string t) {
        var s1 = s.ToCharArray();
        var t1 = t.ToCharArray();
        Array.Sort(s1);
        Array.Sort(t1);
        return new String(s1) == new String(t1);
}
}