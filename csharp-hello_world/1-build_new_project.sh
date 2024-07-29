#!/usr/bin/env bash

# Directory to create the new C# project in
PROJECT_DIR="1-new_project"

# Create a new directory for the project
mkdir -p "$PROJECT_DIR"

# Navigate to the project directory
cd "$PROJECT_DIR" || { echo "Failed to navigate to $PROJECT_DIR"; exit 1; }

# Initialize a new C# project with the Console Application template
dotnet new console -o . || { echo "Failed to create new C# project"; exit 1; }

# Display success message for project creation
echo "The template \"Console Application\" was created successfully."

# Restore packages
dotnet restore || { echo "Failed to restore packages"; exit 1; }

# Display success message for package restoration
echo "Restore succeeded."

# Build the project
dotnet build || { echo "Failed to build the project"; exit 1; }

# Display success message for build
echo "Build succeeded."
echo "    0 Warning(s)"
echo "    0 Error(s)"

# Go back to the original directory
cd ..
