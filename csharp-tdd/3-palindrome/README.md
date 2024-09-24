# 3-palindrome

This project implements a method to check if a string is a palindrome in C#.

## Class Library

- **Namespace**: Text
- **Class**: Str
- **Method**: `public static bool IsPalindrome(string s)`
  - **Description**: Determines if a string is a palindrome, ignoring case, spaces, and punctuation. Returns true if it is, otherwise false.

## Test Library

- **Namespace**: Text.Tests
- **Tests**: Validates the IsPalindrome method for various scenarios, including palindromes with spaces, punctuation, and mixed cases, as well as empty strings.

## Instructions

1. Build the solution:
   ```bash
   dotnet build
   ```

2. Run tests:
   ```bash
   dotnet test
   ```
