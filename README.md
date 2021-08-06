# iOSApp
An arcade-style iOS game made with Unity3D called 'Warehouse Run'.
## Introduction
This app was insipired by classic arcade-style games like Flappy Bird or really anything from the developers KetchApp. You play as a cardboard box in a industrial-warehouse setting trying to get past pieces of steel of differing sizes. 
## How to Use
This app is to be solely used on iPhones. While it can be used on any iOS device the aspect ratio will most likely be skewed. Because the app relies on touch it will not work on computers.
### Initial Menu (Menu)
The app will open on this scene, called 'Menu' in the source code, which will display the name of the game 'Warehouse Run' and have a start button that will launch the game. Clicking on the start button will launch you into the game scene. 
### Game Scene (First) 
This scene is responsible for the actual game and is called 'First' in the source code. This scene revolves around the player a cardboard box, which you control and is initially positioned in the middle of the screen. By tapping on your screen the box will jump, you can also double jump by double tapping on your screen. You will want to jump as you will have to dodge pieces of steel of differing sizes that will go across the screen from right to left. If you do not dodge the pieces of steel they will drag the cardboard box out of the view of the screen which ends the game and open the end menu scene. The game screen also has two buttons at the top right corner that control the sound, a mute button, and can pause the game, a pause button. Your score, which will be the displayed in the end menu scene along with your highscore, is the number of pieces of steel you successfully dodge.
### End Menu (Died Menu)
This scene opens when the player is pushed out of view by pieces of steel and is called 'Died Menu' in the source code. It informs you that you lost and gives you your score, number of pieces of steel you dodged, and your highscore. You have two buttons in this scene: 'Try Again' and 'Menu'. 'Try Again' will launch you into the game scene via the buffer scene and the 'Menu' scene will put you back into the inital menu scene. 
### Buffer Scene (BufferScene)
Used to entertain the user while the actual game is being initialized and always preludes the game scene itself. It featured a rotating cardboard box but because of the relatively small size of the game it is unlikely the user will ever notice the screen. 
### Preview
Used for materials, will never be seen by the user. 
## Assets
Below is an overview of all assets in the source code and its rough purpose:
* Brick Substance Folder - Is the folder that stores the brick material that is used as the background of the game.
* Materials Folder - Contains a number of materials for things such as the pause button ,unpause button ,lamp and the piece of steel.
* Scenes Folder - Contains all the scenes used in the game
* Steel_Window Folder - Contains the material used for the steel window that is used in the background of the game.
* BackgroundMusicGame - A WAV file that plays a simple robotic tune in the background of the game. Self-Made through online tune software.
* CreatifDemo - The font used for all text in the game. 
* Cylinder - The object representing the lamp.
* New Physic Material - Physics Material that sets friction.
* Packing Boxes Sound - Used for background sound effects.
* Pause Button - An image used by the pause button material.
* Player - An image used by the player material.
* Player.prefab - The player object that is actually shown on screen and the object the whole game centers on.
* Point Light (1).prefab - Unity light used for brightening the scenes.
* PushandJumpSound - Sound used when the player taps the box and it jumps or when a button is clicked.
* Steel_Window 1.prefab - The steel window object that is used in the background of the scene to liven up the scene.
* UnMuting_Button - An image used for the unmuting material.
* UnPauseButton - An image used for the unpause button.
* UnUnMuttingButton - An image used for the mute button.
* BackgroundWall.prefab - The background red brick wall object used in all of the game's backgrounds.
* Wall.prefab - The object for the pieces of steel the player has to dodge.
* WallMaterial - Physics material used by the pieces of steel and so the wall.prefab object
## Scripts
Below is an overview of all the scripts used by the iOS game:
* ClickToPlay - Used by the buttons that start the actual game by launching the buffer scene.
* GoBackToMenu - Used by the buttons that get the user back to the menu from the lost/died scene. 
* JumpScript - Responsible for the jumping of the player. Uses forces and is attached the object that is supposed to jump.
* Killed - Checks whether the player object is out of bounds in which case it ends the game and loads the died/lost menu. Is attached to the player object.
* LampMovement - Responsible for the movement and eventual destruction of the Lamp object which serves in the background to liven up the scene. Attached to the lamp object itself.
* LoadGame - Used by the buffer scene to asynchronously load the actual game, the 'first' scene. Its done asynchronously to allow for some entertainment if the scene is taking a long time to load.
* MovementOfWall - Responsible for the movement of the texture on the background wall object to simulate movement. Attached to the large background brick wall.
* MovementOfWalls - Responsible for the movement of the pieces of steel that the player must dodge. Also keeps count of the total score of the game. Attached to each piece of steel.
* Mute - Responsible for muting the sound and changing the visibility of the accompanying buttons. Attached to the canvas.
* Pause - Controls whether the game is paused and the appropriate button visibilities. Attached to the canvas.
* Rotatorofball - Rotates the cardboard box in the buffer scene to entertain the user while the game is being loaded. Attached to the box at the center of the buffer scene.
* Score - Manages the scoring of the game and displays the score along with the highscore in the lose/died menu. Attached to the box displaying the scores.
* Spawner - Responsible for spawning lamps. Attached to the lamp spawner object
* Walls - Generates pieces of steel the player must dodge and keeps the current score display in the game. Attached to the wall spawner.
* WindowSpawner - Responsible for spawning windows used in the background. Attached to the window spawner.
## External Sources
Some of the assets used in this app was not my own work and I lay no claim to them. The following assets were from third-party sources and while they are not of my creation they are were all under Creative Commons Licence 
* Brick Substance Folder
* Steel_Window Folder
* CreatifDemo 
* Packing Boxes Sound
