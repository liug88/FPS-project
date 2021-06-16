using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS : MonoBehaviour
{
    public float rotSpeed = 210;
    public float yMinLimit = -60;
    public float yMaxLimit = 60;

    private float rotX;
    private float rotY;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rotX += Input.GetAxis("Mouse X") * rotSpeed * Time.deltaTime;
        
        rotY -= Input.GetAxis("Mouse Y") * rotSpeed * Time.deltaTime;
        rotY = Mathf.Clamp(rotY, yMinLimit, yMaxLimit);
        transform.rotation = Quaternion.Euler(rotY, rotX, 0);
    }


}
