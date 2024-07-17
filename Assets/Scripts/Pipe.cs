using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //【ポイント①】「transform」：Unityではtransformに関しては取得しなくても最初から用意されている
        //【ポイント②】↓問題点：フレームにばらつきがあるので、移動速度が毎回変わる。
        //              ↓対処法：Time.deltaTimeをかけることで処理速度を一定にすることができる（環境に依存しない）
        //　　            Debug.Log(Time.deltaTime);
        transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
        //Debug.Log(speed);
    }
}
