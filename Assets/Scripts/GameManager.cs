using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverUI;

    [SerializeField] AudioSource audioSourceBGM;
    [SerializeField] AudioSource audioSourceGameOver;
    [SerializeField] AudioSource audioSourceRetry;

    public static bool isGameOver;
    private bool soundFlg = false;

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

            // GameOver音を再生
            if (soundFlg == false)
            {
                audioSourceGameOver.PlayOneShot(audioSourceGameOver.clip);
                soundFlg = true;
            }
        }
    }

    public void OnClickRetryButton()
    {
        // コルーチンを開始
        StartCoroutine(Retry());
    }

    IEnumerator Retry()
    {
        // Retry音を再生
        audioSourceRetry.Play();

        // サウンドが再生し終わるのを待つ
        yield return new WaitForSeconds(audioSourceRetry.clip.length);

        // シーンのリロード
        // 現在のシーン名を取得する
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }
}
