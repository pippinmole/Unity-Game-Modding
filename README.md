
# Unity Game Modding with Oxide

## What?
Oxide is a set of tools used to inject code into your Unity game files, and load Oxide libraries which can change the internal state of your game server, without having to include mod support into your game in the development process.

Oxide is used in a range of games, including [Rust](https://store.steampowered.com/app/252490/), [Unturned](https://store.steampowered.com/app/304930/) and [Reign of Kings](https://store.steampowered.com/app/344760/).

## Why?
You could just build your game with modding support included in the box. However, this can lead to an increase in dependencies. Instead, you could build a vanilla version of your game and include modding support afterwards.

## Installation

### Preparing your game files
1. Build a clean version of your server files to a folder
2. Download Oxide DLL files (located inside the Assemblies folder of this repo)
3. Copy Oxide DLL files into `/GameName_Data/Managed/`

### Patching Assembly-CSharp
1. Open `OxidePatcher.exe` while it is inside `/GameName_Data/Managed/`
2. Navigate to `File > New Project`
	* Enter a name for the project
	* Set the target directory to be the absolute path to the managed folder (e.g. `C:/Game/Game_Data/Managed/`)
	* Set the filename path to somewhere outside of your game files. (e.g. `C:/Game Modding/config.opj`)
	* Click `Create`
3. Under the `Assemblies` dropdown, you should see `Assembly-CSharp`. Right click this, and click `Add to Project`.
4. Navigate the tree to your entry-point class and method. This is normally the first thing to execute in your game. If you do not have one of these, simply add one to your game and build again.
	* It is customary to have a `Bootstrap.cs` class in an empty scene, which acts as a set-up stage before any game logic is run. If you are modding another person's game, they may already have this in place.
	* An example of an entry-point method would be `public void Start() { }` inside a `Bootstrap.cs` class.
5. With this entry-point method selected, click `Hook This Method` and on the new page, where it says `Hook Type`, click the dropdown and select `Initialize Oxide`.
	* You may be prompted with a window saying `Are you sure you want to change the type of this hook? Any hook settings will be lost.` This is fine, click Yes.
6. Navigate to a method that is 2nd in line for execution. This will be used to inject the `InitLogging` hook, which is used by `Oxide.Unity` to set up logging correctly.
7. Similar to how you hooked the first method, select the method and click `Hook This Method`. Set the `Hook Name` to `InitLogging` and ensure the `Hook Type` is set to `Simple`.

After patching Assembly-CSharp.dll, Oxide should be loaded and modding support should be available. To test if Oxide is working properly, run your server. A new `oxide` folder should be in your root game directory. If this is not the case, ensure you followed each step carefully.

### Restoring Assembly-CSharp
If you mistakenly patch the wrong method, or want to revert for any reason, simply delete the `Assembly-CSharp.dll`, and rename `Assembly-CSharp_Original.dll` to `Assembly-CSharp.dll`.

## Usage

## Issues
If you run into any issues setting up the project, please feel free to open up an issue.

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.
