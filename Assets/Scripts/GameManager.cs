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
            // �uGame Over�v��\������
            gameOverUI.SetActive(true);
        }
    }

    public void OnClickRetryButton()
    {
        // ���݂̃V�[�������擾����
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }
}
