using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManger_worm : MonoBehaviour       //몬스터 스폰하는 코드
{
    public Transform[] spawnPoint;  //스폰할 포인트 배열 선언
    public GameObject enemy_worm;   //스폰할 몬스터 선언
    public GameObject[] child = new GameObject [3];

    public bool wormdeath = false;
    
    

    // Update is called once per frame
    void Start()            //생성
    {
        Instantiate(enemy_worm, spawnPoint[0]);
        //Instantiate(enemy_worm, spawnPoint[1]);
        //Instantiate(enemy_worm, spawnPoint[2]);
    }

    private void Update()
    {
        int sum = 0;

        for (int i = 0; i <3; i++)
        {
            sum += child[i].transform.childCount;
        }
        if(sum == 0)
        {           
            wormdeath = true;
        }
    }
}
