using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WPmanager : MonoBehaviour          //���� �ݰ� �װ��� �÷��̾ �����ϴ� �ڵ�
{
    GameObject nearObject;              //�ݶ��̴��� �浹�� ������Ʈ ����
    public GameObject icePrefab;        //������ ������ ����
    public GameObject rocketPrefab;
    public GameObject riflePrefab;
    public Transform pos;               //weaponPos�� �Ҵ��� ��
    public GameObject parent;           //�θ� �ȿ� weapon�� �����ϱ� ���� �θ� ������Ʈ ����

 
    void OnTriggerEnter2D(Collider2D other)// �±׿� ���� ������ ���⸦ �����Ѵ�
    {
        
        if (other.tag == "iceWP") {
            nearObject = other.gameObject;
            Destroy(nearObject);                                // �ٴڿ� �ִ�(�浹��) ������Ʈ �ı�
            Destroy(parent.transform.GetChild(0).gameObject);   // ������ �޷��ִ� �� �ı�
            Instantiate(icePrefab, pos.position, pos.transform.rotation).transform.parent = parent.transform;
        }
        else if (other.tag == "rocketWP")
        {
            nearObject = other.gameObject;
            Destroy(nearObject);
            Destroy(parent.transform.GetChild(0).gameObject);
            Instantiate(rocketPrefab, pos.position, pos.transform.rotation).transform.parent = parent.transform;
        }
        else if(other.tag == "RifleWP")
        {
            nearObject = other.gameObject;
            Destroy(nearObject);
            Destroy(parent.transform.GetChild(0).gameObject);
            Instantiate(riflePrefab, pos.position, pos.transform.rotation).transform.parent = parent.transform;
        }
        else if(other.tag == "cool_item")
        {
            nearObject = other.gameObject;
            nearObject.GetComponent<cool_item>().apply();
            Destroy(nearObject);
        }
        else if (other.tag == "speed_item")
        {
            nearObject = other.gameObject;
            nearObject.GetComponent<speed_item>().apply();
            Destroy(nearObject);
        }

    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "weapon")
        {
            nearObject = null;           
        }
    }
}
