using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // ��ɓ������Fy�����̃X�s�[�h���グ��
    [SerializeField] Rigidbody2D rb2D;
    public int hiyokoHP = 100;
    public int point = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�X�y�[�X�L�[���������Ƃ�
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2D.velocity = new Vector2(0f,5f);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        hiyokoHP -= 10;
        if (hiyokoHP > 0)
        {
            Debug.Log("�Ԃ�������i�c��HP�F" + hiyokoHP + "�j");
        }
        else
        {
            Debug.Log("�Q�[���I�[�o�[");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        point += 10;
        Debug.Log("�|�C���g�Q�b�g�I�i���݁F" + point + "�_�j");
    }
}
