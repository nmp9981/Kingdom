using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    Rigidbody2D PlayerRgbd;
    public int life = 3;
    public Text life_text;

    void Start()
    {
        life=3;
        PlayerRgbd = GetComponent<Rigidbody2D>();
        life_text.text = "Life: "+ life;
    }

    void Update()
    {

    }
    //"Monster"��� �±� ���� ��������Ʈ�� �浹�ϸ� life ����
    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag == "Monster"){
            life--;
            life_text.text = "Life: "+ life;
        }
    }
}
