using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineManager : MonoBehaviour
{
    [SerializeField] GameObject apple;

    private void Start()
    {
        StartCoroutine(AppleGenerator());
    }

    IEnumerator AppleGenerator()
    {
        // 1フレームだけ待つ
        //yield return null;

        // ()秒だけ待つ
        yield return new WaitForSeconds(2f);

        Instantiate(apple);
    }
}
