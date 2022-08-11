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
    private void OnTriggerEnter2D(Collider2D collision) //오브젝트간 충돌이 일어날때 처음 한번만 호출되는 함수.
    {
        if (collision.tag == "enemyFollow")
        {
            follow = true;
        }
    }
}
