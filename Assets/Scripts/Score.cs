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
        // $"��擪�ɋL�ڂ��āA�ϐ��̂Ƃ����{}�ł�����΂悢�̂ŁA���͂��������o�ŋL�ڂł���
        scoreText.text = $"{score}";
    }

}
