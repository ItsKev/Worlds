using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour {

    [SerializeField] private GameController gameController;

	// Use this for initialization
	void Start () {
        gameController.ThrowAxe += GameController_ThrowAxe;
	}

    private void GameController_ThrowAxe()
    {
        StartCoroutine(RespawnAxe());
    }

    private IEnumerator RespawnAxe()
    {
        yield return new WaitForSeconds(2);
        transform.position = new Vector3(0, 1, 0.5f);
        transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
}
