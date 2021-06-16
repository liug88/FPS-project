using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(CharacterController))]
[RequireComponent(typeof(Rigidbody))]
public class playerMovementFPS : MonoBehaviour
{
    public float speed = 6;
    public float jumpspeed = 8;
    public float gravity = 20;
    

    private CharacterController cc;
    private Vector3 moveDirection = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float oldY = moveDirection.y;

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        moveDirection = new Vector3(h, 0, v);

        GameObject dummy = new GameObject();
        dummy.transform.position = Camera.main.transform.position;
        dummy.transform.rotation = Camera.main.transform.rotation;
        dummy.transform.localScale = Camera.main.transform.localScale;
        
        dummy.transform.rotation = Quaternion.Euler(new Vector3(0, dummy.transform.rotation.eulerAngles.y, 0));
        moveDirection = dummy.transform.TransformDirection(moveDirection);

        moveDirection *= speed;

        Destroy(dummy);

        if (cc.isGrounded)
        {
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpspeed;
            }
        }
        else
        {
            moveDirection.y = oldY;
        }

        moveDirection.y -= gravity * Time.deltaTime;

        cc.Move(moveDirection * Time.deltaTime);


    }
}
