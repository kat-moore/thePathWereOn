using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;



[RequireComponent(typeof(FadeAway))]
public class TextManager : MonoBehaviour {
    GameObject title;
    GameObject Bullet1;
    GameObject Bullet2;
    GameObject Bullet3;
    GameObject Bullet4;
    GameObject Bullet5;
    GameObject Bullet6;

    // Use this for initialization
    void Start ()
    {
        string localTitle = title.GetComponent<Text>().text;
        localTitle.ToString();  //initializes  
	}
	
	// Update is called once per frame
	void Update () {
        string localTitle = title.GetComponent<Text>().text;
        localTitle.ToString();  //initializes  
        //title.GetComponent<FadeAway>.Start();

    }
}
