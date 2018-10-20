# FIT5032-S2-2018

## Outline

| Week | Tutorial                                   |
|:----:|:-------------------------------------------|
|  1   | Introduction to Visual Studio 2017         |
|  2   | Responsive Web Design                      |
|  3   | Introduction to C#                         |
|  4   | Entity Framework                           |
|  5   | Fundamental Client Side JavaScript         |
|  6   | Validation                                 |
|  7   | Security & Microsoft Identity              |
|  8   | Email, Upload & Signal R                   |
|  9   | Optimization                               |
|  10  | Modern JavaScript Web Development Approach |
|  11  | Testing, Deployment & Evolution            |
|  12  | No change                                  |

## Contents

This repository contents various solutions for FIT5032 - Internet Application Development.

## Run Instructions

Solutions are working out of the box. 

.mdf files are intentionally in the repository so that it would be working.

## Contribute

#### Getting Started

- Fork this repository (button on top)
- Clone on your local machine

```terminal
git clone https://github.com/JianLoong/FIT5032-S2-2018
cd FIT5032-S2-2018
```

- Create a new branch

```markdown
git checkout -b my-new-branch
```
- Add your contribution
- Commit and push

```markdown
git add .
git commit -m "your-commit-msg"
git push origin my-new-branch
```

- Create a new pull request from your forked repository


#### Avoid Conflicts (Syncing your fork)

An easy way to avoid conflicts is to add an 'upstream' for your git repo, as other PR's may be merged while you're working on your branch/fork.   

```terminal
git remote add upstream https://github.com/JianLoong/FIT5032-S2-2018
```

You can verify that the new remote has been added by typing
```terminal
git remote -v
```

To pull any new changes from your parent repo simply run
```terminal
git merge upstream/master
```
