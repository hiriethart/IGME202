using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHand : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        RotateToMouse();
    }

void RotateToMouse()
    {
        Vector3 mouseworldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float rawAngle = Mathf.Atan2(mouseworldPos.y, mouseworldPos.x)* Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rawAngle + 180);
    }
}
