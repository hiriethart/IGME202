using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        if (GameObject.Find("ClockHand").GetComponent<RotateHand>().enabled == false)
        {
            GameObject.Find("ClockHand").GetComponent<RotateHand>().enabled = true;
        }
        else
        {
            GameObject.Find("ClockHand").GetComponent<RotateHand>().enabled = false;
        }               

    }
}
