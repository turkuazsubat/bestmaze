# BestMaze - Visual Pathfinding Agent in C# (.NET Framework)

BestMaze is a project developed in C# using Windows Forms that simulates a rule-based artificial intelligence agent navigating a user-defined maze. The agent operates on a 10x10 grid of PictureBoxes representing the environment, where the user sets the start, end, and path by clicking and using radio buttons. Once started, the agent (represented visually as a mouse) attempts to reach the goal using conditional logic and memory of its previous decisions.

## Features

- Visual 10x10 grid created using PictureBoxes
- User interaction to define start, end, path, and obstacles
- Agent moves based on a fixed direction priority: Right → Up → Left → Down
- If stuck, the agent:
  - Deletes dead-end paths
  - Returns to previously saved checkpoints
  - Continues exploring until the goal is reached
- Keeps track of steps taken as a form of scoring
- Timer-driven movement simulates real-time decision making
- Designed without any machine learning — purely logic-driven

## AI Concepts Used

While no machine learning algorithms are used, several classical AI concepts are present:

- **Rule-Based System**: Movement decisions are implemented with `if-else` logic
- **Deterministic Agent**: The agent always behaves the same in the same situation
- **Search-Based Problem Solving**: Systematic trial of directions to find a path
- **Backtracking**: Retreats from dead ends and tries alternative paths
- **Memory-Enabled Agent**: Uses "checkpoint" memory to revisit decision points
- **Non-Heuristic Search**: No estimation or cost function is used; relies only on rules

## Technologies

- C# (.NET Framework 4.5)
- Windows Forms
- `Timer` class for loop-based movement
- Basic GDI+ visuals (mouse icon, path coloring)

## Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/turkuazsubat/bestmaze.git
