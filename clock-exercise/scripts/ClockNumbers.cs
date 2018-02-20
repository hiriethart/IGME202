using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockNumbers : MonoBehaviour {
    public Transform theNumber;
    public GameObject gameob;
   
    // Use this for initialization
    void Start()
    {
        float x;
        float y;
        int number = 1; //starting at 1:00;

        List<string> numblist = new List<string>();
        numblist.Add("");
        numblist.Add("2");
        numblist.Add("3");
        numblist.Add("4");
        numblist.Add("5");
        numblist.Add("6");
        numblist.Add("7");
        numblist.Add("8");
        numblist.Add("9");
        numblist.Add("10");
        numblist.Add("11");
        numblist.Add("12");
        numblist.Add("1");


        for (int a = 60; a >= -270; a -= 30)
        { //start at 1 proceed clockwise to 12

            //x and y from cos and sin. z will be theta
            x = 14f;
            y = 14f;

            x = x*Mathf.Cos(a * Mathf.Deg2Rad);
            y = y*Mathf.Sin(a * Mathf.Deg2Rad);
            
            Vector3 pos = new Vector3(x, y, 0);
            //make a theNumber so on screen, return G,O, so we can change the text

            Transform t = Instantiate(theNumber, new Vector3(x,y,0),Quaternion.identity);
            GameObject numGO = t.gameObject;          

            numGO = GameObject.Find("ClockNumber");
            Debug.Log(numGO.GetComponentInChildren<ClockNumbers>());
            numGO.GetComponentInChildren<TextMesh>().text = numblist[number];
            //numGO.GetComponentInChildren<>().GetComponent<TextMesh>().text = numblist[number];
            number++;
        }
    }
	
	// Update is called once per frame
	void Update () {
       
	}
}
