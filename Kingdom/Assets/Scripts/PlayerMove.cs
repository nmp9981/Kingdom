using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float speed = 3.0f;
    bool LeftMove,RightMove = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(LeftMove==true)
        {
            transform.Translate(-1*Time.deltaTime*speed,0,0);
        }

        if(RightMove==true)
        {
            transform.Translate(1*Time.deltaTime*speed,0,0);
        }
    }
    public void LeftButtonDown()
    {
        LeftMove = true;
    }
    public void RightButtonDown()
    {
        RightMove = true;
    }
     public void LeftButtonUp()
    {
        LeftMove = false;
    }
    public void RightButtonUp()
    {
        RightMove = false;
    }

}
