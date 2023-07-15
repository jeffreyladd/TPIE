# Versioning
Here at TPIE we follow our own version of Semantic Versioning.  Our Version numbers have 4 places, followed by stage placement.
It is defined as follows:  Major . Minor . Patch . Build - stage.  

### Major
This placement gets increased when the public api will change AFTER inital release of version 1.0.0.0.  Prior to version 1.0.0.0, the public
api can and will change at any given point in time.  When this placement changes, the prior used version will no longer be supported. Example:
When we go from version 1.x.x.x to version 2.0.1.0, version 1.x.x.x will no longer be supported and you can continue to use that version at your 
own risk.  Any new features, bug fixes, and security fixes will be under the new version.  NOTE:  If there is a severe vulnerability found, we may
make an exception that the Code Owners will make the decision on.  Maintainers may be consulted but descision will be made by the Code Owners.

### Minor
This placement gets increased when we determine that the amount of new features and bugfixes warrent an increase in the minor number.  We ask that most individuals 
stay current on this placement rather than Patch.

### Patch
This placement gets updated on when a new feature is brought in.  

### Build
This placement gets updated on when a new bugfix is brought in with no other changes in functionality.  

### Stage
This is what stage the version is at.  No stage present means that it is live and good to use by everyone.  RC means it is okay to be used by most and support 
will be provided but resolution may be slightly delayed compared to live.  PR means use at your own risk as no support should be expected till it reaches RC.


## Who can make version changes
Only Code owners and Maintainers may make version number updates (this is why any place where a version number can be changes is moved out to its own file.  Please no touchy.)
Any changes will be made directly to the master branch with the [skip ci] flag prior to a new feature being brought in.
