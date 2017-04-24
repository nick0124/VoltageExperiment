using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWire : MonoBehaviour {

    public LineRenderer line;
    private Vector2 mouseWorldPos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonUp(0))
        {
            Vector3 mouseWorldPos3D = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPos = new Vector2(mouseWorldPos3D.x, mouseWorldPos3D.y);

            line.numPositions = line.numPositions + 1;
            line.SetPosition(line.numPositions-1,mouseWorldPos);
        }
	}
}
