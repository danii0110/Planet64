using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAttack : MonoBehaviour
{
    public GameObject bullet;
    public GameObject iceBullet;
    public GameObject rocketBullet;
    public Transform pos;

    public float cooltime;
    public float iceCooltime;
    public float rifleCooltime;
    public float rocketCooltime;

    private float curtime;

    public GameObject parent;           //부모 안에 weapon이 무엇인지 알아내기 위함

    Quaternion ice1 = Quaternion.Euler(0, 0, 30);         // 총알을 3개 발사하므로 각도가 틀어진 나머지 두개 총알의 각도 지정해줌
    Quaternion ice3 = Quaternion.Euler(0, 0, -30);

    // Update is called once per frame
    void Update()
    {
        if (parent.transform.GetChild(0).gameObject.tag == "iceWP")
        {
            iceWP();
        }

        else if (parent.transform.GetChild(0).gameObject.tag == "RifleWP")
        {
            rifleWP();
        }
        else if (parent.transform.GetChild(0).gameObject.tag == "rocketWP")
        {
            rocketWP();
        }
        else
            nomalWP();
    }

    void nomalWP()
    {
        if (curtime <= 0)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Instantiate(bullet, pos.position, transform.rotation);
                curtime = cooltime;
            }

        }
        curtime -= Time.deltaTime;


    }

    void iceWP()
    {
        if (curtime <= 0)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Instantiate(iceBullet, pos.position, transform.rotation);
                Instantiate(iceBullet, pos.position, ice1);                 //총알 3개 발싸
                Instantiate(iceBullet, pos.position, ice3);

                curtime = cooltime;
            }

        }
        curtime -= Time.deltaTime;

    }

    void rifleWP()
    {
        if (curtime <= 0)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Instantiate(bullet, pos.position, transform.rotation);
                curtime = rifleCooltime;
            }

        }
        curtime -= Time.deltaTime;

    }

    void rocketWP()
    {
        if (curtime <= 0)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Instantiate(rocketBullet, pos.position, transform.rotation);
                curtime = cooltime;
            }

        }
        curtime -= Time.deltaTime;

    }
}
