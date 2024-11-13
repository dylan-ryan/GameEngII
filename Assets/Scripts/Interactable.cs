using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{

    public enum InteractionType { Door, Button, Pickup }
    public InteractionType type;
    public PickupStats pickupStats;

    private InteractionManager interactionManager;

    private void Awake()
    {
        interactionManager = FindAnyObjectByType<InteractionManager>();
    }

    public void Activate()
    {
        Debug.Log(this.name + " was actiavted");
        if(type == InteractionType.Door)
        {
            interactionManager.pickupCout += pickupStats.count;
        }
    }
}