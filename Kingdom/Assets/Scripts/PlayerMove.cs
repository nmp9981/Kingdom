using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LeftMove()
    {
        this.gameObject.transform.Translate(new Vector3(-speed, 0, 0));
    }
    public void RightMove()
    {
        this.gameObject.transform.Translate(new Vector3(speed, 0, 0));
    }

}
