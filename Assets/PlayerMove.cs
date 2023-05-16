using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float PlayerMoveSpeed; 
    void Start()
    {
        PlayerMoveSpeed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-1*Time.deltaTime*PlayerMoveSpeed,0,0);
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(1*Time.deltaTime*PlayerMoveSpeed,0,0);
        }
    }
}
