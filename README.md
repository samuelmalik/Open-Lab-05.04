# Open-Lab-05.04
(20 XP) A function that removes special characters from a string.

1. Fork this repository to your GitHub account.
2. Open solution file in Visual Studio.
3. Open file `StringTools.cs`.
4. Implement the method `RemoveSpecialCharacters(string original)` that removes special characters from a string. Only allowed special characters are dashes `-`, underlines `_` and spaces ` `.
5. Run with `CTRL+F5` to test it.
6. If all tests are passed, commit & sync your repository.
7. Send a link to your repository for Lab Master (in #slack) to check it.

## Examples: 
```C#
RemoveSpecialCharacters("The quick brown fox!") ➞ "The quick brown fox"
RemoveSpecialCharacters("%fd76$fd(-)6GvKlO.") ➞ "fd76fd-6GvKlO"
RemoveSpecialCharacters("D0n$c sed 0di0 du1") ➞ "D0nc sed 0di0 du1"
```
