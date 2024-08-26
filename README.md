# Flappy Cubird

Welcome to **Flappy Cubird**, where the iconic Flappy Bird takes on a new dimension! Glide through vibrant 2D worlds as a cube-shaped bird, with three exciting themes that add a fresh spin to the classic gameplay you love.

## Platforms

- Windows
- WebGL

**Play the game online:** [Flappy Cubird on Simmer](https://simmer.io/@MukeshKrish/flappy-cubird)

## Gameplay Mechanics

- **Movement:** The cube-shaped bird jumps with each press of the spacebar, requiring precise timing to navigate through obstacles.
- **Obstacles:** Spawning pipes serve as the primary obstacles, challenging players to skillfully guide the bird through narrow gaps.
- **Gravity Effect:** The bird is constantly pulled downward by gravity, adding a level of challenge as players must continuously press the spacebar to keep it airborne.

## UI/UX Design Features

- **Three Distinct Themes:** The game offers three visually captivating themes—Sunny, Partly Cloudy, and Night—each providing a unique atmosphere for the player to explore.
- **Background Audio Control:** Includes an on/off button to manage background music.
- **Score Tracking:** The player's current score is prominently displayed in the top right corner of the screen, allowing for easy tracking of progress without distracting from the gameplay.
- **Restart Button:** A prominent restart button allows players to quickly start a new game session, providing an easy way to try again after a game over.
- **Pause Menu:** Players can pause the game by pressing the "P" key. The pause menu overlays the game screen, allowing players to pause the game, restart or return to the main menu.
- **Canva-Designed Characters and Obstacles:** Both the player character and the spawning pipes are meticulously crafted using Canva.
- **About Panel:** The game includes an About panel that provides information about the developer, offering players insight into the creator's background and inspiration behind "Flappy Cubird."

## Comprehensive Game Development Scripts

- **LogicScript:** Manages the player's score, handles game-over and pause functionality, and controls scene transitions. It updates the score, displays the game-over screen, and manages time scaling for pausing and resuming the game.
- **BirdScript:** Controls the player character's movement, allowing it to flap upward when the spacebar is pressed. It interacts with the `LogicScript` to trigger a game-over state when the bird collides with obstacles and deactivates the bird upon collision.
- **PipeSpawner:** Controls the regular spawning of pipes at varying vertical positions, creating dynamic obstacles by using a timer to ensure consistent gameplay.
- **PipeMovement:** Moves pipes leftward across the screen and destroys them when they move off-screen, ensuring smooth gameplay and preventing performance issues.

## Visual and Audio Elements

- **Bird and Pipe Designs:** Designed by Mukesh, showcasing a unique and personalized look.
- **Skybox Visuals:** The Fantasy Skybox, available at the Unity Asset Store, provides a visually appealing backdrop.
- **Audio:** Features the "Simple Fantasy Traveling Music Pack" from the Unity Asset Store for an immersive auditory experience.

## Getting Started

To get a local copy up and running, follow these steps:

1. Clone the repository:
    ```bash
    git clone https://github.com/mukeshkrish08/FlappyCubird-Unity2D
    ```
2. Open the project in Unity.
