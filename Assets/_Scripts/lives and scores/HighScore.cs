using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// HighScore script
/// Author: Tom Tsiliopoulos
/// Edited by: Caleb Morin (301012814)
/// Last Modified: Oct 19th 9:25~
/// Stores the high score in a seperate script so it can be saves between scenes
/// 
/// HighScore script


[System.Serializable]
public class HighScore : MonoBehaviour
{
    //Changed variable name to differenciate between high score and score, since score is used more noew
    public int highestScore;
    public int score;
    public int lives = 5;
}
