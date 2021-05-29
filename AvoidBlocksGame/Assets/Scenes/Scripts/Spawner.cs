using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject fallerPrefab;

    //LEVEL PROPERTIES
    public float blockPerLevel= 5f;
    public float levelIntensity= 2f;


    //SPAWN PROPERTIES
    Vector2 screenHalfSize;

    public Vector2 spawnIntervalMinMax;
    float nextSpawnTime;

    public Vector2 spawnSizeMinMax;

    

    void Start()
    {
        nextSpawnTime= Time.time;
        

        screenHalfSize= new Vector2(Camera.main.aspect* Camera.main.orthographicSize, Camera.main.orthographicSize);
    }

    // Update is called once per frame
    void Update()
    {
        

        if(Time.time>= nextSpawnTime){
            nextSpawnTime += Mathf.Lerp(spawnIntervalMinMax.y, spawnIntervalMinMax.x, Difficulty.getCurrentPercentage());

            Vector2 spawnPosition= new Vector2(Random.Range(-screenHalfSize.x,screenHalfSize.x),screenHalfSize.y+ spawnSizeMinMax.y);
            Quaternion fallerRotation= Quaternion.Euler(0,0,Random.Range(-15f,15f));

            GameObject faller= (GameObject)Instantiate(fallerPrefab,spawnPosition,fallerRotation);
            faller.transform.localScale= new Vector3(Random.Range(0.5f,1.5f),Random.Range(spawnSizeMinMax.x, spawnSizeMinMax.y),1);
            Difficulty.incrementDifficulty();
            
            
            
        }

        
    }
}
