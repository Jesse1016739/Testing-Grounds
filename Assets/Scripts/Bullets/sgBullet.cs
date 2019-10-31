using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sgBullet : MonoBehaviour
{
    //Just some variable naming
    public float sgBulletSpeed;
    private Rigidbody sgBulletRB;

    public enemyStats stats;

    public float sgDespawnTime;


    void Start()
    {
        //This part assigns the bullet's Rigidbody value to the bulletRB variable...
        sgBulletRB = GetComponent<Rigidbody>();
        
        //...which allows us to manipulate the velocity of the bullet, propelling it forward with the bullet speed
        sgBulletRB.velocity = transform.forward * sgBulletSpeed;

        //This despawn coroutine begins when the bullets spawn
        StartCoroutine(SGBulletDespawn());
    }

    //This is the coroutine started earlier
    IEnumerator SGBulletDespawn()
    {
        //It waits for a set number of seconds (despawnTime) and then destroys the game object
        //This can help set the range of a bullet or debug it incase it goes through a wall
        yield return new WaitForSeconds(sgDespawnTime);
        Destroy(gameObject);
    }

    //This section determines what happens when a bullet collide with objects
    private void OnCollisionEnter(Collision col)
    {
        //If it collides with a wall, it destroys itself in confusion
        if (col.transform.tag == "Wall")
        {
            Destroy(gameObject);
        }
        //If it hits an enemy, it destroys both itself and the enemy 
        else if (col.transform.tag == "Mutant")
        {
            Destroy(gameObject);
            stats.curHealth -= 3;
        }
    }
}
