using System;


namespace Unit04.Game.Casting
{
    ///<summary>
    ///It keeps track of the user's score.
    ///</summary>
    public class Score{
        private int score = 0;
        

        ///<summary>
        ///It keeps track of the user's score.
        ///</summary>
        public void SetScore(int user_score){
            this.score =user_score;
        }

        ///<summary>
        ///It keeps track of the user's score.
        ///</summary>
        public int GetScore(){
            return score;
        }
    }
}