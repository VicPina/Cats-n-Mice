using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    public bool confirmation;
    public LayerMask fovMask;
    public Transform cat;
    // Update is called once per frame
    void Update()
    {
        Vector3 dirToCat = (cat.position - transform.position).normalized;
        var dstToCat = Vector3.Distance(transform.position, cat.position);
        Ray catFov = new Ray(transform.position, dirToCat * 5);
        RaycastHit hit;
        //        Debug.DrawLine(transform.position, dirToCat + transform.position, Color.white);
        //      Debug.DrawRay(catFov.origin, dirToCat, Color.white);
        if (Physics.Raycast(catFov, out hit, dstToCat, fovMask)) 
        {
            if (hit.collider.gameObject.tag == "Building")
            {
                Debug.DrawRay(catFov.origin, dirToCat * hit.distance, Color.yellow);
                confirmation = false;
            }
            else if (hit.collider.gameObject.tag=="CatFOV")
            {
                confirmation = true;
                Debug.DrawRay(catFov.origin, dirToCat * hit.distance, Color.red);
            }
        }
    }
}
