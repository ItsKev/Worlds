using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {

    [SerializeField] private GameController gameController;

	// Use this for initialization
	void Start () {
        gameController.ThrowAxe += GameController_ThrowAxe;
	}

    private void GameController_ThrowAxe()
    {
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided");
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.transform.SetParent(other.gameObject.transform);
            gameObject.transform.position = Vector3.zero;
        }
    }
}
