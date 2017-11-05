using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermExtraCredit
{
    class Game
    {
        // Constants
        public const int MAX_PLAYERS = 4;

        // Instance Variables
        private string gameName;
        private int numPlayers;
        private Player[] listOfPlayers = new Player[MAX_PLAYERS];
        bool gameState;

        // Default Constructor
        public Game()
        {
            this.setGameName("Game");
            this.setNumPlayers(1);

            Player tempPlayer = new Player();
            this.listOfPlayers[0] = tempPlayer;

            this.gameStart();
        }

        // Partial Constructor
        public Game (string gameName, int numPlayers)
        {
            this.setGameName(gameName);
            this.setNumPlayers(numPlayers);

            for (int i = 0; i < getNumPlayers(); i++)
            {
                Console.Write("Please Enter Player #" + (i + 1) + "'s Name: ");
                string tempName = Console.ReadLine();

                Console.Write("Please Enter Player #" + (i + 1) + "'s Gender (M/F): ");
                char tempGender = Convert.ToChar(Console.ReadLine());

                Player tempPlayer = new Player(tempName, tempGender);

                this.listOfPlayers[i] = tempPlayer;
            }

            this.gameStart();
        }

        // Full Constructor
        public Game (string gameName, int numPlayers, Player[] playerList)
        {
            this.setGameName(gameName);

            // Doesn't use numPlayers just in case user might mismatch number of players
            // in the list and the number of players they think is there
            this.setNumPlayers(playerList.Length);

            for(int i = 0; i < playerList.Length; i++)
            {
                this.listOfPlayers[i] = playerList[i];
            }

            this.gameStart();
        }

        ///////////////
        // Accessors //
        ///////////////

        // Gets Game Name
        public string getGameName()
        {
            return this.gameName;
        }

        // Gets Num Players
        public int getNumPlayers()
        {
            return this.numPlayers;
        }

        // Gets Player List
        public Player[] getPlayerList()
        {
            return this.listOfPlayers;
        }

        // Gets Game State
        public bool getGameState()
        {
            return this.gameState;
        }

        //////////////
        // Mutators //
        //////////////

        // Sets Game Name
        public void setGameName(string gameName)
        {
            this.gameName = gameName;
        }

        // Sets Player Name
        public void setNumPlayers(int numPlayers)
        {
            // Error Checks for valid Max Value
            do
            {
                if (numPlayers > MAX_PLAYERS || numPlayers < 0)
                {
                    Console.Write("INVALID NUMBER OF PLAYERS, PLEASE ENTER VALID NUMBER: ");
                    numPlayers = Convert.ToInt32(Console.ReadLine());
                }

            } while (numPlayers > MAX_PLAYERS || numPlayers < 0);

            // Sets Error Checked Value
            this.numPlayers = numPlayers;
        }

        /////////////////////
        // Utility Methods //
        /////////////////////
        
        // Sets Game state to false
        public void gameOver()
        {
            this.gameState = false;
        }

        // Sets Game state to true
        public void gameStart()
        {
            this.gameState = true;
        }

        // Toggles Game State
        public void toggleGameState()
        {
            this.gameState = !this.gameState;
        }

        // Print Player List
        public string playerListString()
        {
            // Initializes return string
            string result = "";

            for (int i = 0; i < this.getNumPlayers(); i++)
            {
                string playerString = "\nPlayer #" + (i + 1) + "\n" + this.listOfPlayers[i].ToString();
                result += playerString;
            }

            return result;
        }

        // Equals Method - Doesn't compare Arrays for simplicity's sake
        public override bool Equals(object obj)
        {
            Game otherGame = obj as Game;
            return otherGame != null &&
                   this.getGameName() == otherGame.getGameName() &&
                   this.getNumPlayers() == otherGame.getNumPlayers();
        }

        // ToString Method
        public override string ToString()
        {
            // Variables
            string result;

            // Bools Default to False, so if winState is uninitialized it'll be False
            result = "Game Name: " + this.getGameName() + "\n" +
                     "Num Players: " + this.getNumPlayers() + "\n" +
                     "Game has Started: " + this.getGameState() + "\n\n\n";

            result += playerListString();

            return result;
        }
    }
}
