using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{
    //i wanna know the score!
    public int highScore;
    public Text PointsText;
    public Text HighScoreText;
    public Text MultiplierText;

    void Start()
    {        
        //get the previous high score and set the current score and multiplier to default.
        highScore = PlayerPrefs.GetInt("highscore");
        PointsText.text = "Points: " + 0;
        HighScoreText.text = "High Score: " + highScore;
        MultiplierText.text = "Bonus   X   " + 0;
    }


    // Update is called once per frame
    void Update()
    {
        //display the score, highscore, and multiplier on the HUD, and if the high score is bigger, that is now the high score.
        if (addPointsToText.currentPoints > highScore)
        {
            highScore = addPointsToText.currentPoints;
            HighScoreText.text = "High Score: " + highScore;
        }
        PlayerPrefs.SetInt("highscore", highScore);
        PointsText.text = "points: " + addPointsToText.currentPoints;
        MultiplierText.text = "Bonus   X   " + addPointsToText.scoreMultiplier;
    }
}
