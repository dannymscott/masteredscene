using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunController : MonoBehaviour
{
    [SerializeField] private List <Vector3> times = new List<Vector3>();
    
    void Update()
    {
        SunControl();
    }

    void SunControl()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            transform.localRotation = Quaternion.Euler(times[0]);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            transform.localRotation = Quaternion.Euler(times[1]);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            transform.localRotation = Quaternion.Euler(times[2]);
        }
    }
}
