using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverUI;

    public static bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
        gameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            // 「Game Over」を表示する
            gameOverUI.SetActive(true);
        }
    }

    public void OnClickRetryButton()
    {
        // 現在のシーン名を取得する
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }
}
