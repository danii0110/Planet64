using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour           // 몬스터 스폰하는 코드, 아캔몬
{
    public Transform[] spawnPoints;
    public GameObject enemy;
    public int size;

    public GameObject[] child = new GameObject[3];
    public bool enemydeath = false;
    

    // Update is called once per frame
    void Start()
    {
       for(int i=0;i<size;i++)
        Instantiate(enemy, spawnPoints[i]);
    }

    private void Update()
    {
        int sum = 0;

        for (int i = 0; i < 3; i++)
        {
            sum += child[i].transform.childCount;
        }
        if (sum == 0)
        {
            enemydeath = true;
        }
    }
}
