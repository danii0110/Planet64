using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed_item : MonoBehaviour
{
    public GameObject player;
    public void apply()
    {
        Debug.Log("asdfasf");
        player.GetComponent<JoystickPlayerExample>().speed += 100f;
    }
}
