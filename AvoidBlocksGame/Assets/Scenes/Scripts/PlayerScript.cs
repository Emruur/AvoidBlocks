using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int speed= 1;

    float screenHalfWidth;

    // Start is called before the first frame update
    void Start()
    {
        float playerWidth= transform.localScale.x;
        screenHalfWidth= (Camera.main.aspect * Camera.main.orthographicSize) +playerWidth/2f;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal= Input.GetAxisRaw("Horizontal");
        
        Vector2 velocity= new Vector2(horizontal*speed, 0);
        transform.Translate(velocity*Time.deltaTime);

        edgeDetect();
    }

    void edgeDetect(){
        if(transform.position.x< -screenHalfWidth){
            transform.position= new Vector3(screenHalfWidth,transform.position.y,0);
        }
        if(transform.position.x> screenHalfWidth){
            transform.position= new Vector3(-screenHalfWidth,transform.position.y,0);
        }
    }

    //override
    void OnTriggerEnter2D(Collider2D trigger){
        if(trigger.tag== "Faller"){
            Destroy(gameObject);
        }
    }
}
