using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChestInteraction : MonoBehaviour
{
    public Vector3 InsertItemPosition = new Vector3();

    protected Animator animatorComponent;
    protected ShellGameManager shellGameManagerRef = null;

    protected bool bInteractable = false;

    void Start()
    {
        animatorComponent = gameObject.GetComponent<Animator>();

        shellGameManagerRef = FindObjectOfType<ShellGameManager>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerCharacter>() != null)
        {
            animatorComponent.SetBool("Open", true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerCharacter>() != null)
        {
            animatorComponent.SetBool("Open", false);
        }
    }

    public void FinishMovement()
    {
        bInteractable = true;
    }

    public void OpenBox()
    {
        Debug.Log("Try open box!");
        if (bInteractable)
        {
            Debug.Log("Open box!");
        }
    }


}
