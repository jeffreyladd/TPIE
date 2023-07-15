# Lifecycle
The Lifesycle of an feature is as follows

## Issue/Discussion
A feature must have a Github issue or Github Discussion where the feature can be dicussed with the Code Owners, Maintainers,  and
others within the community prior to any work starting or a PR being opened.  If a PR is opened prior to this happening, the PR will be 
rejected cause community input did not have a chance to be provided and that is not what a PR is for.  With this said, if a proof of concept is
wanted to be done to show visually what will have to be done/talked about, that is fine and a link to the poc can be added within the discussion.  


## Implementation
Once as the item has the ready to begin tag associated with the Discussion/Issue, work can start on that item and a PR can be opened.  This tag can be appended
to the item 24-36 hours after the item was originally opened and will be applied by a Code Owner or Maintainer.  Anyone else caught adding the label that was not
accidental will be banned temporily from interacting with the repository.

If someone does not follow the procedure of opening a Discussion/Issue before a new feature PR is open, that PR will be ignored and probably rejected
as the developer did not give the community a chance to have the discussion.  


## PR
Once as a majority of the work has started, a PR can be opened in a draft state so that a review can start.  At minimum, one code owner/Maintainer must review
each PR before it is brought in. The PR must have the following information inside of the description:

1. Which item this PR closes.
1. The current code coverage
1. A link where the current documentation edits can be viewed.  (Yes, we all can read the markdown file, but visually seeing it helps visualize the change.)
1. What breaking changes there will be on this.


## Bug fixes
Each bug fix must be in its own seperate PR.  You cannot\will not bulk merge 10 bug fixes into one PR.


### Notes and thoughts
1. Any changes to this lifecycle will be voted on by the Code Owners only but discussions can be held by all of the community members within its own discussion.  Please feel free to voice them there.
1. Anyone not taking the time to review this lifecycle document, will not have their PR accepted.  Don't worry, we can tell who doesnt.