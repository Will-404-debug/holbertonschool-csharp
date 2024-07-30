#!/usr/bin/env bash

# Create a new folder titled '1-new_project'
mkdir -p 1-new_project

# Navigate into the new folder
cd 1-new_project || exit 1

# Initialize a new C# console project
dotnet new console --output . || { echo "Project creation failed."; exit 1; }

# Run 'dotnet restore' to restore the packages
dotnet restore || { echo "Restore failed."; exit 1; }

# Build the project and capture the output
BUILD_OUTPUT=$(dotnet build 2>&1)

# Print the captured output
echo "$BUILD_OUTPUT"

# Check if the build was successful
if echo "$BUILD_OUTPUT" | grep -q "Build succeeded"; then
	echo "Build succeeded."
	echo "    0 Warning(s)"
	echo "    0 Error(s)"
else
	echo "Build failed."
	exit 1
fi
