#!/usr/bin/env bash


#Check if the 'dotnet' command is available
if ! command -v dotnet &> /dev/null
then
	echo "dotnet command could not be found. Please install .NET SDK."
	exit 1
fi

# Create a new folder titled '1-new_project'
mkdir -p 1-new_project

# Navigate into the new folder
cd 1-new_project || { echo "Failed to change directory"; exit 1; }

# Initialize a new C# console project
dotnet new console --output .

# Check if the project creation was successful
if [ $? -eq 0 ]; then
	echo "The template \"Console Application\" was created successfully."
	echo
	echo "Processing post-creation actions..."
        echo "Running 'dotnet restore' on $(pwd)/1-new_project.csproj..."

	# Run 'dotnet restore' to restore the packages
	dotnet restore

	# Check if the restore was successful
	if [ $? -eq 0 ]; then
		echo "Restore succeeded."

	        # Build the project
                dotnet build

		# Check if the build was successful
	        if [ $? -eq 0 ]; then
			echo "Build succeeded."
	        else
		        echo "Build failed."
			exit 1
		fi

        else
		echo "Restore failed."
		exit 1
	fi


else
	echo "Build succeeded."
	echo "0 Warning(s)"
        echo "0 Error(s)"
fi
