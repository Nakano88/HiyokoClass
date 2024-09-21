using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    // PipeGeneratorクラスの役割：Pipeを生成する

    // Prefabの窓口
    [SerializeField] GameObject pipePrefab;

    //[SerializeField] SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        // このオブジェクトのRendererコンポーネントを取得
        //spriteRenderer = GetComponent<SpriteRenderer>();

        //InvokeRepeating("関数名", 開始時間, 間隔);
        //InvokeRepeating("Spawn", 2, 1); //↓2秒後に1秒間隔で生成される

        StartCoroutine(Spawn());
    }

    IEnumerator Spawn() //void Spawn()
    {
        int pipeCount = 0;

        //  ↓「transform.position」は当スクリプトをアタッチしたPipeGeneratorのtransform.positionのこと。
        //　① PipeGeneratorの位置を取得
        Vector3 pos = transform.position;

        //　② Y座標のみ下げて上書き
        //pos.y = -3;

        yield return new WaitForSeconds(1f);

        while (!GameManager.isGameOver)
        {
            yield return new WaitForSeconds(2f);

            if (pipeCount == 0)
            {
                pos.y = 0;
            }
            else if(pipeCount < 5)
            {
                // パイプの高さをランダムにセット
                pos.y = Random.Range(-0.5f, 1.3f); // int型だと4は含まれない（-3～3の範囲）。float型だと4まで含まれる。Random.Range(-3f,4f)

                // マテリアルの色を変更
                //spriteRenderer.color = Color.blue;
            }
            else if (pipeCount < 10)
            {
                // パイプの高さをランダムにセット
                pos.y = Random.Range(-1f, 1.4f);

                // マテリアルの色を変更
                //spriteRenderer.color = Color.red;
            }
            else
            {
                // パイプの高さをランダムにセット
                pos.y = Random.Range(-1.5f, 1.8f);
            }

            //↓Instantiate（生成したいもの, 生成位置, 生成角度）
            //Instantiate(pipePrefab, transform.position, Quaternion.identity);
            Instantiate(pipePrefab, pos, Quaternion.identity);

            pipeCount++;
        }
    }
}
