using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public Bird bird;
    public GameObject gameover;
    public GameObject message;
    private int score;


    IEnumerator delay(){
        yield return new WaitForSeconds(2);
        Play();
    }

    public void Awake(){
        gameover.SetActive(false);
        message.SetActive(false);
        // bird.enabled=false;
        // bird.GetComponent<Rigidbody2D>().bodyType=RigidTypebody2D.Static;
        StartCoroutine(delay());

    }

    public void Play(){
        score=0;
        gameover.SetActive(false);
        message.SetActive(false);
        bird.enabled=true;
        // bird.GetComponent<Rigidbody2D>().bodyType=RigidTypebody2D.Dynamic;

    }

    IEnumerator Pause(){
        yield return new WaitForEndOfFrame();
        Time.timeScale = 0f;
        bird.enabled= false;
    }

    public void gameOver(){
        gameover.SetActive(true);
        Debug.Log("GAME OVER");
        Debug.Log(score);
        StartCoroutine(Pause());
    }

    public void win(){
        gameover.SetActive(true);
        Debug.Log("WIN");
        Debug.Log(score);
        StartCoroutine(Pause());
    }

    public void increaseScore(){
        score++;
        Debug.Log(score);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}