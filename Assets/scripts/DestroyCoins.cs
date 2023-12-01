using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class DestroyCoins : MonoBehaviour
{
    public GameObject Circle;
    public Collider2D spawnObject;
    
    

    
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
            //SetBallPosition(collision.transform);
            //gameObject.SetActive(false);
            SetCirclePosition(collision.transform);

           // Instantiate(Circle);
          // {

              //  SetCirclePosition(collision.transform);
           // }
        }
    
        else if (collision.gameObject.CompareTag("ball"))
        
        {
            SetCirclePosition(collision.transform);
            //SetBallPosition(collision.transform);
            // gameObject.SetActive(false) ;
            // Instantiate(Circle);
            // {

            //     SetCirclePosition(collision.transform);

            // }
        }
         

    }

    public void SetCirclePosition(Transform CircleTransform)
    {
        
            float horizontalPosition = Random.Range(spawnObject.bounds.min.x, spawnObject.bounds.max.x);
            float verticalPosition = Random.Range(spawnObject.bounds.min.y, spawnObject.bounds.max.y);
        CircleTransform.position = new Vector2(horizontalPosition, verticalPosition);   
    }

    //public void SetBallPosition(Transform ballTransform)
    //{
    // float horizontalPosition = Random.Range(spawnObject.bounds.min.x, spawnObject.bounds.max.x);
    // float verticalPosition = Random.Range(spawnObject.bounds.min.y, spawnObject.bounds.max.y);
    //  ballTransform.position = new Vector2(horizontalPosition, verticalPosition);
    // }
}
