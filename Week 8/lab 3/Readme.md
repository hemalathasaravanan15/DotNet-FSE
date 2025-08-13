## Git Hands-on: Branching, Merging, and Branch Deletion
## Objective
The purpose of this step is to demonstrate:

Creating and switching branches
Adding and committing changes in a branch
Viewing differences between branches
Merging branches into master
Deleting branches after merge
## Steps Performed
## 1. Create and switch to a new branch
git checkout -b GitNewBranch
This creates a new branch named GitNewBranch and switches to it.

## 2. Create and add a file in the new branch
echo "File from GitNewBranch" > branch.txt
git add branch.txt
git commit -m "Added branch.txt"
branch.txt is created and contains the text "File from GitNewBranch".
The file is staged and committed in GitNewBranch.
## 3. Switch back to master
git checkout master
Moves the working directory back to the master branch.

## 4. View differences between master and GitNewBranch
git diff master GitNewBranch
Shows that branch.txt exists in GitNewBranch but not in master.

## 5. Merge GitNewBranch into master
git merge GitNewBranch
Performs a fast-forward merge.
branch.txt is now in the master branch.
## 6. View commit history with graph
git log --oneline --graph --decorate
Shows a simple commit graph:

HEAD (master) includes commit "Added branch.txt"
Previous commits are also listed (e.g., .gitignore addition, initial commit).
## 7. Delete the merged branch
git branch -d GitNewBranch
Deletes GitNewBranch locally after successful merge.
## Output

<img width="1260" height="927" alt="lab 3" src="https://github.com/user-attachments/assets/726bb5f0-efbf-4075-aae8-341de42afd0c" />


## Conclusion
In this step, you successfully:

Created and worked in a new branch
Made and committed changes in that branch
Compared branch content using git diff
Merged changes into master
Deleted the merged branch
