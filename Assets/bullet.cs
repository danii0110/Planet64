using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour     // 방향에 따라 총알 생성시키고 이동 후 일정 시간 후 파괴시키는  코드
{
    public float speedd;            //총알 속도
    public float distance;          //거리, 중요치 않음
    public LayerMask isLayer;       //레이어마스크   
    public float playerTr2;         //플레이어 컨디션 저장할 실수형 변수

    // Start is called before the first frame update
    void Start()
    {
        JoystickPlayerExample playerTr = GameObject.Find("Player").GetComponent<JoystickPlayerExample>();
        Invoke("DestroyBullet", 2);         //2초 후 파괴시키게 함
        playerTr2 = playerTr.condition;     //컨디션 저장
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D ray = Physics2D.Raycast(transform.position, transform.right, distance,isLayer);
        if(ray.collider != null) // 충돌이 감지되면
        {
            DestroyBullet();
            if (ray.collider.tag == "enemy")    //태그가 ENEMY
            {
                ray.collider.GetComponent<enemy>().TakeDamage(1);       //함수 발생
            }
            if (ray.collider.tag == "enemy2")
            {
                ray.collider.GetComponent<wormenemy>().TakeDamage(1);
            }
        }
        //밑으로는 컨디션에 따른 이동방향 정하기, 방향만 정하면 그대로 직선 운동함
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
        Destroy(gameObject);    //총알 삭제
    }
}
