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

# Build the project
dotnet build

# Navigate back to the original directory
cd ..

# Print a message indicating the script has completed
echo "C# project setup and build completed successfully."
