using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public float spawnTime;
    public GameObject enemy;

    public bool spawnToggle = false;

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(BreakInSpawning());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            spawnToggle = !spawnToggle; 
        }

        if (spawnToggle == true)
        {
            StartCoroutine(BreakInSpawning());
        }
        
    }

    //This is the coroutine started earlier
    IEnumerator BreakInSpawning()
    {
        yield return new WaitForSeconds(spawnTime);
        Instantiate(enemy);
    }


}
