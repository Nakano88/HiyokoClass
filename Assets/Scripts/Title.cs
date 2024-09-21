using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    [SerializeField] AudioSource audioSourceStart;

    // �{�^������������Main�V�[���ֈړ�
    public void OnStartButton()
    {

        //SceneManager.LoadScene("Main");

        // �R���[�`�����J�n
        StartCoroutine(GameStart());

    }

    IEnumerator GameStart()
    {
        // Retry�����Đ�
        audioSourceStart.Play();

        // �T�E���h���Đ����I���̂�҂�
        yield return new WaitForSeconds(audioSourceStart.clip.length);

        // Main�V�[���̃��[�h
        SceneManager.LoadScene("Main");
    }

}
