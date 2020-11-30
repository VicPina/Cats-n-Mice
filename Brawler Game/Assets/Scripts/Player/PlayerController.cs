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
    private GameObject pickedItem, inRangeObject;
    
    private float bxCSize, bxCCenter, exposure;
    private float speed = 1.5f;
    public bool mayInteract, inSight;

    [SerializeField]
    private LayerMask buildingMask, catMask;
    private Transform cat;

    private Vector2 leftStickValue;

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
        if (callback.phase == InputActionPhase.Performed) { speed = 2.5f; }
        else {  speed = 1.5f; }
    }
    public void Interact(InputAction.CallbackContext callback)
    {
        if (callback.phase == InputActionPhase.Started)
        {
            if (mayInteract)
            {
                if (inRangeObject.GetComponent<InteractableItem>().pickable)
                {
                    pickedItem = inRangeObject.GetComponent<InteractableItem>().itemPrefab;
                    inRangeObject.SetActive(false);
                }
                else
                {
                    inRangeObject.GetComponent<InteractableItem>().Interaction();
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
        Vector3 dirToCat = (cat.position - transform.position).normalized;

        Ray catFov = new Ray(transform.position, dirToCat);
        RaycastHit hit;
        if (Physics.Raycast(catFov, out hit))
        {
            if (hit.collider.gameObject.layer == catMask)
            {
                Debug.DrawLine(catFov.origin, hit.point, Color.red);
                exposure += (0.2f * 0.01f);
            }
            else if (hit.collider.gameObject.layer == buildingMask)
            {
                Debug.DrawLine(catFov.origin, hit.point, Color.yellow);
            }
        }
    }

    private void OnEnable()
    {
       Debug.Log("Player " + user.playerIndex + " Joined!!");
    }

    private void Awake()
    {
        user = GetComponent<PlayerInput>();
        exposure = 0f;
    }

    // Update is called once per frame
    private void Update()
    {
        // Move character
        Vector3 moveValues = new Vector3(leftStickValue.x, 0, leftStickValue.y);
        transform.Translate(moveValues * speed * Time.deltaTime);

        ExposureMeter.value = exposure;

        if (inSight) { IsExposed(); }

        if (ExposureMeter.value >= 2) { Defeated(); }

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
            mayInteract = true;
            inRangeObject = other.gameObject;
            inRangeObject.GetComponent<InteractableItem>().affectePlayer = gameObject;
        }
        if (other.tag == "CatFOV")
        {
            inSight = true;
            cat = other.gameObject.transform;
        }
    }
    public void OnTriggerExit(Collider other) 
    {
        if (other.tag == "Interactable") 
        {
            mayInteract = false; 
        }
        else if (other.tag == "CatFOV")
        {
            inSight = false;
        }
        else if (other.tag == "Exit")
        {
            string playerLabel = ("Player " + user.playerIndex + " Won!!");
            other.gameObject.GetComponent<ExitManager>().Winner(playerLabel);
        }
    }
    
    private void OnDisable()
    {
        controls.Disable();
    }

    

}
