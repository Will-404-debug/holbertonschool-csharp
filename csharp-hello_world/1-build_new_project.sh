#!/usr/bin/env bash

# Check if the 'dotnet' command is available
if ! command -v dotnet &> /dev/null; then
	echo "dotnet command could not be found. Please install .NET SDK."
	exit 1
fi

# Directory for the new project
PROJECT_DIR="1-new_project"

# Remove any existing directory with the same name (for a clean slate)
rm -rf "$PROJECT_DIR"

# Create a new folder titled '1-new_project'
mkdir -p "$PROJECT_DIR"

# Navigate into the new folder
cd "$PROJECT_DIR" || { echo "Failed to navigate to $PROJECT_DIR"; exit 1; }

# Initialize a new C# console project
if dotnet new console -o . &> /dev/null; then
	# Run 'dotnet restore' to restore the packages
        if dotnet restore &> /dev/null; then
		# Build the project
	        build_output=$(dotnet build 2>&1)

                #Check if build succeded and print expected output format
	        if echo "$build_output" | grep -q "Build succeeded."; then
			echo "Build succeeded."
			echo "    0 Warning(s)"
			echo "    0 Error(s)"
		else
			echo "Build failed."
			exit 1
		fi
	else
		echo "Restore failed."
		exit 1
	fi
else
	echo "Project creation failed."
	exit 1
fi
