using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChest : MonoBehaviour
{
    public Vector3 InsertItemPosition = new Vector3();

    protected Animator animatorComponent;
    protected ShellGameManager shellGameManagerRef = null;

    protected bool bInteractable = false;

    // Start is called before the first frame update
    void Start()
    {
        animatorComponent = gameObject.GetComponent<Animator>();

        shellGameManagerRef = FindObjectOfType<ShellGameManager>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerCharacter>() != null)
        {
            Debug.Log("try to anim");
            animatorComponent.SetBool("Open", true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerCharacter>() != null)
        {
            Debug.Log("try to end anim");
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
