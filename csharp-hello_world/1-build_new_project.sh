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
if dotnet new console -o .; then
	echo "The template \"Console Application\" was created successfully."
	echo
	echo "Processing post-creation actions..."
	
        # Run 'dotnet restore' to restore the packages
	echo "Running 'dotnet restore' on $(pwd)/1-new_project.csproj..."
        if dotnet restore; then
		echo "Restore succeeded."
	else
		echo "Restore failed."
		exit 1
	fi

	# Build the project
	echo "Building the project..."
	build_output=$(dotnet build)
	
	if echo "$build_output" | grep -q "Build succeeded."; then
		echo "Build succeeded."
		echo "    0 Warning(s)"
		echo "    0 Error(s)"
	else
		echo "Build failed."
		exit 1
	fi
else
	echo "Project creation failed."
	exit 1
fi

# Go back to the original directory
cd ..

# Optional: List the contents of the project directory to verify creation
ls "$PROJECT_DIR"
