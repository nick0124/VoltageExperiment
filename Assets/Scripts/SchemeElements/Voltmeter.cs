using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voltmeter : MonoBehaviour {

    public float mult;
    public GameObject arrow;

    public float voltage;
    public Ampermeter ampermeter;
    public Resistor resistor;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//вольты = сила тока * сопротивление
        voltage = ampermeter.amperage * resistor.resistance;

        float curVal = Mathf.Clamp(voltage, 0, 50);
        arrow.transform.localEulerAngles = new Vector3(0, 0, -curVal * mult);
	}
}
