using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunSpawner : MonoBehaviour
{
    public GameObject priGun;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(priGun, transform);
        priGun.transform.IsChildOf(gameObject.transform);
        Debug.Log("Gun Spawned");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
