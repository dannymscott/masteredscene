using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunController : MonoBehaviour
{

    public float sunRotation;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            transform.localRotation = Quaternion.Euler(50, 0, 0);     
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            transform.localRotation = Quaternion.Euler(180, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
