#!/usr/bin/env bash

# Define the project name and directory
PROJECT_NAME="1-new_project"
PROJECT_DIR="./${PROJECT_NAME}"

# Create the project directory if it does not exist
mkdir -p "$PROJECT_DIR"

# Change to the project directory
cd "$PROJECT_DIR" || exit 1

# Initialize a new C# project
dotnet new console -o . || exit 1

# Restore the project dependencies
dotnet restore || exit 1

# Build the project and only output the build result
dotnet build | tee /dev/stderr | grep -E 'Build succeeded.|Error|Warning'
