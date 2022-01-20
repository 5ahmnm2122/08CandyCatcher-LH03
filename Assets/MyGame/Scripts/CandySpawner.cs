using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{

    public GameObject[] candyPrefab;

    private float spawnDelay;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        StartCoroutine(CandyShower());
    }

    private void SpawnCandy()
    {
        Debug.Log("SpawnFood");
        int randomFood = Random.Range(0, candyPrefab.Length);

        GameObject a = Instantiate(candyPrefab[randomFood]) as GameObject;
        a.transform.position = new Vector2(Random.Range(-7, 7), 7);
    }

    IEnumerator CandyShower()
    {
        while (true)
        {
            spawnDelay = Random.Range(0.5f, 1);
            yield return new WaitForSeconds(spawnDelay);
            SpawnCandy();

        }

    }


}
