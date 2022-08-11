using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour         //카메라가 플레이어 따라오게 하는 로직 
{
    public GameObject Player;
    public float offsetY = 1f;                  //오프셋 설정
    public float offsetZ = -10f;
    public float smooth = 3f;                   //부드럽게 하는 버퍼 
    
    Vector3 target;

    private void LateUpdate()
    {   //타겟 설정하고 따라가기
        target = new Vector3( Player.transform.position.x, Player.transform.position.y + offsetY, Player.transform.position.z + offsetZ);
        transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime * smooth); 
    }
}