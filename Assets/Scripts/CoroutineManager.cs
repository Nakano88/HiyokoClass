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
        // 1�t���[�������҂�
        //yield return null;

        // ()�b�����҂�
        yield return new WaitForSeconds(2f);

        Instantiate(apple);
    }
}
