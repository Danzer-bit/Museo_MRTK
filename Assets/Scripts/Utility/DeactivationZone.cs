using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class DeactivationZone : MonoBehaviour
{
    public string groupName; // gruppo da disattivare

    private ActivationManager manager;

    void Start()
    {
        manager = FindObjectOfType<ActivationManager>();
        if (!manager)
            Debug.LogError("ActivationManager non trovato in scena!");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && manager != null)
        {
            manager.DeactivateGroup(groupName);
        }
    }
}