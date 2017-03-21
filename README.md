#HW3 (team project)

##3D Real time strategy game

You will be building a simple 3D [Real time strategy game](https://en.wikipedia.org/wiki/Real-time_strategy). Think of games like 'Age of Empires', 'Command & Conquer', 'Starcraft' etc.


#### Theme
You can decide on the theme of the game. Which means all the content such as type of terrain, player models, AI assets and other assets can be based on the theme. Don't randomly add meaningless assets.

####Terrain:

* Sufficiently large for a few minutes of gameplay
* Has terrain specific details such as trees,(other asset items based on your theme; Get creative!).
* Use Navmesh for AI/Player movements.
* Has hilly areas(the navmesh will take care of navigation).
* You can optionally use the terrain from HW1.
* The terrain should be complex enough so that Navmesh navigation is obvious(Look at the link on Navmesh).


####Functionality:

* The user shall be able to click on the player and select it. 
* The user shall be able to click on a location on the map. If the player was selected, then the player will start moving towards that location.
* AI characters in the scene will start chasing the player(using the navmesh).
* The player health will detoriate when close to the AI enemy.
* The player can be instructed to attack a specific enemy.
* There will be multiple AI components.
* Basic assignment requires only two animations for the player. Enemy AI animation will be extra credit.
* Try to use 3D assets that come packaged with Animations.

####Camera

* Movement in the XZ plane (y is global up in unity).
* Sufficient distance above the terrain.
* Movement controlled by `w a s d` keys

####Mouse 

* Use raycasts for detecting mouse clicks.
* Once the character is selected, the user can use the mouse to click a point in the terrain for the character to start moving towards it.
* The user can also use the mouse to start attacking an enemy

####Player(main character)

* There needs to be **atleast** two Animations for the character(example: idle and walking)

#### Extra credit:

* Advanced and smoother camera movements (could use Lerp)
* More than 2 animations for the player and the AI characters.(idle, walking, attacking,etc)
* Rich and detailed terrain.
* More functionality than originally required.

#### Grading Rubric:

* Is the game fun to play
* Does the game run properly and does not have bugs
* Does the game look good.
* Extra credit: (Look at the extra credit section in the description above.)

#### Relevant links

* Unity Navigation docs: https://docs.unity3d.com/Manual/Navigation.html
* Unity Navmesh(part of the link above):
* Lerp: https://docs.unity3d.com/ScriptReference/Vector3.Lerp.html
* Raycasts: https://docs.unity3d.com/ScriptReference/Physics.Raycast.html

#### Notes

* Post questions on Piazza if you have any. This class encourages collaboration and discussions. 
* Never copy-paste code.
* If you do use open-source code, make sure you mention it at the bottom of this README.
* If you want to add external notes(aside from comments in code), then just add it into this readme. The staff may not be able to find any other text files in your project.
* Also start thinking about the flexible project(that will be the final/last project).