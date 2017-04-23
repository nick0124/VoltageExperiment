using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Source : MonoBehaviour {

    public float voltage;

    public float sourceVoltage;
    public Key key;
    public SchemeAseemblyCheck schemeChecker;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (key.isEnable && schemeChecker.schemeIsCorrect)
            voltage = sourceVoltage;
        else
            voltage = 0;
	}
}
