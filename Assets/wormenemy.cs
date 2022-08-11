using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class wormenemy : MonoBehaviour      //지렁전구 코드
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
        healthBarFilled.fillAmount = 1f; 

        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.Find("Player").GetComponent<Transform>();

        follow_check = FindObjectOfType<Attack_start>();
        
    }
    private void Update()
    {
        if (currentHp <= 0)    
        {
            animator.SetInteger("state", 1);
            Invoke("Destroymon", 1.3f);
        }

        FollowTarget();
        //Vector3 target = GameObject.Find("Player").transform.position;      //따라갈 타겟 설정
        //transform.position = Vector3.MoveTowards(transform.position, target, 2f * Time.deltaTime);//따라가기
    }
    public void TakeDamage(int damage)
    {
        currentHp -= damage;        
        healthBarFilled.fillAmount = (float)currentHp / hp;
        healthBarBackground.SetActive(true); 
        StopAllCoroutines();
        StartCoroutine(WaitCoroutine());
    }

    void Destroymon()
    {
        Destroy(this.gameObject);   //오브젝트 파괴 함수
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
        yield return new WaitForSeconds(3f);
        healthBarBackground.SetActive(false);
    }
}
