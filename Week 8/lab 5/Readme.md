## Git Hands-on: Cloning, Adding a File, and Pushing to Remote
## Objective
This exercise demonstrates:

Cloning an existing repository from GitHub
Adding a new file to the repository
Committing changes locally
Pushing updates to the remote repository
## Steps Performed
## 1. Clone the repository
git clone https://github.com/SurendarNehru/GitCleanupLab.git
Cloned the remote repository GitCleanupLab into the local folder.
Verified that the repository contains existing files (doc.tx).
## 2. Navigate into the repository
cd GitCleanupLab
Switched to the cloned repository’s directory.

## 3. Create a new file for the lab
echo "This is a new file for the lab." > lab_file.txt
Created lab_file.txt with the text "This is a new file for the lab."
## 4. Stage the file
git add lab_file.txt
Marked lab_file.txt to be tracked and included in the next commit.

## 5. Commit the file
git commit -m "add this txt file"
Recorded the addition of lab_file.txt in the local repository.
Commit ID: d14d6d0.
## 6. Check repository status
git status
Showed that the branch was ahead of origin/main by 1 commit.

## 7. Push the commit to remote
git push origin main
Uploaded the local commit to the remote repository on GitHub.
After pushing, the new file appeared in the remote repository.
Result on GitHub
The repository GitCleanupLab now contains:

doc.tx (existing file)
lab_file.txt (newly added file containing the lab text)
## Output


<img width="1346" height="716" alt="Screenshot 2025-08-13 232443" src="https://github.com/user-attachments/assets/10ede80b-4964-45fd-97ce-1c7e0f3fde49" />




<img width="1350" height="676" alt="Screenshot 2025-08-13 232839" src="https://github.com/user-attachments/assets/b8555473-5723-4650-a356-fe2037e87b71" />




## Conclusion
In this step, you:

Cloned a remote repository
Added a new file
Committed the change locally
Pushed the change to the remote
