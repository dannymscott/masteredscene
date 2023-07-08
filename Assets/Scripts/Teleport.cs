using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teleport : MonoBehaviour
{

    private Button button;

    public int location = 1;
    public int direction;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ChangeLocation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeLocation()
    {
        Debug.Log(gameObject.name + " was clicked");
        location += direction;
    }
}
