using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // 上に動かす：y方向のスピードを上げる
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
        //スペースキーを押したとき
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
            Debug.Log("ぶつかったよ（残りHP：" + hiyokoHP + "）");
        }
        else
        {
            Debug.Log("ゲームオーバー");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        point += 10;
        Debug.Log("ポイントゲット！（現在：" + point + "点）");
    }
}
