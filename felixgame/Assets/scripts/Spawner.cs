using UnityEngine;

public class Spawner : MonoBehaviour
{
    //The GameObject that will spawn
    public GameObject ItemToSpawn; 
    //Time between item spawns
    public float spawnInterval = 0.9f; 
    //Ranges for item spawn location
    public int rangeX = 7; 
    public int minY = 11; 
    public int maxY = 11; 

    //creates a timer
    private float timer; 
    void Start()
    {
        timer = spawnInterval; 
    }

    void Update()
    {
        //makes the timer count down and if the timer reaches 0 it will spawn chosen GameObject
        timer -= Time.deltaTime;
        
        if(timer <=0) 
        {
            SpawnSphere(); 
            timer = spawnInterval; 
        }
    }
    public void SpawnSphere() 
    {
        //chooses a random point in given range and Instantiates a clone of chosen GameObject
        int spawnPointX = Random.Range(-rangeX, rangeX); 
        int spawnPointY = Random.Range(minY, maxY); 

        Vector3 spawnPosition = new Vector3(spawnPointX, spawnPointY); 

        Instantiate(ItemToSpawn, spawnPosition, Quaternion.identity); 
    }
}
