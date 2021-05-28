using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject fallerPrefab;
    Vector2 screenHalfSize;

    public float spawnRate= 2;
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
            nextSpawnTime += spawnRate;

            Vector2 spawnPosition= new Vector2(Random.Range(-screenHalfSize.x,screenHalfSize.x),screenHalfSize.y+ spawnSizeMinMax.y);

            Quaternion fallerRotation= Quaternion.Euler(0,0,Random.Range(-15f,15f));

            GameObject faller= Instantiate(fallerPrefab,spawnPosition,fallerRotation);
            faller.transform.localScale= new Vector3(Random.Range(0.5f,1.5f),Random.Range(spawnSizeMinMax.x, spawnSizeMinMax.y),1);
        }
    }
}
