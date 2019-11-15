using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eBulletSpawner : MonoBehaviour
{
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
}
