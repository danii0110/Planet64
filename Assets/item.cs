using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour       //�����ۿ� �޾� ���� �ڵ�, �� �Ʒ��� �����̴� ȿ������
{
    public enum Type {rifle,ice,rocket}
    public Type type;

    Vector3 pos; //������ġ

    float delta = 0.14f; // ��(��)�� �̵������� (x)�ִ밪

    float speed = 3.0f; // �̵��ӵ�
    void Start()
    {
        pos = transform.position;
    }

    void Update()
    {
        Vector3 v = pos;
        v.y += delta * Mathf.Sin(Time.time * speed);        //���� Ư���� ����� ������ �ٲ�� ���Ʒ��� ������
        transform.position = v;
    }
}
