# Palindrome Checker (C#)

// Implement a palindrome checker to make the following test cases pass.
 
bool IsPalindrome(string s){
    return false; //todo
}
 
void Check(string s, bool shouldBePalindrome){
    Console.WriteLine(IsPalindrome(s) == shouldBePalindrome ? "pass" : "FAIL");  
}
 
void Main()
{
    Check("abcba", true);
    Check("abcde", false);
    Check("Mr owl ate my metal worm", true);
    Check("Never Odd Or Even", true);
    Check("Never Even Or Odd", false);
}