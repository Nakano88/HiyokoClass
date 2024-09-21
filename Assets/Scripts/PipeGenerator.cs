using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    // PipeGenerator�N���X�̖����FPipe�𐶐�����

    // Prefab�̑���
    [SerializeField] GameObject pipePrefab;

    //[SerializeField] SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        // ���̃I�u�W�F�N�g��Renderer�R���|�[�l���g���擾
        //spriteRenderer = GetComponent<SpriteRenderer>();

        //InvokeRepeating("�֐���", �J�n����, �Ԋu);
        //InvokeRepeating("Spawn", 2, 1); //��2�b���1�b�Ԋu�Ő��������

        StartCoroutine(Spawn());
    }

    IEnumerator Spawn() //void Spawn()
    {
        int pipeCount = 0;

        //  ���utransform.position�v�͓��X�N���v�g���A�^�b�`����PipeGenerator��transform.position�̂��ƁB
        //�@�@ PipeGenerator�̈ʒu���擾
        Vector3 pos = transform.position;

        //�@�A Y���W�̂݉����ď㏑��
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
                // �p�C�v�̍����������_���ɃZ�b�g
                pos.y = Random.Range(-0.5f, 1.3f); // int�^����4�͊܂܂�Ȃ��i-3�`3�͈̔́j�Bfloat�^����4�܂Ŋ܂܂��BRandom.Range(-3f,4f)

                // �}�e���A���̐F��ύX
                //spriteRenderer.color = Color.blue;
            }
            else if (pipeCount < 10)
            {
                // �p�C�v�̍����������_���ɃZ�b�g
                pos.y = Random.Range(-1f, 1.4f);

                // �}�e���A���̐F��ύX
                //spriteRenderer.color = Color.red;
            }
            else
            {
                // �p�C�v�̍����������_���ɃZ�b�g
                pos.y = Random.Range(-1.5f, 1.8f);
            }

            //��Instantiate�i��������������, �����ʒu, �����p�x�j
            //Instantiate(pipePrefab, transform.position, Quaternion.identity);
            Instantiate(pipePrefab, pos, Quaternion.identity);

            pipeCount++;
        }
    }
}
