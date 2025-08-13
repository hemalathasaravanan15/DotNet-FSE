## Git Hands-on Lab
## Objective
This hands-on lab demonstrates the basic Git workflow including installation, configuration, repository creation, committing changes, and interacting with a remote repository. The setup uses Notepad++ as the default Git editor.

## Prerequisites
Windows OS
VS Code (optional — not used as editor here)
Notepad++ (installed and added to PATH)
Git for Windows (with Git Bash)
GitHub or GitLab account
## Setup Steps
## 1. Install Git
Download and install Git for Windows from https://git-scm.com/downloads. Verify:

git --version
## 2. Install Notepad++
Download and install from https://notepad-plus-plus.org/downloads/. Add installation path to Windows PATH:

C:\Program Files\Notepad++
## 3. Configure Git
git config --global user.name "Your Name"
git config --global user.email "you@example.com"
git config --global core.editor "'C:/Program Files/Notepad++/notepad++.exe' -multiInst -notabbar -nosession -noPlugin"
git config --list
Local Repository Workflow
## 4. Create and Initialize Repository
mkdir GitDemo
cd GitDemo
git init
## 5. Create and Commit a File
echo "Welcome to GitDemo" > welcome.txt
git status
git add welcome.txt
git commit -m "Initial commit: add welcome.txt"
git log --oneline
## 6. Edit File and Commit via Notepad++
notepad++ welcome.txt
# Modify, save, close
git status
git add welcome.txt
git commit
Commit message opens in Notepad++. Save & close to finish.

Remote Repository Workflow
## 7. Create Remote Repo
On GitHub/GitLab, create repository GitDemo. Copy HTTPS URL.

## 8. Link and Push to Remote
git remote add origin <remote-URL>
git branch -M main   # or master if remote uses master
git push -u origin main
Pulling and Cloning
## 9. Pull Changes
git pull origin main
## 10. Clone Repository
cd ..
git clone <remote-URL> GitDemo-copy
## Output


<img width="1346" height="711" alt="Screenshot 2025-08-13 231106" src="https://github.com/user-attachments/assets/bd65cf98-9825-4a6c-81a8-80814006988a" />


<img width="1365" height="677" alt="Screenshot 2025-08-13 231053" src="https://github.com/user-attachments/assets/6d81e7ff-638d-4652-9412-f8d54179448e" />


## Conclusion
This hands-on demonstrated a complete Git workflow using Notepad++ as the commit message editor. The steps covered installation, configuration, local and remote repository setup, committing changes, and syncing between local and remote. Following this workflow ensures smooth collaboration and version control in real-world projects.
