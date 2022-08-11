using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour       //키보드로 조작하는 코드, 테스트용임
{
    private float speed = 70;

    void Update()
    {
        Vector2 position = transform.position;

        if (Input.GetKey(KeyCode.A))
        {
            position.x += -0.1f * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            position.x += +0.1f * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            position.y += +0.1f * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            position.y += -0.1f * speed * Time.deltaTime;
        }
        transform.position = position;
    }

}
