using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManger_worm : MonoBehaviour       //���� �����ϴ� �ڵ�
{
    public Transform[] spawnPoint;  //������ ����Ʈ �迭 ����
    public GameObject enemy_worm;   //������ ���� ����
    public GameObject[] child = new GameObject [3];

    public bool wormdeath = false;
    
    

    // Update is called once per frame
    void Start()            //����
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
