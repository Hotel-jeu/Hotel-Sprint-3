using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuvertureAscenseur : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>().SetBool("ouvrirAscenseur", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
