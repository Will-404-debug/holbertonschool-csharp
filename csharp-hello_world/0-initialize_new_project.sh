#!/usr/bin/env bash

#Check if the 'dotnet' command is available
if ! command -v dotnet &> /dev/null
then
	echo "dotnet command could not be found. Please install .NET SDK."
	exit 1
fi

# Create a new folder titled '0-new_project'
mkdir -p 0-new_project

# Initialize a new C# console project inside the '0-new_project' folder
dotnet new console --output 0-new_project

# Check if the project creation was successful
if [ $? -eq 0 ]; then
	echo "The template \"Console Application\" was created successfully."
    else
	    echo "Project creation failed."
	    exit 1
fi
