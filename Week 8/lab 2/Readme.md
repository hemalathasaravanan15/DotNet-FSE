## Git Hands-on: Using .gitignore to Ignore Log Files and Folders
## Objective
The goal of this step is to demonstrate how to create a .gitignore file to exclude certain files and directories (like log files) from being tracked in Git.

## Steps Performed
## 1. Create a log file
echo "Some log" > debug.log
This creates debug.log with the text "Some log".

## 2. Create a logs directory and error log
mkdir logs
echo "Error log" > logs/error.txt
A directory logs is created, and error.txt inside it contains the text "Error log".

## 3. Create a .gitignore file
echo "*.log" > .gitignore
echo "logs/" >> .gitignore
This tells Git to ignore:

Any file ending with .log (e.g., debug.log)
The entire logs/ directory

## 4. Stage and commit .gitignore
git add .gitignore
git commit -m "Ignore log files and logs folder"
The .gitignore file is tracked and committed to the repository.

## 5. Attempt to push to remote
git push
Result: Git shows:

fatal: The current branch master has no upstream branch.
This means the branch has not been linked to a remote repository yet.

Next Step to Push
If you have a remote repository set up, link and push:

git push --set-upstream origin master
After this, future pushes can be done simply with:

git push
## Output

<img width="1237" height="745" alt="lab 2" src="https://github.com/user-attachments/assets/39b15262-a2a3-4f8e-b86d-f25e298bbb8a" />


## Conclusion
In this step, you successfully:

Created files and folders to be ignored
Configured .gitignore to exclude them from Git tracking
Committed the .gitignore file

