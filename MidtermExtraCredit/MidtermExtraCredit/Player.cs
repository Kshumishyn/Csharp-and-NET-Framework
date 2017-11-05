using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermExtraCredit
{
    class Player
    {
        // Instance Variables
        private string playerName;
        private char playerGender;
        private bool winState;
        
        // Default Constructor
        public Player()
        {
            playerName = "Michael";
            playerGender = 'M';
            winState = false;
        }

        // Full Constructor
        public Player(string name, char gender)
        {
            this.setPlayerName(name);
            this.setPlayerGender(gender);
        }

        ///////////////
        // Accessors //
        ///////////////

        // Gets Player Name
        public string getPlayerName()
        {
            return this.playerName;
        }

        // Gets Player Gender
        public char getPlayerGender()
        {
            return this.playerGender;
        }

        // Returns whether the player has won
        public bool getHasWon()
        {
            return this.winState;
        }

        //////////////
        // Mutators //
        //////////////

        // Sets Player Name
        public void setPlayerName(string name)
        {
            this.playerName = name;
        }

        // Sets Player Gender
        public void setPlayerGender(char gender)
        {
            this.playerGender = gender;
        }

        /////////////////////
        // Utility Methods //
        /////////////////////

        // Sets win state to false
        public void hasLost()
        {
            this.winState = false;
        }

        // Sets win state to true
        public void hasWon()
        {
            this.winState = true;
        }

        // Toggles Win State
        public void toggleWinState()
        {
            this.winState = !this.winState;
        }

        // Equals Method - Doesn't compare Winstates because why would it?
        public override bool Equals(object obj)
        {
            Player otherPlayer = obj as Player;
            return otherPlayer != null &&
                   this.getPlayerName() == otherPlayer.getPlayerName() &&
                   this.getPlayerGender() == otherPlayer.getPlayerGender();
        }

        // ToString Method
        public override string ToString()
        {
            // Variables
            string result;

            // Bools Default to False, so if winState is uninitialized it'll be False
            result = "Name: " + this.getPlayerName() + "\n" +
                     "Gender: " + this.getPlayerGender() + "\n";

            return result;
        }
    }
}
