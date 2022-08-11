using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockFall : MonoBehaviour
{
 
    public float rockSpeed;            //�������� �ӵ�

    void Start()
    {
 
        Invoke("DestroyRock", 2);         //2�� �� �ı���Ű�� ��
    }

    void Update()
    {
        transform.Translate(Vector3.right * -1 * Time.deltaTime * rockSpeed, Space.Self);
    }

    void DestroyRock()
    {
        Destroy(gameObject);    //�Ѿ� ����
    }

}
