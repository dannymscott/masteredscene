using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TeleportManager : MonoBehaviour
{
    [SerializeField] private List <Transform> transforms = new List<Transform>();
    
    void Update()
    {
        ManageInput();
    }

    private void ManageInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            
            transform.SetPositionAndRotation(transforms[0].position, transforms[0].rotation);
            
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            
            transform.SetPositionAndRotation(transforms[1].position, transforms[1].rotation);
            
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            
            transform.SetPositionAndRotation(transforms[2].position, transforms[2].rotation);
            
        }
    }
}
