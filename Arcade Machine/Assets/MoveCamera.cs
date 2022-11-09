using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    private Transform go;
    float i = 0;
    // Start is called before the first frame update
    void Start()
    {
        go = GetComponent<Transform>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            i = i+1;
        }
        transform.rotation = new Quaternion(0.0f, i, 0.0f,0.0f);
    }
}
