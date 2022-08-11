using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redZone : MonoBehaviour
{
    private float Dgcount = 0;   //데미지 여부 카운터

    public SpriteRenderer MYcolor;
    
    void Start()
    {
        Invoke("DestroyRedZone", 2);         //2초 후 파괴시키게 함
        Invoke("damageTrue", 1.5f);
        Invoke("MTransparent", 0.9f);
        Invoke("MVivid", 1f);
        Invoke("MTransparent", 1.1f);
        Invoke("MVivid", 1.2f);
        Invoke("MTransparent", 1.3f);
        Invoke("MVivid", 1.4f);
        Invoke("MTransparent", 1.5f);
        Invoke("MVivid", 1.6f);
        Invoke("MTransparent", 1.7f);
        Invoke("MVivid", 1.8f);
        Invoke("MTransparent", 1.9f);


    }
    void OnTriggerStay2D(Collider2D other)
    {
 
        if (Dgcount == 1 && other.tag == "Player")
        {  
                Debug.Log("데미지입음");
                Destroy(gameObject);
        }
    }
    void damageTrue()
    {
        Dgcount = 1;
    }

    void DestroyRedZone()
    {
        Destroy(gameObject);    //레드존 삭제
    }

    void MTransparent()
    {
        MYcolor.color = new Color(255 / 255f, 0 / 255f, 0 / 255f, 120 / 255f); 
        Debug.Log("투명");
    }

    void MVivid()
    {
        MYcolor.color = new Color(0, 0, 0, 0);
        Debug.Log("불투명");
    }
}


