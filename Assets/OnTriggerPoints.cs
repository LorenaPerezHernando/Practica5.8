using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerPoints : MonoBehaviour
{
    GameOn managerGameOn;

    private void Awake()
    {
        managerGameOn = FindAnyObjectByType<GameOn>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "BeachObject")
        {
            managerGameOn.points++;
            Destroy(other.gameObject);
        }
    }
}
