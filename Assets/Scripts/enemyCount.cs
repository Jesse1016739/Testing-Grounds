using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCount : MonoBehaviour
{
    public float count;
    public int maxEnemy;

    public int enemiesLeft;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] enemyLimit = GameObject.FindGameObjectsWithTag("Mutant");
        enemiesLeft = enemyLimit.Length;
        
    }
}
