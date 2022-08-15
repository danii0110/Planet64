using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cool_item : MonoBehaviour
{
    public GameObject bullet;

    public void apply()
    {
        Debug.Log("asdfasf");
        bullet.GetComponent<BulletAttack>().cooltime -= 0.35f;
        bullet.GetComponent<BulletAttack>().iceCooltime -= 0.07f;
        bullet.GetComponent<BulletAttack>().rifleCooltime -= 0.07f;
        bullet.GetComponent<BulletAttack>().rocketCooltime -= 0.07f;
    }

}
