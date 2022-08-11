using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOJ : MonoBehaviour
{
    void Start()
    {
        Invoke("DestroyME", 2.1f);
    }

    void DestroyME()
    {
        Destroy(gameObject);
    }
}
