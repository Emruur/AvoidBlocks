using System.Collections;
using System.Collections.Generic;


public static class Difficulty
{
    // Start is called before the first frame update
    public static int maxDifficulty= 30;
    public static int currentDifficulty= 0;

    public static float getCurrentPercentage(){
        if(currentDifficulty>= maxDifficulty){
            return 1;
        }

        return (float)currentDifficulty/maxDifficulty;
    }

    public static void incrementDifficulty(){
           currentDifficulty++; 
         
    }

    public static int getScore(){
        return currentDifficulty;
    }

    public static  void resetDifficulty(){
        currentDifficulty= 0;
    }
}
