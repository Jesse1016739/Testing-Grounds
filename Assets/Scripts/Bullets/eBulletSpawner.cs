using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eBulletSpawner : MonoBehaviour
{
    public GameObject projectile;
    public bool canFire = false;
    //Mentally Poor People//

    // Update is called once per frame
    void Update()
    {
        if (canFire == true)
        {
            Instantiate(projectile, transform.position, transform.rotation);
            Debug.Log("Enemy Fired!");
        }
    }
}
