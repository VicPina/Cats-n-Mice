using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{


    private void Update()
    {
        transform.Rotate(0f,.5f,0, Space.Self);
        /*
        int catLayer = 1 << 8;
        catLayer = ~catLayer;
        
        RaycastHit hit;
       
        
           if (Physics.Raycast(ray, out hit, 5))
           {
               Debug.DrawRay(ray.origin, hit.point, Color.yellow);
               if (hit.collider.gameObject.tag == "Player")
               {
                   Debug.DrawRay(ray.origin, hit.point, Color.red);
                   hit.collider.gameObject.GetComponent<PlayerController>().IsExposed();
               }
           }
           else { Debug.DrawRay(ray.origin, ray.origin + ray.direction * 5, Color.white); }
        
        */
    }
}