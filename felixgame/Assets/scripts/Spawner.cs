using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject mySphere; //dit is de item prefab

    public float spawnInterval = 0.9f; //dit is de tijd tussen spawns

    public int rangeX = 7; //dit is de breedte waarin de items spawnen
    public int minY = 11; //minimale hoogte voor spawns
    public int maxY = 11; //maximale hoogte voor spawns

    private float timer; //dit maakt een timer variabele aan
    void Start()
    {
        timer = spawnInterval; //de timer wordt gelijk gezet aan het interval
    }

    void Update()
    {
        timer -= Time.deltaTime; //dit zorgt ervoor dat de timer gaat aftellen 
        
        if(timer <=0) 
        {
            SpawnSphere(); //als de timer kleiner of gelijk is aan 0 dan spawnt er een clone
            timer = spawnInterval; //dit zet de timer weer terug naar het interval
        }
    }
    public void SpawnSphere() 
    {
        int spawnPointX = Random.Range(-rangeX, rangeX); //dit kiest een random plek tussen de gegeven posities
        int spawnPointY = Random.Range(minY, maxY); //dit kiest een random plek tussen de gegeven posities

        Vector3 spawnPosition = new Vector3(spawnPointX, spawnPointY); //dit geeft aan wat de spawnpositie is

        Instantiate(mySphere, spawnPosition, Quaternion.identity); //dit maakt een clone aan op de gekozen positie
    }
}
