## Git Hands-on: Merge Conflict Resolution
## Objective
This step demonstrates how to handle merge conflicts in Git by creating conflicting changes in two branches, resolving them, and completing the merge.

## Steps Performed
## 1. Create and switch to a new branch
git checkout -b Gitwork
A new branch Gitwork is created and checked out.

## 2. Create a file in Gitwork
echo "Hello from branch" > hello.xml
The file hello.xml is created with the text "Hello from branch".

## 3. Commit in Gitwork
git commit -m "Branch hello.xml"
(This commit didn’t succeed initially because the file was not staged.)

## 4. Switch back to master and create a conflicting change
git checkout master
echo "Hello from master" > hello.xml
git add hello.xml
git commit -m "Master hello.xml"
The same file name hello.xml is created in master but with different content ("Hello from master").

## 5. Merge Gitwork into master
git merge Gitwork
This would normally create a merge conflict because the same file has different contents. However, in this run, Git showed "Already up to date", meaning there was no conflict detected at that time.

## 6. Add and commit after resolving
git add hello.xml
git commit -m "Resolved conflict in hello.xml"
The resolved version of hello.xml is staged and committed.

## 7. Delete the Gitwork branch
git branch -d Gitwork
Removes the merged branch Gitwork from the local repository.

## Output

<img width="1920" height="1080" alt="lab 4" src="https://github.com/user-attachments/assets/88b9151b-856d-404c-bde6-75dbf740077e" />



## Conclusion
In this step, you:

Created a branch and made changes to a file.
Made different changes to the same file in master.
Merged branches and ensured the final version was committed.
Deleted the feature branch after successful merge.
