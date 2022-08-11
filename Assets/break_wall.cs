using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class break_wall : MonoBehaviour
{
    BoxCollider2D ObjectCollider;
    Animator redwall;
    SpawnManager enemycheck;
    SpawnManger_worm wormcheck;

    // Start is called before the first frame update
    void Start()
    {
        redwall = GetComponent<Animator>();
        enemycheck = FindObjectOfType<SpawnManager>();
        wormcheck = FindObjectOfType<SpawnManger_worm>();
        ObjectCollider = gameObject.GetComponent<BoxCollider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (enemycheck.enemydeath && wormcheck.wormdeath)
        {
            //redwall.Play("Base Layer.redWall_falling"); //Base Layer.
            redwall.SetBool("fall", true);
            ObjectCollider.isTrigger = true;

        }
    }
    // 다인: 6 주영:8
}