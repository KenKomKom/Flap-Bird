using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D rigid;
    public float jumpforce=10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            rigid.velocity = new Vector2(rigid.velocity.x, jumpforce);
        }
    }
    void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.tag=="End"){
            FindObjectOfType<Scoring>().gameOver();

        }else if (col.gameObject.tag=="Score"){
            FindObjectOfType<Scoring>().increaseScore();

        }else if (col.gameObject.tag=="Finish"){
            print("WIN");
            FindObjectOfType<Scoring>().win();
        }
    }
}