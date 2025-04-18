using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class heroKnight : MonoBehaviour
{
    public float speed = 2;
    Animator anim;
    SpriteRenderer yumyum;
    public bool canRun = true;
    AudioClip clip;
    AudioSource wiwiwi;
    public CinemachineImpulseSource urmo; 

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        yumyum = GetComponent<SpriteRenderer>();
        wiwiwi = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal"); 
        yumyum.flipX = direction < 0; // flips x axis when w or < button is pressed (hero knight turns left)

        anim.SetFloat("speed", Mathf.Abs (direction)); // absolute || so that when we run backwards it still counts for the animation (no negatives) 

        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("slash"); // triggers the slash in animation when mouse button clicked
            canRun = false;
        }

        if (canRun == true) // makes so that guy can only move AFTER the attack animation has finished
        {
            transform.position += transform.right * direction * speed * Time.deltaTime; // makes the guy actually move
        }
    }

    public void done() // public void for attack is done 
    {
        canRun = true;
        Debug.Log("duck duck goose");
    }

    public void beepboop() //public void for footspstes
    {
        wiwiwi.Play();
        urmo.GenerateImpulse(); // makes screen shake when called
        Debug.Log("step step");
    }
}
