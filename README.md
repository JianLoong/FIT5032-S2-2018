# FIT5032-S2-2018

## Outline

| Week | Tutorial                                   |
| :--: | :----------------------------------------- |
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

## Notice

This repository contents various solutions for FIT5032 - Internet Application Development done for the year 2018. (Semester 2).

None of these materials provided here are the real lecture materials as they are considered to be the pre-reading and additional materials provided for the smooth running of the labs.

As of 2019, this repository will be abandoned and the issues will remain open in the scenario where an update would be needed.

Original plans to convert materials to markdown files were abandoned as well due to lack of time and training given the teaching team.

## Run Instructions

Solutions are working out of the box. (Due to the nature of this unit)

.mdf files are intentionally in the repository so that it would be working. (via .gitignore file)

Thus, because of this this repository is roughly 100 MB in size. (This includes pdf files as well which were placed into the repo.)

## Contribute (Hacktoberfest 2018)

The purpose of this repository was to encourage students to use a VCS tool and contribute to a simple open source repository in conjunction of Hacktoberfest 2018. Issues that are open will remain open, but I will not be handling any more pull request.

### Previous pull request instructions are as follows

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
