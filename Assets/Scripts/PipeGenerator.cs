using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    // PipeGenerator�N���X�̖����FPipe�𐶐�����

    // Prefab�̑���
    [SerializeField] GameObject pipePrefab;

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("�֐���", �J�n����, �Ԋu);
        //InvokeRepeating("Spawn", 2, 1); //��2�b���1�b�Ԋu�Ő��������

        StartCoroutine(Spawn());
    }

    IEnumerator Spawn() //void Spawn()
    {
        //  ���utransform.position�v�͓��X�N���v�g���A�^�b�`����PipeGenerator��transform.position�̂��ƁB
        //�@�@ PipeGenerator�̈ʒu���擾
        Vector3 pos = transform.position;

        //�@�A Y���W�̂݉����ď㏑��
        //pos.y = -3;
        pos.y = 0;

        yield return new WaitForSeconds(1f);

        while (!GameManager.isGameOver)
        {
            yield return new WaitForSeconds(1f);

            //��Instantiate�i��������������, �����ʒu, �����p�x�j
            //Instantiate(pipePrefab, transform.position, Quaternion.identity);
            Instantiate(pipePrefab, pos, Quaternion.identity);
        }
    }
}
