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
            // �uGame Over�v��\������
            gameOverUI.SetActive(true);

            // GameOver�����Đ�
            if (soundFlg == false)
            {
                audioSourceGameOver.PlayOneShot(audioSourceGameOver.clip);
                soundFlg = true;
            }
        }
    }

    public void OnClickRetryButton()
    {
        // �R���[�`�����J�n
        StartCoroutine(Retry());
    }

    IEnumerator Retry()
    {
        // Retry�����Đ�
        audioSourceRetry.Play();

        // �T�E���h���Đ����I���̂�҂�
        yield return new WaitForSeconds(audioSourceRetry.clip.length);

        // �V�[���̃����[�h
        // ���݂̃V�[�������擾����
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }
}
