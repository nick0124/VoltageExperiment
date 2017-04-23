using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reostat : MonoBehaviour {

    public Slider reostatSlider;
    public float resistance;
    public Text text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        resistance = reostatSlider.value;
        text.text = resistance.ToString();
	}
}
