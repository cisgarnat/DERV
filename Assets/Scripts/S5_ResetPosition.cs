using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S5_ResetPosition : MonoBehaviour
{
    
    [SerializeField]Transform origen;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = origen.transform.position;
        }
    }
}
