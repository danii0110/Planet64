using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour       //아이템에 달아 놓는 코드, 위 아래로 움직이는 효과있음
{
    public enum Type {rifle,ice,rocket}
    public Type type;

    Vector3 pos; //현재위치

    float delta = 0.14f; // 좌(우)로 이동가능한 (x)최대값

    float speed = 3.0f; // 이동속도
    void Start()
    {
        pos = transform.position;
    }

    void Update()
    {
        Vector3 v = pos;
        v.y += delta * Mathf.Sin(Time.time * speed);        //사인 특성을 사용해 방향이 바뀌어 위아래로 움직임
        transform.position = v;
    }
}
