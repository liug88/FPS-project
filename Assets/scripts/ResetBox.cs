using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBox : MonoBehaviour
{
    Vector3 iPosition;
    Quaternion iRotation;
    public float returnSpeed = 4;
    public bool ReturntoOrignal = false;
    // Start is called before the first frame update
    void Start()
    {
        iPosition = transform.position;
        iRotation = transform.rotation;

    }

    // Update is called once per frame
    void Update()
    {
        if (ReturntoOrignal) {
            transform.position = Vector3.MoveTowards(transform.position, iPosition, returnSpeed * Time.deltaTime);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, iRotation, returnSpeed * Time.deltaTime);

            float dist = Vector3.Distance(transform.position, iPosition);
            float angle = Quaternion.Angle(transform.rotation, iRotation);
            if (dist < .1f && angle < 1) {
                transform.position = iPosition;
                transform.rotation = iRotation;
                GetComponent<Rigidbody>().useGravity = true;
                GetComponent<Rigidbody>().isKinematic = false;
                ReturntoOrignal = false;
            }
        }
    }


}
