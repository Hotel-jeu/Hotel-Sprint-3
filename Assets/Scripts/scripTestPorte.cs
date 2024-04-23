using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripTestPorte : MonoBehaviour
{
    private Animator porteAnimation;
    private bool porteBool;
    private bool lampeTorchePrise;
    // private bool porteZone;
    void Start()
    {
        porteAnimation = GetComponent<Animator>();
        porteBool = false;
        // porteZone = false;
    }

    void Update()
    {
        // if (porteAnimation != null )
        // {
        //     if (Input.GetKeyDown(KeyCode.E) && porteZone)
        //     {
        //         porteBool = !porteBool;
        //         porteAnimation.SetTrigger(porteBool ? "porteOuvert" : "porteFermer");
        //         print(porteBool);
        //     }
        // }
        // print(porteZone);
    }

    public void TogglePorte()
    {

        if (porteAnimation != null)
        {
            porteBool = !porteBool;
            porteAnimation.SetTrigger(porteBool ? "porteOuvert" : "porteFermer");

        }
    }

    // private void OnTriggerEnter(Collider other)
    // {
    //     if (other.gameObject.CompareTag("player"))
    //     {
    //         porteZone = true;
    //     }
    // }
    // private void OnTriggerExit(Collider other)
    // {
    //     if (other.gameObject.CompareTag("player"))
    //     {
    //         porteZone = false;
    //     }
    // }
}