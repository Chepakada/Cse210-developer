namespace Jumper{

    public class Encapsulator
    {   
        private string character= "";
        private string word = "";


        public Encapsulator(){

        }
        ///<summary>
        ///It recieves
        ///</summary>
        public void getcharacter(string charac){
            character = charac;
            
        }



        ///<summary>
        ///It recieves the character the user input as guess.
        ///</summary>
        public string setcharacter(){
            
            return character;

        }
        ///<summary>   
        ///   It gets 
        ///   
         public void getword(string charac){
            word = charac;
            
        }
        


        ///<summary>
        ///It recieves word that was create as the challange
        ///</summary>
        public string setword(){
            
            return word;

        }
        
    }
}