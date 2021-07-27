
==About this scene===========================

This scene is meant to serve as a template to speed up the proccess of making new levels.
!!DO NOT ALTER THIS SCENE!! unless you either
1) are certian that the changes you make will benifit any an all future levels made with this template
2) you are following the steps listed below on how to use this scene

==How to use this scene======================

Follow these steps to use this scene to make a new level/loop


1)In the Project window of Unity right click on this scene.

2)Choose the 'Show in Explorer' option. [It is second from the top right underneath 'Create']

3)In the now open file exporer select the file with THE EXACT SAME NAME as the blank scene you want to use (It should already be selected)
	3.b) [Make sure the file you select DOES NOT say '.unity.meta' at the end]

4)With the scene file now selected you are going to copy and paste it right back in the same directory
	4.b) Well the file is selected press CTRL + C
	4.c) Next press CTRL + V
	4.d) above the selected scene you should see a new 'Unity scene file' with the exact same name as the one selected expect it has the word ' - Copy' at the end
		4.d.1)[The new 'Unity scene file' will not have a '.unity.meta' file at the moment, this is fine]

5)Select the new ' - Copy' file.  (This is the file you will be working with)  Rename it to what ever you like.

6)Return to Unity.  You should now see your new scene listed in the Project window.  Switch to the new scene.

7)Build your level.



Follow these steps to get your new scene to transition to it's next scene.

1)Go to File/Build Settings..

2)Make sure that both the current scene and the scene you want to transition to are listed in the 'Scenes in Build' list
	2.b)If they are not drag both of the scenes from the Project window and into the list
	2.c)Even if both scenes are in the list make sure that the small box next to them has a checkmark (Click the box if there is no checkmark)

3)In the scene you want to transition from, find the prefab with the name 'Exit_1' in the scene hierarchy

4)DO NOT OPEN THE PREFAB VIEW instead open the drop down in order to see the children for Exit_1

5)Find the child named 'Invisible Wall' and select it

6)Look in the inspector for the component 'Loop Transition'
 	6.b)This component will have one field
	6.c)Fill that component out with the name of the scene you want to transition to as it appears in the Project window

7)Go into play mode and test your new transition 
