# Palindrome Checker (C#)

// Implement a palindrome checker to make the following test cases pass.
 
bool IsPalindrome(string s){ <br>
    return false; //todo<br>
}<br>
<br> 
void Check(string s, bool shouldBePalindrome){<br>
    Console.WriteLine(IsPalindrome(s) == shouldBePalindrome ? "pass" : "FAIL"); <br> 
}<br>
<br>
void Main()<br>
{<br>
    Check("abcba", true);<br>
    Check("abcde", false);<br>
    Check("Mr owl ate my metal worm", true);<br>
    Check("Never Odd Or Even", true);<br>
    Check("Never Even Or Odd", false);<br>
}<br>