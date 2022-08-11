using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockFall : MonoBehaviour
{
 
    public float rockSpeed;            //떨어지는 속도

    void Start()
    {
 
        Invoke("DestroyRock", 2);         //2초 후 파괴시키게 함
    }

    void Update()
    {
        transform.Translate(Vector3.right * -1 * Time.deltaTime * rockSpeed, Space.Self);
    }

    void DestroyRock()
    {
        Destroy(gameObject);    //총알 삭제
    }

}
