using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent (typeof(Rigidbody))]
[RequireComponent (typeof(MeshCollider))]

public class CharacterController : MonoBehaviour
{
    private GameController controls;
    
    private float triggerValue;
    private float speed = 5f;

    private Vector2 leftStickValue;

    private void Awake()
    {
        //var gamepad = Gamepad.current;
        controls = new GameController();

        controls.PlayerControls.Crouch.performed += context => triggerValue = context.ReadValue<float>();
        controls.PlayerControls.Crouch.canceled += context => triggerValue = 0f;
        
        controls.PlayerControls.Move.performed += context => leftStickValue = context.ReadValue<Vector2>();
        controls.PlayerControls.Move.canceled += context => leftStickValue = Vector2.zero;

        controls.PlayerControls.Interact.started += context => Interact();
        controls.PlayerControls.Run.started += context => Running();

    }


    // Update is called once per frame
    void Update()
    {

        if (triggerValue > 0f)
        {
            Crouching();
        }

        transform.Translate(Vector3.one * leftStickValue * speed * Time.deltaTime);

        /*
        frame = Time.deltaTime;
        speed = 1.5f;


        xAxis = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * xAxis * speed * frame);
        
        zAxis = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * zAxis * speed * frame);
       
        rMovement = Input.GetAxis("Vertical");
        transform.Rotate(0, rMovement * rotationRate * frame, 0);
        */
    }

    private void OnEnable()
    {
        controls.Enable();
    }
    
    private void OnDisable()
    {
        controls.Disable();
    }

    private void Crouching()
    {
        Debug.Log("Should crouch");

    }
    private void Running()
    {
        Debug.Log("Should run");

    }
    private void Interact()
    {
        Debug.Log("Should interact / pick up");

    }
}
