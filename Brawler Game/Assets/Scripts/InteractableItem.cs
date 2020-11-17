using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class InteractableItem : MonoBehaviour
{
    public bool pickable, ladder, exit, catapult;
    public float duration, range;
    public AudioClip sfx;
    public GameObject affected;
    public UnityEvent DefaultAction;

    public void Interaction()
    {
        DefaultAction.Invoke();
    }
    public void Ladder()
    {
        Vector3 newPosition = new Vector3(affected.transform.position.x + 0.5f, affected.transform.position.y + 2f, affected.transform.position.z + 0.5f);
        affected.transform.position = newPosition;
    }
    public void Gap()
    {
        Vector3 newPosition = new Vector3(affected.transform.position.x, affected.transform.position.y, affected.transform.position.z + 1.85f);
        affected.transform.position = newPosition;
    }
    public void Item()
    {

    }
    public void Mechanism()
    {

    }
    public void Exit()
    {

    }
}
