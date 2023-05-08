using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuterRingRotation : MonoBehaviour
{
    public float rotationSpeed;
    public Vector3 rotationAxis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
    }
}
