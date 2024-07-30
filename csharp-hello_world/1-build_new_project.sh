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
BUILD_OUTPUT=$(dotnet build)

# Print the build output
echo "$BUILD_OUTPUT"

# Check for build success in the output
if echo "$BUILD_OUTPUT" | grep -q "Build succeeded."; then
	echo "Build succeeded."
else
	echo "Build failed."
fi

# Navigate back to the original directory
cd ..
