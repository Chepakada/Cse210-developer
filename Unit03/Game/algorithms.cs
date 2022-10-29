
using System.Collections.Generic;
using System;
namespace Jumper{

    public class Algorithms
    {
        private TerminalService _terminalService = new TerminalService();
        //private Encapsulator _encapsulator = new Encapsulator();

        private string _changingLetter= "";
        private List<string> wordslist= new List<string>();
        //private List<char> wordlist = new List<char>();
        //private string words = "";
        private List<int> _wordindeces = new List<int>();
        private List<string> _wordsPrint = new List<string>(); 
        private string[] characters = {" ___", "/___\\", "\\   /"," \\ /",  "  o", " /|\\", " / \\" };
        private List<string> _parachute = new List<string>();
        


        public Algorithms(){

        }

        // public string word_generator(){
        //     string list = System.IO.File.ReadAllText(@".\words.txt");
        //     string[] a= list.Split("\n");
        //     wordslist.AddRange(a);
            
        //     Random wordpool = new Random( );
        //     int index = wordpool.Next(wordslist.Count);
        //     string word = wordslist[index];
             
        //     return word;
        // }


        ///<summary>
        ///It creates a list for words and the display screen
        ///</summary>
        public void word_manager(string words){
            
           
            if (_changingLetter==""){
            _parachute.AddRange(characters);
            
            int length = words.Length;
            
            int i = 0;
            if (_changingLetter==""){
            while ((i)<length){
;
                _wordsPrint.Add("_");
                i +=1;
            }
            }
        }}

        ///<summary>
        ///It finds out where the indices of given character are in the word.
        ///</summary>
        private List<int> index_generator(string words){ 
            
            int index = 0;
            _wordindeces.Clear();
            while (index !=-1){
                index= words.IndexOf(_changingLetter, index);
                //_terminalService.WriteText($"{index}");
                if (index!=-1){
                    _wordindeces.Add(index);
                    index ++;
                    
                }
            }
            
            return _wordindeces;

            
        }

        ///<summary>
        ///it makes the changes in parachute and the hint
        ///</summary>
        public void game_runner(Encapsulator _encapsulator){
            _changingLetter= _encapsulator.setcharacter();
            string words = _encapsulator.setword();
            
            
            
            
            bool x = (words.Contains(_changingLetter));
            
            
            _wordindeces = index_generator(words);
            
            if (_wordindeces.Count<1)
            {
                
                _parachute.RemoveAt(0);
                }
             
            
            else{
                foreach (int param in _wordindeces){
                        //_terminalService.WriteText($"{_wordindeces.Count}");
                            int _intposition = Convert.ToInt32(param);
                        _wordsPrint[_intposition]= _changingLetter;
            }
            
            
            }
        }

        
        
        ///<summary>
        ///It goes through the list for map and prints them
        ///</summary>
        public void Display(Encapsulator _encapsulator){
            string word = _encapsulator.setword();
            word_manager(word);
            foreach(string param in _wordsPrint){
            _terminalService.WriteTextInline(param +" ");
            }
            _terminalService.WriteText("");
            _terminalService.WriteText("");
            
            foreach(string param in _parachute){
                _terminalService.WriteText(param);
            }
            _terminalService.WriteText("");
            _terminalService.WriteText("^^^^^^");


        }


        ///<summary>
        ///It checks if the user has used all his chances or has won the game.
        ///</summary>
        public bool Game_ender(Encapsulator _encapsulator){
            string words = _encapsulator.setword();
            
            string combinedString = string.Join( "", _wordsPrint);
            //_terminalService.WriteText(combinedString);
            if (_parachute.Count>4){
                
            bool result = (combinedString==words);
                if (result== true){
                    _terminalService.WriteText("YOU WON!");
                }
            return result;}
            else if(_parachute.Count< 4) {
                _terminalService.WriteText("GAME IS OVER");
                _terminalService.WriteText(words);
                _parachute[0]= "  x";
                foreach( string param in _parachute){
                    _terminalService.WriteText(param);
                    
                }
                
                return true;
            }
            else{
                return false;
            }
        }
    }
}
    
