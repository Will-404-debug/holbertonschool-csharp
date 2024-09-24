# 4-unique

This project implements a method to find the index of the first non-repeating character in a string.

## Class Library

- **Namespace**: Text
- **Class**: Str
- **Method**: `public static int UniqueChar(string s)`
  - **Description**: Finds the index of the first non-repeating character in the string `s`. If no unique character exists, it returns `-1`.

## Test Library

- **Namespace**: Text.Tests
- **Tests**: Validates the `UniqueChar` method with various scenarios, including strings with no unique characters, empty strings, and strings where the unique character is at different positions.

## Instructions

1. Build the solution:
   ```bash
   dotnet build
   ```

2. Run tests:
   ```bash
   dotnet test
   ```
