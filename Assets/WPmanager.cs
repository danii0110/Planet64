using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WPmanager : MonoBehaviour          //무기 줍고 그것을 플레이어에 장착하는 코드
{
    GameObject nearObject;              //콜라이더에 충돌한 오브젝트 저장
    public GameObject icePrefab;        //프리팹 가져올 변수
    public GameObject rocketPrefab;
    public GameObject riflePrefab;
    public Transform pos;               //weaponPos를 할당할 곳
    public GameObject parent;           //부모 안에 weapon을 생성하기 위해 부모 오브젝트 선언

 
    void OnTriggerEnter2D(Collider2D other)// 태그에 따라 각각의 무기를 장착한다
    {
        
        if (other.tag == "iceWP") {
            nearObject = other.gameObject;
            Destroy(nearObject);                                // 바닥에 있던(충돌한) 오브젝트 파괴
            Destroy(parent.transform.GetChild(0).gameObject);   // 기존에 달려있던 것 파괴
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
