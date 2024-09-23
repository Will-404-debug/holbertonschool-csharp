# 1-divide

This project implements a matrix division operation in C#.

## Class Library

- **Namespace**: MyMath
- **Class**: Matrix
- **Method**: `public static int[,] Divide(int[,] matrix, int num)`
  - **Description**: Returns a new matrix containing the results of dividing each element of the input matrix by `num`. If `num` is 0 or if the input matrix is null, appropriate error handling is provided.

## Test Library

- **Namespace**: MyMath.Tests
- **Tests**: Validates the Divide method for various scenarios.

## Instructions

1. Build the solution:
   ```bash
   dotnet build
   ```

2. Run tests:
   ```bash
   dotnet test
   ```
