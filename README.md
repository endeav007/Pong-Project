
# PONG
Created in Unity, v. 6.2 by Autumn Austin

Last Updated: 8/29/2025

## Quick Launch

Double-click the ‘pong.exe’ file to open the game.

## Game Instructions

This is a single player game where you’ll be playing against a computer. Use the ‘w’ and ‘s’ keys to move the left paddle up and down and try to hit the ball toward the opposing side. The game is infinite, you can quit by either pressing the "Escape" key or going to the help menu by pressing "Q” and pressing the “Quit Game” button.

## Updating the Code

### Dependencies

To edit or update this project, you’ll need these things:

-   Updated Unity Hub
    
-   (Required if you want to edit scripts) An IDE compatible with Unity



This program was created using Unity 6.2 (6000.2.2f1), so ensure you have that version installed before continuing. You can search for older versions of Unity here: [https://unity.com/releases/editor/archive](https://unity.com/releases/editor/archive)

If you don’t already have Unity installed, you can find the download link and instructions for the installer here: [https://unity.com/download](https://unity.com/download)

### Instructions for setting up the project:

1.  Download the files from GitHub
    
2.  Extract the contents of the file into a folder.
    
3.  Open the Unity Hub and make sure you’re on the ‘Projects’ tab.
    
4.  Click “Add” → “Add Project From Disk” and locate your folder with the extracted contents. Hit “open”.
    
5.  Once you’ve hit open, the project should automatically add itself to your projects list.
    
6.  Click the project to open it.
    
7.  In the upper left corner, click “File” → “Build and Run” to make your own executable.
    

  

From here, you can click your executable to run it! You can also edit all the files included in the zip if you choose, just remember to do step 7 again for an updated executable file.

## Important notes for editing.

-   Making the menu work on the pause screen was a hurdle. If you edit the code, make sure the MenuCanvas’ “Order In Layer” is set to 1, or else the Pause buttons won’t work.
    
-   If you want to change the difficulty, you can adjust the ball or ComputerPaddle’s speed by increasing their mass under “RigidBody2D.”
    

## Plans for future development

-   Implementing a scoring system that could also track your highest score.
    
-   A dark mode or a way for the user to select different map colorings.
    
-   Touchscreen Compatibility
