using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Duck : MonoBehaviour
{
    // 上に動かす：y方向のスピードを上げる
    [SerializeField] Rigidbody2D rb2D;
    [SerializeField] float upForce;
    [SerializeField] Score score;
    [SerializeField] AudioSource audioSource_Jump;
    [SerializeField] AudioSource audioSource_Clash;
    [SerializeField] AudioSource audioSource_Fell;

    // Update is called once per frame
    void Update()
    {
        if (GameManager.isGameOver)
        {
            return;
        }

        //スペースキーを押したとき
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2D.velocity = new Vector2(0f, upForce);

            //Jumpの音
            audioSource_Jump.PlayOneShot(audioSource_Jump.clip);
        }

        // 落ちたらゲームオーバー
        if (transform.position.y < -2.5f)
        {

            //落ちた音
            audioSource_Fell.PlayOneShot(audioSource_Fell.clip);

            // ゲームオーバー
            GameManager.isGameOver = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //衝突の音
        audioSource_Clash.PlayOneShot(audioSource_Clash.clip);

        // ゲームオーバー
        GameManager.isGameOver = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameManager.isGameOver)
        {
            return;
        }

        score.AddScore();
    }
}
