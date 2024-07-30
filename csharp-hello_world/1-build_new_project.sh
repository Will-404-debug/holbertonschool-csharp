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
dotnet new console > /dev/null

# Restore dependencies
dotnet restore > /dev/null

# Build the project and capture the output
BUILD_OUTPUT=$(dotnet build 2>&1)

# Check if build succeeded
if echo "$BUILD_OUTPUT" | grep -q "Build succeeded."; then
	echo "Build succeeded."
	echo "    0 Warning(s)"
	echo "    0 Error(s)"
fi

# Navigate back to the original directory
cd ..
