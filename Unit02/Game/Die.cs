using System;


namespace Unit02.Game
{
    // TODO: Implement the Die class as follows...
    // 1) Add the class declaration. Use the following class comment.

        /// <summary>
        /// A small cube with a different number of spots on each of its six sides.
        /// 
        /// The responsibility of Die is to keep track of its currently rolled value and the points its
        /// worth.
        /// </summary> 
    public class Die
    {
        public int dieScore;
        public int dieValue;

    // 2) Create the class constructor (function). Use the following method comment.

        /// <summary>
        /// Constructs a new instance of Die.
        /// </summary>
        public Die() 
        {
            
            dieValue = 2;
            dieScore = 0;
        }

    // 3) Create the Roll() method. Use the following method comment.
        
        /// <summary>
        /// Generates a new random value and calculates the points for the die. Fives are 
        /// worth 50 points, ones are worth 100 points, everything else is worth 0 points.
        /// </summary>
        public void Roll()
        {
            Random rand = new Random();
            dieValue = rand.Next(1,7);

            /*
            if (dieValue == 1)
            else if (dieValue == 5)
            else
            */
            /// <summary>
            /// diePoints = (dieValue == 1) ? 100 : (dieValue == 5) ? 50 : 0
            /// </summary>
            
            if (dieValue == 1 || dieValue == 5)
            {
                if (dieValue == 1)
                {
                    dieScore = 100;
                }
                else
                {
                    dieScore = 50;
                }
            }
            else 
            {
                dieScore = 0;
            }
            
        }
    }
}