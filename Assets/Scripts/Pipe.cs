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
        //�y�|�C���g�@�z�utransform�v�FUnity�ł�transform�Ɋւ��Ă͎擾���Ȃ��Ă��ŏ�����p�ӂ���Ă���
        //�y�|�C���g�A�z�����_�F�t���[���ɂ΂��������̂ŁA�ړ����x������ς��B
        //              ���Ώ��@�FTime.deltaTime�������邱�Ƃŏ������x�����ɂ��邱�Ƃ��ł���i���Ɉˑ����Ȃ��j
        //�@�@            Debug.Log(Time.deltaTime);
        transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
        //Debug.Log(speed);
    }
}
