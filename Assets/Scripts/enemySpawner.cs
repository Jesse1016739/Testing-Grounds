using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public float spawnTime;
    public float curMut;
    public float maxMut;

    //public bool spawnToggle = false;

    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawning());
    }

    #region Manual Spawning Code
    // Update is called once per frame
    /*
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //StartCoroutine(BreakInSpawning());
          spawnToggle = true; 
        }

        if (spawnToggle == true)
        {
            StartCoroutine(BreakInSpawning());
        }

    }
    */
    #endregion

    //This is the coroutine started earlier
    IEnumerator Spawning()
    {
        //spawnToggle = false;
        yield return new WaitForSeconds(spawnTime);
        Instantiate(enemy, transform.position, transform.rotation);
        curMut += 1;
        if (curMut < maxMut)
        {
            StartCoroutine(Spawning());
        }
    }
}
