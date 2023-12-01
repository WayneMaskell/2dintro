using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public AudioSource audioPlayer;
    public float speed = 2.0f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(transform.right * -1 * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D)) 
        {
            transform.Translate(transform.right * 1 * speed * Time.deltaTime);
         
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="ball")
        {
            audioPlayer.Play();
        }
    }
}
