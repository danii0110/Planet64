using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour      //조이스틱이 움직임에 따라 애니메이션, 총알,무기 포지션 바꾸는 코드
{
    public float speed;         //플레이어 오브젝트가 움직일 속도
    public DynamicJoystick variableJoystick;        // 다이내믹 조이스틱 변수 선언
    public Rigidbody2D rb;                          // 리지드바디 할당
    private Animator animator;                      // 애니메이터 할당
    public float condition = 0;                     // 컨디션, 상하좌우를 판단하는 기준
    public GameObject wppos;                        // 무기 포지션
    public GameObject btpos;                        // 총알 포지션

    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    public void FixedUpdate()
    {
        //리지드 바디에 일정 충격을 주어 앞으로 나아가게 함,; 무중력 컨셉에 잘맞아서 채택
        Vector3 direction = Vector3.right * variableJoystick.Horizontal + Vector3.up * variableJoystick.Vertical;
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode2D.Force );
        

        if (variableJoystick.Horizontal >0 && variableJoystick.Horizontal >= Mathf.Abs(variableJoystick.Vertical))
        {
            //오른쪽보기
            animator.SetInteger("updown", 0);
            condition = 0;// 컨디션 설정
            //디자인상 캐릭터의 총 위치도 바뀌니 총,총알 포지션도 바꿔줘야함
            wppos.transform.localPosition = new Vector2(0.9f, 0); 
            wppos.transform.localRotation = Quaternion.Euler(0, 0, 0);
            btpos.transform.localPosition = new Vector2(1.08f, 0.33f);
        }

        if (variableJoystick.Horizontal < 0 && Mathf.Abs(variableJoystick.Horizontal) >= Mathf.Abs(variableJoystick.Vertical))
        {
            //왼쪽보기
            animator.SetInteger("updown", 3);
            condition = 1;
            wppos.transform.localPosition = new Vector2(-1, 0);
            wppos.transform.localRotation = Quaternion.Euler(0, 180, 0);
            btpos.transform.localPosition = new Vector2(-0.78f, 0.33f);
        }

        if (variableJoystick.Vertical < 0 && Mathf.Abs(variableJoystick.Vertical) >= Mathf.Abs(variableJoystick.Horizontal))
        {
            //아래보기
            animator.SetInteger("updown", 2);
            condition = 2;
            wppos.transform.localPosition = new Vector2(0.57f, -0.4f);
            wppos.transform.localRotation = Quaternion.Euler(0, -303, 270);
            btpos.transform.localPosition = new Vector2(0.76f, -0.7f);
        }
        if (variableJoystick.Vertical > 0 && variableJoystick.Vertical >= Mathf.Abs(variableJoystick.Horizontal))
        {
            //위에보기
            animator.SetInteger("updown", 1);
            condition = 3;
            wppos.transform.localPosition = new Vector2(-0.67f, 0.5f);
            wppos.transform.localRotation = Quaternion.Euler(0, 65, 90);
            btpos.transform.localPosition = new Vector2(-0.78f, 0.33f);
        }

    }
}