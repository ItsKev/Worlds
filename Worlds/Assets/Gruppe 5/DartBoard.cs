using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DartBoard : MonoBehaviour {

    [SerializeField] private int worldnumber;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Axe"))
        {
            Debug.Log("Hit world number: " + worldnumber);
            WorldManager.LoadScene(worldnumber);
        }
    }
}
