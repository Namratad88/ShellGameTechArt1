using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentJoint : MonoBehaviour
{
    public GameObject chest;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        chest.transform.parent = transform;
        chest.transform.localRotation = Quaternion.identity;
        chest.transform.localPosition = Vector3.zero;

    }
}
