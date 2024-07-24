using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Duck : MonoBehaviour
{
    // ��ɓ������Fy�����̃X�s�[�h���グ��
    [SerializeField] Rigidbody2D rb2D;
    [SerializeField] float upForce;
    [SerializeField] Score score;

    // Update is called once per frame
    void Update()
    {
        if (GameManager.isGameOver)
        {
            return;
        }

        //�X�y�[�X�L�[���������Ƃ�
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2D.velocity = new Vector2(0f, upForce);
        }        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �Q�[���I�[�o�[
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
