using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    // Math requisites
    [Header("Movement")]
    public float xAxis, zAxis, speed, frame;

    [Header("Rotation")]
    public float rMovement;
    public float rotationRate = 180;

    // Update is called once per frame
    void Update()
    {
        frame = Time.deltaTime;
        speed = 1.5f;


        xAxis = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * xAxis * speed * frame);
        
        zAxis = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * zAxis * speed * frame);
        /*
        rMovement = Input.GetAxis("Vertical");
        transform.Rotate(0, rMovement * rotationRate * frame, 0);
        */
    }

    /*
    public void PlayerMovement(GameObject affectedGO, float xAxis, float zAxis)
    {
        float speed = 5.0f;
        float frame = Time.deltaTime;

        affectedGO.transform.Translate(Vector3.)
    }
    */
}
