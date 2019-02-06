using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Controller : MonoBehaviour {

    [SerializeField] private GameController gameController;
    private GameObject objectInHand;
   
    private void Start()
    {
        gameController.ThrowAxe += GameController_ThrowAxe;
    }

    private void GameController_ThrowAxe()
    {
        ReleaseObject();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (objectInHand == null)
        {
            objectInHand = other.gameObject;
            objectInHand.transform.SetParent(gameObject.transform);
        }
    }

    private void ReleaseObject()
    {
        if (objectInHand != null)
        {
            objectInHand.gameObject.transform.SetParent(null);
            objectInHand.GetComponent<Rigidbody>().velocity = GetComponent<SteamVR_Behaviour_Pose>().GetVelocity() * 2;
            objectInHand = null;
        }
    }
}
