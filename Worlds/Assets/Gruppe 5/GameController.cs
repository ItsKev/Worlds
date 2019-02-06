using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class GameController : MonoBehaviour {

    [SerializeField] private SteamVR_Action_Boolean throw_Button;

    public event Action ThrowAxe = delegate { };

	// Use this for initialization
	void Start () {

        throw_Button.onChange += OnStateChange;

    }

    private void OnStateChange(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource, bool newState)
    {
       
    }

    // Update is called once per frame
    void Update () {
        if(throw_Button.GetStateUp(SteamVR_Input_Sources.Any))
        {
            ThrowAxe();
        }
    }
}
