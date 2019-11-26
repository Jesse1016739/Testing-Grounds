using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eBulletSpawner : MonoBehaviour
{
    #region Old Shooting Code
    /*
    public GameObject projectile;
    public bool canFire = false;
    public float enemyRPM;

    // Update is called once per frame
    void Update()
    {
        if (canFire == true)
        {
            StartCoroutine(enemyShoot());
        }
    }

    IEnumerator enemyShoot()
    {
        yield return new WaitForSeconds(enemyRPM);
        if (canFire == true)
        {
            Instantiate(projectile, transform.position, transform.rotation);
            Debug.Log("Enemy Fired!");
            yield return new WaitForSeconds(enemyRPM);
        }

    }
    */
    #endregion

    public GameObject projectile;
    public bool canFire = false;
    public bool firing;
    public float enemyRPM;
    public enemyStats eStats;

    void Start()
    {
        eStats = GetComponentInParent<enemyStats>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canFire == true && !firing)
        {
            StartCoroutine(enemyShoot());
        }
    }

    IEnumerator enemyShoot()
    {
        canFire = false;
        firing = true;
        yield return new WaitForSeconds(enemyRPM);
        GameObject bulletObj = Instantiate(projectile, transform.position, transform.rotation);
        //Debug.Log("Enemy Fired!");
        canFire = true;
        firing = false;


    }
}
