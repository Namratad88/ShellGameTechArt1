using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    public GameObject Obejct;
    public Transform Target;
    protected GameObject Chest;
    protected bool ifColliding;

    //The object we are colliding with
    protected GameObject collidingObject = null;

    void Start()
    {
        ifColliding = false;
        Obejct.transform.parent = Target.transform;
        Obejct.transform.localPosition = Vector3.zero; //Rotation of the transform relative to the parent transform.
        Obejct.transform.localRotation = Quaternion.identity;//Position of the transform relative to the parent transform.
    }
    void Update()
    {
        if (Input.GetButtonDown("PlaceObject") && ifColliding == true)//Press "P" to place the object to the current collidingChest.
        {
            Obejct.transform.parent = null;
            Obejct.transform.parent = collidingObject.transform;
            
            if(collidingObject.GetComponent<TreasureChestInteraction>())
            {
                Obejct.transform.localPosition = collidingObject.GetComponent<TreasureChestInteraction>().InsertItemPosition;
            }
            else
            {
                Obejct.transform.localPosition = new Vector3(0, 5, 0);//Adjusting Postion inside the Chest.
            }

            Obejct.transform.localRotation = Quaternion.identity;
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Start Colliding");
        if (other.gameObject.GetComponent<TreasureChestInteraction>())
        {
            collidingObject = other.gameObject;
            ifColliding = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        Debug.Log("Stop Colliding");
        if (other.gameObject.GetComponent<TreasureChestInteraction>())
        {
            collidingObject = null;
            ifColliding = false;
        }
    }


}
