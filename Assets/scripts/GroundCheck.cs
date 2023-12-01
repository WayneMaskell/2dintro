using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GroundCheck : MonoBehaviour
{
    
    public CollisionCheck collisionCheck;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            collisionCheck.score--;
            Debug.Log("the score is " + collisionCheck.score);

            if (collisionCheck.score <= 0) 
            {
                collisionCheck.score = 0;
            }

        }
    }
    

}