# iTrackerFix

A [NeosModLoader](https://github.com/zkxs/NeosModLoader) mod for [Neos VR](https://neos.com/) that fixes an issue where eye tracking will break if your viewpoint is directly in front of or inside a collider. To illustrate this issue, if someone places their hand in front of your avatar's face, the avatar's eye directions will become parallel (the so-called [thousand-yard stare](https://en.wikipedia.org/wiki/Thousand-yard_stare)), which looks rather odd. This mod effectively fixes this bug. 

## Installation
1. Install [NeosModLoader](https://github.com/zkxs/NeosModLoader).
1. Place [iTrackerFix.dll](https://github.com/GithubUsername/RepoName/releases/latest/download/iTrackerFix.dll) into your `nml_mods` folder. This folder should be at `C:\Program Files (x86)\Steam\steamapps\common\NeosVR\nml_mods` for a default install. You can create it if it's missing, or if you launch the game once with NeosModLoader installed it will create the folder for you.
1. Start the game. If you want to verify that the mod is working you can check your Neos logs.
