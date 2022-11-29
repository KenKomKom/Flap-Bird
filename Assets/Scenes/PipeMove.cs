using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float speed=5f;
    public float leftedge;
    // Start is called before the first frame update
    void Start()
    {
        leftedge=-30;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position+=Vector3.left*speed*Time.deltaTime;
        if (transform.position.x<leftedge){
            Destroy(gameObject);
        }
    }
}
