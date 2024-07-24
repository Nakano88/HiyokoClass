using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text scoreText;
    int score;

    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
    }

    public void AddScore()
    {
        score += 10;
        //scoreText.text = score.ToString();
        // $"を先頭に記載して、変数のところは{}でくくればよいので、文章を書く感覚で記載できる
        scoreText.text = $"{score}";
    }

}
