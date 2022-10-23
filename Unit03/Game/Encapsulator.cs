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
        ///It recieves
        ///</summary>
        public string setcharacter(){
            
            return character;

        }
         public void getword(string charac){
            word = charac;
            
        }
        


        ///<summary>
        ///It recieves
        ///</summary>
        public string setword(){
            
            return word;

        }
        
    }
}