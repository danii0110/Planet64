using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling_Mananger : MonoBehaviour
{
    float randomX1,randomY1, randomX2, randomY2, randomX3, randomY3, randomX4, randomY4 = 0; //랜덤함수의 구역을 4개로 나누어 골고루 분포되게함
    public GameObject rock;
    public float delay = 0.5f;
    public float repeat = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("falling", delay, repeat); //x초에 x번씩 Spawnitem()를 호출한다.
    }

    // Update is called once per frame
    void falling()          //랜덤함수로 뽑고 생성
    {
        randomX1 = Random.Range(8.6f, 14f);
        randomY1 = Random.Range(33f, 39f);
        randomX2 = Random.Range(14f, 22f);
        randomY2 = Random.Range(33f, 39f);
        randomX3 = Random.Range(8.6f, 14f);
        randomY3 = Random.Range(27f, 33f);
        randomX4 = Random.Range(14f, 22f);
        randomY4 = Random.Range(27f, 33f);

        Instantiate(rock, new Vector3(randomX1, randomY1, 0f), Quaternion.identity);
        Instantiate(rock, new Vector3(randomX2, randomY2, 0f), Quaternion.identity);
        Instantiate(rock, new Vector3(randomX3, randomY3, 0f), Quaternion.identity);
        Instantiate(rock, new Vector3(randomX4, randomY4, 0f), Quaternion.identity);
        Debug.Log("떨어진다");
    }
}
