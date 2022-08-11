using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour       //Ű����� �����ϴ� �ڵ�, �׽�Ʈ����
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
