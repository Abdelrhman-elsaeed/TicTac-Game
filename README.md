# Tic-Tac-Toe Game


![_-ezgif com-video-to-gif-converter (1)](https://github.com/user-attachments/assets/44e53005-a555-467e-a338-c1f62424b5cc)


A classic Tic-Tac-Toe game project developed using **C#** and **Windows Forms**. The game is designed for two players (Player 1 'X' and Player 2 'O') who take turns marking the spaces on a 3x3 grid.

---

## 🎮 Key Features

* **Two-Player System:** Supports two players (Player 1 and Player 2).
* **Turn Tracking:** The UI displays whose turn it is ("Turn: Player 1" / "Turn: Player 2").
* **Win Detection:** After each move, the system checks all 8 possible winning combinations (3 horizontal, 3 vertical, 2 diagonal).
* **Win Highlighting:** When a player wins, the winning cells are highlighted with a different color (GreenYellow).
* **Draw Detection:** The game ends in a "Draw" if all 9 cells are filled with no winner.
* **Result Display:** The final winner (Player 1, Player 2, or Draw) is displayed at the end of the game.
* **Sound Effects:**
    * A sound plays on every valid click (`click.wav`).
    * A distinct sound plays when a player wins (`win.wav`).
    * A sound plays when the game is reset (`Reset.wav`).
* **Invalid Move Prevention:** An error message box appears if a player tries to select a cell that is already taken.
* **Restart Game:** A "Restart Game" button allows players to clear the board and start a new match.

---

## 🛠️ Technologies Used

* **C#:** The primary programming language used for all game logic.
* **.NET Framework (Windows Forms):** Used to build the graphical user interface (GUI) and manage events (like button clicks).
* **System.Media.SoundPlayer:** Used to play audio effects (.wav files) from the project's resources.
* **Enums and Structs:** Used to manage the game's state (like `enPlayers`, `enWinner`, `stGameStatus`) in a clean and readable way.

---

## 🚀 How to Run

There are two ways to run this game:

### Method 1: (Easy Way - Recommended)

You can download the ready-to-play `.exe` file directly from the **Releases** section of this repository.

1.  Go to the [**Releases**]([https://github.com/YOUR_USERNAME/YOUR_REPOSITORY/releases](https://github.com/Abdelrhman-elsaeed/TicTac-Game/releases/tag/v1.0.0)) tab.
    *(Note: Replace with your actual repository link)*
2.  Download the `.zip` file containing the game.
3.  Unzip the file and run `TicTacToe.exe`.

### Method 2: (From Source Code)

If you want to view or modify the code, you can run it from Visual Studio.

1.  Clone or download the project files.
2.  Open the solution file (`.sln`) using **Visual Studio**.
3.  Ensure the sound files (`click.wav`, `win.wav`, `Reset.wav`) are correctly included in the project's `Properties.Resources`.
4.  Press `Start` (or F5) to build and run the application.
