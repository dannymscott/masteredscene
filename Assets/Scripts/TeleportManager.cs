using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TeleportManager : MonoBehaviour
{
    [SerializeField] private List <Transform> transforms = new List<Transform>();
    [SerializeField] private FirstPersonController firstPersonController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ManageInput();
    }

    private void ManageInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            firstPersonController.enabled = false;
            transform.SetPositionAndRotation(transforms[0].position, transforms[0].rotation);
            firstPersonController.enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            firstPersonController.enabled = false;
            transform.SetPositionAndRotation(transforms[1].position, transforms[1].rotation);
            firstPersonController.enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            firstPersonController.enabled = false;
            transform.SetPositionAndRotation(transforms[2].position, transforms[2].rotation);
            firstPersonController.enabled = true;
        }
    }
}
