using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fan : MonoBehaviour
{
    private bool fanOn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            fanOn = !fanOn;
        }
        fanmove();
    }

    void fanmove()
    {
        if(fanOn)
        {

        }
    }
}
