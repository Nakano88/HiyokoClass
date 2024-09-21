using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    [SerializeField] AudioSource audioSourceStart;

    // ボタンを押したらMainシーンへ移動
    public void OnStartButton()
    {

        //SceneManager.LoadScene("Main");

        // コルーチンを開始
        StartCoroutine(GameStart());

    }

    IEnumerator GameStart()
    {
        // Retry音を再生
        audioSourceStart.Play();

        // サウンドが再生し終わるのを待つ
        yield return new WaitForSeconds(audioSourceStart.clip.length);

        // Mainシーンのロード
        SceneManager.LoadScene("Main");
    }

}
