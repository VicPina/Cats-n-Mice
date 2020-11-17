using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    public LayerMask buildingMask, catMask;
    public Transform cat;

    // Update is called once per frame
    void Update()
    {
        GetComponent<PlayerController>().IsExposed();
        Vector3 dirToCat = (cat.position - transform.position).normalized;

        Ray catFov = new Ray(transform.position, dirToCat);
        RaycastHit hit;
        if (Physics.Raycast(catFov, out hit))
        {
            if (hit.collider.gameObject.layer == catMask)
            {
                Debug.DrawLine(catFov.origin, hit.point, Color.red);
            }
        }
        else
        {
            if (hit.collider.gameObject.layer == buildingMask)
            {
                Debug.DrawLine(catFov.origin, hit.point, Color.yellow);
            }
        }
    }
}
