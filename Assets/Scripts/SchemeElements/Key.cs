using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    public bool isEnable;

    public Sprite enableImage;
    public Sprite disableImage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        isEnable = !isEnable;

        if(isEnable)
            gameObject.GetComponent<SpriteRenderer>().sprite = enableImage;
        else
            gameObject.GetComponent<SpriteRenderer>().sprite = disableImage;
    }
}
