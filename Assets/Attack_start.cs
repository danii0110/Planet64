using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_start : MonoBehaviour
{
    public bool follow = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision) //������Ʈ�� �浹�� �Ͼ�� ó�� �ѹ��� ȣ��Ǵ� �Լ�.
    {
        if (collision.tag == "enemyFollow")
        {
            follow = true;
        }
    }
}
