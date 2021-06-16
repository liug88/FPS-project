using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastShooting : MonoBehaviour
{
    public GameObject Decal;
    public float frequency = .5f;
    public float hitForce = 5.0f;
    public float range = 100.0f;
    public Transform barrel;
    private float ctime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ctime < frequency)
        {
            ctime += Time.deltaTime;
        }
        else {
            if (Input.GetMouseButton(0)) {
                RaycastHit hit;
                if (Physics.Raycast(barrel.position, barrel.forward, out hit, range)) {

                    GameObject clone = Instantiate(Decal, hit.point - transform.TransformDirection(new Vector3(0,0,.05f)), Quaternion.FromToRotation(Vector3.forward, hit.normal));
                    clone.transform.SetParent(hit.transform);
                    Destroy(clone, 6);

                    if (hit.rigidbody != null) {
                        hit.rigidbody.AddForce(-hit.normal * hitForce, ForceMode.Impulse);

                        targetHit th = hit.collider.gameObject.GetComponent<targetHit>();
                        if (th) {
                            th.manualHit();
                        }

                    }
                }
                ctime = 0;
            }
        }
    }
}
