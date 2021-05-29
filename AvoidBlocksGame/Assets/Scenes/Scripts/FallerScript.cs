using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 speedMinMax;
    float visibleHeightTreshold;
    void Start()
    {
        visibleHeightTreshold= -Camera.main.orthographicSize- transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        float currentSpeed= Mathf.Lerp(speedMinMax.x,speedMinMax.y,Difficulty.getCurrentPercentage());
        transform.Translate(Vector3.up *-currentSpeed* Time.deltaTime);

        if(transform.position.y< visibleHeightTreshold){
            Destroy(gameObject);
        }
    }

    
}
