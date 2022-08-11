using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class enemy : MonoBehaviour              // 아캔몬에 달 코드, wormenemy 코드 참고
{
    public int hp; 
    public int currentHp;
    private Animator animator;

    public GameObject healthBarBackground;
    public Image healthBarFilled;

    Rigidbody2D rb;
    Transform target;


    Attack_start follow_check;

    private void Start()
    {
        currentHp = hp;
        healthBarFilled.fillAmount = 1f; //기본체력

        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.Find("Player").GetComponent<Transform>();

        follow_check = FindObjectOfType<Attack_start>();
        

    }
    private void Update()
    {
        if(currentHp <= 0)
        {          
            animator.SetInteger("state", 1);
            Invoke("Destroymon", 0.667f);
        }

        FollowTarget();

        //Vector3 target = GameObject.Find("Player").transform.position;
        //transform.position = Vector3.MoveTowards(transform.position, target, 2f*Time.deltaTime);

    }
    public void TakeDamage(int damage)
    {
        currentHp -= damage;
        healthBarFilled.fillAmount = (float)currentHp / hp;
        healthBarBackground.SetActive(true); //보이도록 활성화
        StopAllCoroutines(); // 때릴 때마다 기존에 돌아가고 있던 코루틴을 멈춤
        StartCoroutine(WaitCoroutine()); 
    }

    void Destroymon()
    {
        Destroy(this.gameObject);
    }

    void FollowTarget()
    {
        if (follow_check.follow)
        {
            
            transform.position = Vector2.MoveTowards(transform.position, target.position, 2f * Time.deltaTime);
        }
        
    }
    IEnumerator WaitCoroutine() 
    {
        yield return new WaitForSeconds(3f); //3초 동안 공격이 없으면 hpBar 다시 안보임
        healthBarBackground.SetActive(false);
    }
}
