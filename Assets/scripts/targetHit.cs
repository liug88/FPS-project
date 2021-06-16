using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetHit : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        anim.SetBool("Down",true);
        anim.SetBool("LeftRight", false);
        anim.speed = 1;
    }
    public void manualHit() {
        anim.SetBool("Down", true);
        anim.SetBool("LeftRight", false);
        anim.speed = 1;
    }
    
}
