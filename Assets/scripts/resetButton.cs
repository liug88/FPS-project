using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetButton : MonoBehaviour
{
    public Transform Targets;
    public Transform Boxes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        foreach (Transform target in Targets) {
            target.GetComponentInChildren<setAnimation>().resetTarget();
        }
        foreach (Transform target in Boxes)
        {
            target.GetComponent<Rigidbody>().useGravity = false;
            target.GetComponent<Rigidbody>().isKinematic = true;
            target.GetComponent<ResetBox>().ReturntoOrignal= true;
        }
    }
}
