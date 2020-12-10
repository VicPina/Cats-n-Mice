using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CatController : MonoBehaviour
{
    private bool changeDir;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "DirSwitch")
        {
            changeDir = !changeDir;
        }
    }
    private void Update()
    {
        /*
        if (changeDir) { transform.Translate(Vector3.right * 0.25f * Time.deltaTime); }
        else if (!changeDir) { transform.Translate(Vector3.left * 0.25f * Time.deltaTime); }
        */
    }
}