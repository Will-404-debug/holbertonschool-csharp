#!/usr/bin/env bash

#Define the project name and directory
PROJECT_NAME="1-new_project"
PROJECT_DIR="./${PROJECT_NAME}"

# Create the project directory if it does not exist
mkdir -p "$PROJECT_DIR"

# Change to the project directory
cd "$PROJECT_DIR" || { echo "Failed to change directory to $PROJECT_DIR"; exit 1; }

# Initialize a new C# project
dotnet new console -o . || { echo "Failed to initialize the C# project"; exit 1; }

# Restore the project dependencies
dotnet restore || { echo "Failed to restore project dependencies"; exit 1; }

# Build the project
dotnet build || { echo "Failed to build the project"; exit 1; }

echo "Project initialized and built successfully."
