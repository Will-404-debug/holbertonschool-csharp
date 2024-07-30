#!/usr/bin/env bash

# Define the project directory
PROJECT_DIR="2-new_project"

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

# Build the project
dotnet build > /dev/null

# Run the project and capture the output
RUN_OUTPUT=$(dotnet run)

# Print the output of running the project
echo "$RUN_OUTPUT"

# Navigate back to the original directory
cd ..
