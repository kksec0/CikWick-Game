using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
   public int score = 0;
   public TMP_Text scoreText;
   
   
   public void AddScore()
    {

        score += 1;
        scoreText.text = "Skor: " + score;
        Debug.Log("Skor: " + score);
        
    }

}
