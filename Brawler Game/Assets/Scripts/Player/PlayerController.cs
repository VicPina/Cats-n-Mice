using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(BoxCollider))]

public class PlayerController : MonoBehaviour
{
    private GameController controls;
    private PlayerInput user;

    public Slider ExposureMeter;

    public GameObject standingMesh, crouchingMesh, defeatedMesh;
    [SerializeField]
    private GameObject pickedItem, inRangeItem;
    
    private float bxCSize, bxCCenter, exposure;
    private float speed = 1.5f;
    public bool mayInteract;

    private Vector2 leftStickValue;
    private Vector3 spawner;

    #region Inputs
    public void OnMove(InputAction.CallbackContext callback)
    {
        leftStickValue = callback.ReadValue<Vector2>();
    }
    public void Crouching(InputAction.CallbackContext callback)
    {
        if (callback.phase == InputActionPhase.Performed)
        {
            speed = 1f;
            bxCSize = 0.75f;
            bxCCenter = 0.45f;
            crouchingMesh.GetComponent<MeshRenderer>().enabled = true;
            standingMesh.GetComponent<MeshRenderer>().enabled = false;
        }
        else
        {
            speed = 1.5f;
            bxCSize = 1.75f;
            bxCCenter = 0.9f;
            crouchingMesh.GetComponent<MeshRenderer>().enabled = false;
            standingMesh.GetComponent<MeshRenderer>().enabled = true;
        }
    }
    public void Running(InputAction.CallbackContext callback)
    {
        if (callback.phase == InputActionPhase.Performed)
        {
            speed = 2.5f;
        }
        else
        {
            speed = 1.5f;
        }
    }
    public void Interact(InputAction.CallbackContext callback)
    {
        if (callback.phase == InputActionPhase.Started)
        {
            if (mayInteract)
            {
                if (inRangeItem.GetComponent<InteractableItem>().pickable)
                {
                    pickedItem = inRangeItem;
                    inRangeItem.SetActive(false);
                }
                else
                {
                    inRangeItem.GetComponent<InteractableItem>().Interaction();
                }
            }
        }
    }
    public void UseItem(InputAction.CallbackContext callback)
    {

    }
    #endregion

    public void SetMaterial(Material material)
    {
       MeshRenderer[] newMesh = GetComponentsInChildren<MeshRenderer>();
       foreach(MeshRenderer playerColour in newMesh)
       {
           playerColour.material = material;
       }
    }
    public void IsExposed()
    {
        exposure += (0.2f * 0.01f);
    }

    private void OnEnable()
    {
       controls.Enable();

       Debug.Log("Player " + user.playerIndex + " Joined!!");

        gameObject.transform.position = spawner;
    }

    private void Awake()
    {
        spawner = new Vector3(-3.908f, 3.54f, -10.322f);
        user = GetComponent<PlayerInput>();
        exposure = 0f;

        crouchingMesh.GetComponent<MeshRenderer>().enabled = false;

        /*/ Input mapping
        controls = new GameController();
        
        controls.PlayerControls.Crouch.performed += context => Crouching();
        controls.PlayerControls.Crouch.canceled += context => NotCrouching();
        
        controls.PlayerControls.Move.performed += context => leftStickValue = context.ReadValue<Vector2>();
        controls.PlayerControls.Move.canceled += context => leftStickValue = Vector2.zero;
        
        controls.PlayerControls.Interact.started += context => { if (mayInteract) { Interact(); } };
        
        controls.PlayerControls.Run.started += context => { speed = 2f; };
        controls.PlayerControls.Run.canceled += context => { speed = 1.5f; };
        */
    }


    // Update is called once per frame
    private void Update()
    {
        // Move character
        Vector3 moveValues = new Vector3(leftStickValue.x, 0, leftStickValue.y);
        transform.Translate(moveValues * speed * Time.deltaTime);

        ExposureMeter.value = exposure;

        if (ExposureMeter.value >= 2) 
        {
            Defeated();
        }

        /*
        xAxis = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * xAxis * speed * frame);
        
        zAxis = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * zAxis * speed * frame);
       
        rMovement = Input.GetAxis("Vertical");
        transform.Rotate(0, rMovement * rotationRate * frame, 0);
        */
    }

    private void Defeated()
    {
        crouchingMesh.GetComponent<MeshRenderer>().enabled = false;
        standingMesh.GetComponent<MeshRenderer>().enabled = false;
        defeatedMesh.GetComponent<MeshRenderer>().enabled = true;
        Destroy(this);
    }

    // Check if in range to interact
    public void OnTriggerEnter(Collider other) 
    { 
        if(other.tag == "Interactable")
        {
            if (other.gameObject.GetComponent<InteractableItem>().pickable)
            {
                inRangeItem = other.gameObject;
                other.gameObject.GetComponent<InteractableItem>().affected = gameObject;
            }
            else
            {
                other.gameObject.GetComponent<InteractableItem>().Interaction();
            }
        }
        if (other.tag == "CatFOV")
        {
            GetComponent<Raycaster>().enabled = true;
            GetComponent<Raycaster>().cat = other.transform;
        }
    }
    public void OnTriggerExit(Collider other) 
    {
        if (other.tag == "Interactable") 
        {
            mayInteract = false; 
        }
        if (other.tag == "CatFOV")
        {
            GetComponent<Raycaster>().enabled = false;
        }
    }
    
    private void OnDisable()
    {
        controls.Disable();
    }

    

}
