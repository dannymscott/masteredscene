using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerRingRotation : MonoBehaviour
{
    public float rotationSpeed;
    public Vector3 rotationAxis;
    public float forwardStop;
    public float backwardStop;
    public float pingPong;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pingPong += Time.deltaTime * rotationSpeed;
        pingPong = Mathf.PingPong(pingPong, 1);
        transform.localRotation = Quaternion.Euler(rotationAxis * Mathf.Lerp(forwardStop, backwardStop, pingPong));
    }
}
