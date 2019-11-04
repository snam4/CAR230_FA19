using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _19CoinScoreUI : MonoBehaviour
{
    public Text ScoreText;
    public int score;

    void Update()
    {
        ScoreText.text = "SCORE : " + score;
    }
}
