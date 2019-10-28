using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dpBullet : MonoBehaviour
{
    //Just some variable naming
    public float dpbulletSpeed;
    private Rigidbody dpbulletRB;

    public float dpDespawnTime;


    void Start()
    {
        //This part assigns the bullet's Rigidbody value to the bulletRB variable...
        dpbulletRB = GetComponent<Rigidbody>();

        //...which allows us to manipulate the velocity of the bullet, propelling it forward with the bullet speed
        dpbulletRB.velocity = transform.forward * dpbulletSpeed;

        //This coroutine begins when the bullets spawn
        StartCoroutine(DPBulletDespawn());
    }

    //This is the coroutine started earlier
    IEnumerator DPBulletDespawn()
    {
        //It waits for a set number of seconds (despawnTime) and then destroys the game object
        //This can help set the range of a bullet or debug it incase it goes through a wall
        yield return new WaitForSeconds(dpDespawnTime);
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
            Destroy(col.gameObject);
        }
    }

    #region Old Code
    //Non-functioning code that used gameObject.tag
    /*
            if (coll.gameObject.tag == "Wall")
            {
                Destroy(gameObject);
            }

            else if (coll.gameObject.tag == "Mutant")
            {
                Destroy(gameObject);
    Destroy(coll.gameObject);
            }
    */
    #endregion
}


