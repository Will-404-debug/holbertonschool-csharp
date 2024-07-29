#!/usr/bin/env bash

# Check if the 'dotnet' command is available
if ! command -v dotnet &> /dev/null
then
	echo "dotnet command could not be found. Please install .NET SDK."
	exit 1
fi

# Create a new folder titled '1-new_project'
mkdir -p 1-new_project

# Navigate into the new folder
cd 1-new_project || { echo "Failed to change directory to '1-new_project'"; exit 1; }

# Initialize a new C# console project
echo "Initializing new C# console project..."
if dotnet new console --output .; then
	echo "The template \"Console Application\" was created successfully."
else
	echo "Project creation failed."
	exit 1
fi

echo

# Run 'dotnet restore' to restore the packages
echo "Processing post-creation actions..."
echo "Running 'dotnet restore' on $(pwd)/1-new_project.csproj..."

if dotnet restore; then
	echo "Restore succeeded."
else
	echo "Restore failed."
	exit 1
fi

# Build the project and capture the output
echo "Building the project..."
BUILD_OUTPUT=$(dotnet build 2>&1)

# Check if the build was successful
if echo "$BUILD_OUTPUT" | grep -q "Build succeeded"; then
	echo "Build succeeded."
	echo "    0 Warning(s)"
	echo "    0 Error(s)"
else
	echo "Build failed."
	echo "$BUILD_OUTPUT"
	exit 1
fi
