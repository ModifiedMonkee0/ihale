using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OpenPC : MonoBehaviour
{

    public GameObject usePC;

    public GameObject playerCamera;
    public GameObject pcCamera;

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            usePC.SetActive(true);

            if(Input.GetKeyDown(KeyCode.E))
            {
                playerCamera.SetActive(false);
                pcCamera.SetActive(true);
            }
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            usePC.SetActive(false);
        }
    }

    
}
