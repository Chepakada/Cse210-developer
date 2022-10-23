using System.Collections.Generic;
using System;
namespace Jumper
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        private Algorithms _hider = new Algorithms();
        private bool _isPlaying = true;
        private Encapsulator _seeker = new Encapsulator();
        private TerminalService _terminalService = new TerminalService();
        private string word="";
        private string character="";
        private List<string> wordslist = new List<string>();

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            System.Console.WriteLine(word);
          string  wordx = word_generator();
          word = wordx.Remove(wordx.Length-1);
          //_terminalService.WriteText(word);
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
                
        }
        }
         public string word_generator(){
            string list = System.IO.File.ReadAllText(@".\words.txt");
            string[] a= list.Split("\n");
            wordslist.AddRange(a);
            
            Random wordpool = new Random( );
            int index = wordpool.Next(wordslist.Count);
            string wordx = wordslist[index];
             
            return wordx;
        }


        /// <summary>
        /// Moves the seeker to a new location.
        /// </summary>
        private void GetInputs()
        {
            //_terminalService.WriteText(_hider.Display.ToString());
            // int location = _terminalService.ReadNumber("\nEnter a location [1-1000]: ");
             
            _seeker.getword(word);
           _hider.Display(_seeker);
            character = _terminalService.ReadText("Enter your guess letter. ");
            
            
        }

        // /// <summary>
        // /// Keeps watch on where the seeker is moving.
        // /// </summary>
        private void DoUpdates()
        {
            
            _seeker.getcharacter(character);
            _hider.game_runner(_seeker);
        }

        /// <summary>
        /// Provides a hint for the seeker to use.
        /// </summary>
        private void DoOutputs()
        {
            
            if (_hider.Game_ender(_seeker))
            {
                _isPlaying = false;

            }
            else{
                _isPlaying= true;
            }
            
        }
    }
}
