using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour         //ī�޶� �÷��̾� ������� �ϴ� ���� 
{
    public GameObject Player;
    public float offsetY = 1f;                  //������ ����
    public float offsetZ = -10f;
    public float smooth = 3f;                   //�ε巴�� �ϴ� ���� 
    
    Vector3 target;

    private void LateUpdate()
    {   //Ÿ�� �����ϰ� ���󰡱�
        target = new Vector3( Player.transform.position.x, Player.transform.position.y + offsetY, Player.transform.position.z + offsetZ);
        transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime * smooth); 
    }
}