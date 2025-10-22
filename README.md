# CourseProjectProgressionGameEngine
Laith Ghannam 100895645 for INFR 3110U – Game Engine Design & Implementation

*IMPORTANT* Click on sample scene to load the actual game scene if u wish not to display win/lose screens

I've created a short platformer game that follows a knight that was captured by enemy forces and sent down a ruined dungeon, the scene starts with the knight wondering where he is and quickly realize he must escape before the dungeon falls apart. The scene then lets the player platform across small platforms in order to get to the next area and by the end of the 2nd area the knight will have to either fight or run away from the hordes of goblins that spawn in front of him. Once player makes it to the door at the end of the second platform he will be greeted with a win screen and a lose screen if he falls down to the pits or dies to the goblins.

Player must find their way to the second door within 2 minutes or else they will immediately lose the game, player has the option to fight back with left mouse click but it deals little damage to encourage running away.

what players will first see when they load in, and the start of the second set of platforms, and the door players must touch in order to win
<img width="873" height="466" alt="image" src="https://github.com/user-attachments/assets/52ada6b0-a07d-4d25-900d-115f316927d5" /> <img width="539" height="306" alt="image" src="https://github.com/user-attachments/assets/7c8f9966-c1e8-426d-8c94-ea222159dac2" /> <img width="536" height="312" alt="image" src="https://github.com/user-attachments/assets/3dec01dd-143c-410d-9f1c-f7344b699ca2" />

I coded the timemanager singleton with the help of AI, I've modified it heavily to make sure the code is displayed on a text using TMPro, and it shows the countdown on the canvas
Same with the command design pattern, I've asked AI to help me modify my already existing movement code and how to allow the buttons to be remapped for the player, I've modified it heavily to make sure the original movement logic I've coded is not changed. This picture is of the original script before I modified it
<img width="671" height="721" alt="Screenshot 2025-10-22 101800" src="https://github.com/user-attachments/assets/6467e918-fb56-4f80-a557-ce97c29b9b05" />

The DLL and Factory spawner are both coded by me and are both basic functions
Dll displays dialogue made by goblins and main character, and I've turned the dialogue into buttons that the player can press to dismiss
Factory spawner simply spawns in goblins every 40 seconds to add challenge if player takes too long


Assets credits:
Goblin model and animations: https://assetstore.unity.com/packages/3d/characters/goblin-lowpoly-animation-311643
Dungeon models: https://assetstore.unity.com/packages/3d/props/furniture/3d-dungeon-lowpoly-pack-231265
Knight playermodel and animations: https://assetstore.unity.com/packages/3d/characters/humanoids/fantasy/rpg-hero-pbr-hp-polyart-121480




