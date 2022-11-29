using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    void Start()
    {
        Debug.Log("FixedUpdate time :" + Time.deltaTime);
    }

    void Update()
    {
        Debug.Log("Update time ;" + Time.deltaTime);
    }
}
