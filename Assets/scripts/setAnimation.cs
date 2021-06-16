using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setAnimation : MonoBehaviour
{
    public bool leftright;
    

    // Start is called before the first frame update
    void Start()
    {
        Invoke("setAnim", Random.Range(0,1.0f));
        
    }

    void setAnim() {
        if (leftright)
        {
            GetComponent<Animator>().SetBool("LeftRight", true);
            GetComponent<Animator>().speed = Random.Range(.2f, 1.0f);

        }
    }
    public void resetTarget()
    {
        GetComponent<Animator>().SetBool("Down", false);
        if (leftright)
        {
            GetComponent<Animator>().SetBool("LeftRight", true);
            GetComponent<Animator>().speed = Random.Range(.2f, 1.0f);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
