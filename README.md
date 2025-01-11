[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Player:
Moves around with WASD keys (can technically move out of the bound after testing)
Plant one plant when the spacebar is pressed (when there are still remaining seeds)
Also decreases the number of remaining seeds
Also increases the number of planted seeds

Plant:
Can be planted when player presses space
Has limited 

UI
Updates:
Increases the number of the planted seeds
Decreases the number of the remaining seeds

Camera:
Does not move with the player, shows what's on the scene

## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.


Write your Devlog here!

I accidently started a new scene when I first did this, so I added everything in the scene myselves but then realized that we already had the scene ready, but everything was pretty much the same so i just went on with the scene that I created.

Player - I first added the codes for movements using if statements and GetKey and since it's been a while since I last did that I had to go back and reference the unity keycode documentation. Then I implemented the planting by pressing spacebar, and quickly realized GetKey wont work properly so I switched to GetKeyDown. I used one if statement to check if there are still remaining seeds left, if so, call the PlantSeed method.

Plant - I instantiate the plant object and changes the number of remaining seeds & planted seeds inside the PlantSeed method. I also call the UI class to update the ui whenever there are changes to those numbers. (Those are done in the player script since we dont have the plant script and the plant does not do anything except for being planted)

UI - UpdateSeed method is called inside the PlantSeed method, which will update the UI for both the number of remaining seed and the number of the planted seeds. I also added some extra funny text to pop up when you have planted all the seeds 

Camera - Its just there, existing... oh I changed the background slightly so the color feels better

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
