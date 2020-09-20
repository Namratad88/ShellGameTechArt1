using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    //The object we are colliding with
    protected GameObject collidingObject = null;

    // Update is called once per frame
    void Update()
    {
        //Check for inputs to pick up the object
        if (Input.GetButtonDown("Fire1"))
        {
            if (collidingObject != null)
            {
                if (collidingObject.GetComponent<TreasureChest>() != null)
                {
                    collidingObject.GetComponent<TreasureChest>().OpenBox();
                }
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<TreasureChest>())
        {
            Debug.Log("On t enter!");
            collidingObject = other.gameObject;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.gameObject.GetComponent<TreasureChest>())
        {
            Debug.Log("On t exit!");
            collidingObject = null;
        }
    }


}
