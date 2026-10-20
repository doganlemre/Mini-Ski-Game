using UnityEngine;
using System;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    int score = 0;
    public void AddScore(int additionalScore)
    {
        score += additionalScore;
        scoreText.text = "Score: " + score;
    }
    
}
