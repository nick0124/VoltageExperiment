using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ampermeter : MonoBehaviour {

    public float mult;
    public GameObject arrow;

    public float amperage;
    public Reostat reostat;
    public Source source;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (source.voltage > 0)
        {
            amperage = source.voltage / reostat.resistance;
            float curVal = Mathf.Clamp(amperage, 0, 5);
            arrow.transform.localEulerAngles = new Vector3(0, 0, -curVal * mult);
        }
        else
        {
            arrow.transform.localEulerAngles = new Vector3(0, 0, 0);
            amperage = 0;
        }
	}
}
