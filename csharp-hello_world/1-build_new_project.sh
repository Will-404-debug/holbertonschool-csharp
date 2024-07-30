#!/usr/bin/env bash

# Define the project directory
PROJECT_DIR="1-new_project"

# Create the project directory if it does not exist
if [ ! -d "$PROJECT_DIR" ]; then
	mkdir "$PROJECT_DIR"
fi

# Navigate into the project directory
cd "$PROJECT_DIR" || exit

# Initialize a new C# console project
dotnet new console

# Restore dependencies
dotnet restore

# Build the project and capture the output
BUILD_OUTPUT=$(dotnet build 2>&1)

# Ensure output matches expected format
if echo "$BUILD_OUTPUT" | grep -q "Build succeeded."; then
	echo "Build succeeded."
	# Check for warnings and errors in the output
	WARNINGS=$(echo "$BUILD_OUTPUT" | grep -oP '\d+ Warning\(s\)')
	ERRORS=$(echo "$BUILD_OUTPUT" | grep -oP '\d+ Error\(s\)')
	echo "    ${WARNINGS:-0 Warning(s)}"
	echo "    ${ERRORS:-0 Error(s)}"
else
	echo "Build failed or format mismatch."
fi

# Navigate back to the original directory
cd ..
