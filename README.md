
# 🎮 Tic-Tac-Toe Game (C# Windows Forms)

A classic Tic-Tac-Toe (X and O) game built as a simple desktop application using C# and Windows Forms.
This project demonstrates basic event handling, UI manipulation, and game state management.

<img width="718" height="711" alt="game" src="https://github.com/user-attachments/assets/5d00b0c2-9ffc-4fd4-bd07-ef7a68a6129d" />

---

## 🚀 Features

* **Two-Player Gameplay:** Designed for two players (Player 1 'X' and Player 2 'O').
* **Turn Tracking:** Clearly displays which player's turn it is.
* **Win & Draw Detection:** Automatically detects all win conditions (horizontal, vertical, and diagonal) and a draw state (when all 9 cells are filled).
* **Sound Effects:** Includes sounds for:
    * Player moves
    * Winning the game
    * Restarting the game
* **Restart Game:** A "Restart" button to reset the board and game state for a new round.
* **Simple UI:** A clean and intuitive user interface built with standard Windows Forms controls.

---

## 🛠️ Technologies Used

* **C#**
* **.NET Framework (Windows Forms)**
* **System.Media** (for sound playback)

---

## 📂 Code Structure

* `Form1.cs`: The main form containing all the game logic.
* **`enPlayers` enum:** Manages the current player's turn (`Player1`, `Player2`).
* **`enWinner` enum:** Defines the possible game outcomes (`Player1`, `Player2`, `Draw`, `InProgress`).
* **`stGameStatus` struct:** Holds the current state of the game (Winner, GameOver, PlayCount).
* **`ChickWinner()`:** The core function that checks all 8 winning combinations by comparing the `Tag` property of the buttons.
* **`ChangeImage(Button btn)`:** The event handler for all 9 game buttons. It places an 'X' or 'O', plays a sound, and checks for a winner.
* **`RestartGame()`:** Resets the board, images, tags, and all game state variables to their default values.

---

## 💡 How to Run

Since a pre-compiled `.exe` file is available, you can easily run the game by following these steps:

**1. Go to the "Releases" Section**
On the right-hand side of this repository's main page, find the **"Releases"** section.

**2. Download the Latest Release**
Download the `.zip` file attached to the latest release (e.g., `v1.0`).

**3. Unzip and Play**
Unzip the file and run the `Tic-Tac-Toe.exe` (or similar) application.
