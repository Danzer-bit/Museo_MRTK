using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationManager : MonoBehaviour
{
    [System.Serializable]
    public class ObjectGroup
    {
        public string groupName;
        public GameObject[] objects;
    }

    [Header("Gruppi di oggetti da gestire")]
    public ObjectGroup[] groups;

    [Header("Oggetti Attivi allo Start")]
    public string startGroup = "";

    void Start()
    {
        foreach (var group in groups)
        {
            bool isStartGroup = group.groupName == startGroup;
            foreach (var obj in group.objects)
            {
                if (obj != null)
                    obj.SetActive(isStartGroup);
            }
        }
    }

    public void ActivateGroup(string groupName)
    {
        foreach (var group in groups)
        {
            if (group.groupName == groupName)
            {
                foreach (var obj in group.objects)
                    if (obj != null) obj.SetActive(true);
            }
        }
    }

    public void DeactivateGroup(string groupName)
    {
        foreach (var group in groups)
        {
            if (group.groupName == groupName)
            {
                foreach (var obj in group.objects)
                    if (obj != null) obj.SetActive(false);
            }
        }
    }
}
