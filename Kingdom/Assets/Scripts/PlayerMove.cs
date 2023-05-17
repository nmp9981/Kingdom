using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private bool LeftMove, RightMove = false;
    public float speed = 5.0f;
    private void Update()
    {
        if (LeftMove)
        {
            transform.Translate(-1 * Time.deltaTime * speed, 0, 0);
        }
        if (RightMove)
        {
            transform.Translate(1 * Time.deltaTime * speed, 0, 0);
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
        LeftMove=false;
    }
    public void RightButtonUp()
    {
        RightMove=false;
    }
    

}
