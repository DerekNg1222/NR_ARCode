using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class center : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        _ = GetComponent<Renderer>().bounds.center;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
