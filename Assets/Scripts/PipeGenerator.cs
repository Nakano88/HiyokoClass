using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    // PipeGeneratorクラスの役割：Pipeを生成する

    // Prefabの窓口
    [SerializeField] GameObject pipePrefab;

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("関数名", 開始時間, 間隔);
        InvokeRepeating("Spawn", 2, 1); //↓2秒後に1秒間隔で生成される
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        //↓Instantiate（生成したいもの, 生成位置, 生成角度）
        //  ↓「transform.position」は当スクリプトをアタッチしたPipeGeneratorのtransform.positionのこと。

        //　① PipeGeneratorの位置を取得
        Vector3 pos = transform.position;

        //　② Y座標のみ下げて上書き
        //pos.y = -3;
        pos.y = 0;

        //Instantiate(pipePrefab, transform.position, Quaternion.identity);
        Instantiate(pipePrefab, pos, Quaternion.identity);
    }
}
