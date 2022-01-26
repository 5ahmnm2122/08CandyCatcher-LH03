using System.Collections;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    public GameObject[] candyPrefab;
    private float spawnDelay;
    public Timer timer;
    public GameObject tutorialScreen;

    //Close instruction canvas and start game
    public void StartSpawnerAndTimer()
    {
        StartCoroutine(CandyShower());
        timer.isPlaying = true;
        tutorialScreen.SetActive(false);
    }

    //Spawn candy at a random position
    private void SpawnCandy()
    {
        int randomFood = Random.Range(0, candyPrefab.Length);
        GameObject a = Instantiate(candyPrefab[randomFood]) as GameObject;
        a.transform.position = new Vector2(Random.Range(-7, 7), 7);
    }

    //Endless loop to spawn candies with a random delay time
    IEnumerator CandyShower()
    {
        while (true)
        {
            spawnDelay = Random.Range(0.2f, 0.6f);
            yield return new WaitForSeconds(spawnDelay);
            SpawnCandy();
        }
    }
}
