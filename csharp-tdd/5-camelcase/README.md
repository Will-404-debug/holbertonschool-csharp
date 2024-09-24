# 5-camelcase

This project implements a method to count the number of words in a CamelCase formatted string.

## Class Library

- **Namespace**: Text
- **Class**: Str
- **Method**: `public static int CamelCase(string s)`
  - **Description**: Counts the number of words in the string `s`, where each word begins with a capital letter except for the first word.

## Test Library

- **Namespace**: Text.Tests
- **Tests**: Validates the `CamelCase` method with various scenarios, including empty strings, single words, and CamelCase strings.

## Instructions

1. Build the solution:
   ```bash
   dotnet build
   ```

2. Run tests:
   ```bash
   dotnet test
   ```
