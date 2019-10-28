using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunController : MonoBehaviour
{
    //Part of the old code
    //public bool isEquipped = true;

    //Listing off some variables to make the code work
    public bool priBool = false;
    public bool secBool = false;
    
    public GameObject priGun;
    public GameObject secGun;

    //public Vector3 curPos;


    void Start()
    {
        secBool = true;
    }


    // Update is called once per frame
    void Update()
    {
        //This equips the primary gun (Shotgun/rifle)
        if (Input.GetKeyDown("[1]"))
        {
            priBool = true;
            secBool = false;
            Debug.Log("Primary Equipped");
        }

        //This equips the secondary gun (Default Pistol)
        if (Input.GetKeyDown("[2]"))
        {
            priBool = false;
            secBool = true;
            Debug.Log("Secondary Equiped");
        }

        //This records the current position of the player for gun spawning.
        //curPos = gameObject.transform.position;



        #region Old Code
        //Old code that just turned the gun invisible
        //This became redundent because the Maya models don't have a mesh
        /*
        if (Input.GetButtonDown ("Fire2") && isEquipped == true)
        {
            gunMesh.enabled = false;
            isEquipped = false;
        }

        if (Input.GetButtonDown("Fire2") && isEquipped == false)
        {
            gunMesh.enabled = true;
            isEquipped = true;
        }
        */
        #endregion
    }
}
