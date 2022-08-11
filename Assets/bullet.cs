using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour     // ���⿡ ���� �Ѿ� ������Ű�� �̵� �� ���� �ð� �� �ı���Ű��  �ڵ�
{
    public float speedd;            //�Ѿ� �ӵ�
    public float distance;          //�Ÿ�, �߿�ġ ����
    public LayerMask isLayer;       //���̾��ũ   
    public float playerTr2;         //�÷��̾� ����� ������ �Ǽ��� ����

    // Start is called before the first frame update
    void Start()
    {
        JoystickPlayerExample playerTr = GameObject.Find("Player").GetComponent<JoystickPlayerExample>();
        Invoke("DestroyBullet", 2);         //2�� �� �ı���Ű�� ��
        playerTr2 = playerTr.condition;     //����� ����
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D ray = Physics2D.Raycast(transform.position, transform.right, distance,isLayer);
        if(ray.collider != null) // �浹�� �����Ǹ�
        {
            DestroyBullet();
            if (ray.collider.tag == "enemy")    //�±װ� ENEMY
            {
                ray.collider.GetComponent<enemy>().TakeDamage(1);       //�Լ� �߻�
            }
            if (ray.collider.tag == "enemy2")
            {
                ray.collider.GetComponent<wormenemy>().TakeDamage(1);
            }
        }
        //�����δ� ����ǿ� ���� �̵����� ���ϱ�, ���⸸ ���ϸ� �״�� ���� ���
        if(playerTr2 == 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speedd, Space.Self);
        }
        if(playerTr2 == 1)
        {
            transform.Translate(Vector3.right * -1 * Time.deltaTime * speedd, Space.Self);
        }
        if(playerTr2 == 2)
        {
            transform.Translate(Vector3.up * -1 * Time.deltaTime * speedd, Space.Self);
        }
        if(playerTr2 == 3)
        {
            transform.Translate(Vector3.up  * Time.deltaTime * speedd, Space.Self);
        }
    }
    void DestroyBullet()
    {
        Destroy(gameObject);    //�Ѿ� ����
    }
}
