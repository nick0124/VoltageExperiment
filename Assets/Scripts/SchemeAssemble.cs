using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchemeAssemble : MonoBehaviour {

    public GameObject sourceToReostatWire;
    public GameObject reostatToAmpermeterWire;
    public GameObject ampermeterToResistorWire;
    public GameObject resitorToKeyWire;
    public GameObject keyToSourceWire;
    public GameObject toVoltmeterWire;
    public GameObject fromVoltmeterWire;


    public GameObject mouseDownObj;
    public GameObject mouseUpObj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 mouseWorldPos3D = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mouseWorldPos3D.x, mouseWorldPos3D.y);


        
		if(Input.GetMouseButtonDown(0))
        {
            mouseDownObj = null;
            mouseUpObj = null;

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, -Vector2.up);
            if (hit.collider != null)
            {
                Debug.Log(hit.collider.gameObject.name);
                mouseDownObj = hit.collider.gameObject;
            }
        }

        if(Input.GetMouseButtonUp(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, -Vector2.up);
            if (hit.collider != null)
            {
                Debug.Log(hit.collider.gameObject.name);
                mouseUpObj = hit.collider.gameObject;
            }

            CheckCorrection();
        }
	}

    private void CheckCorrection()
    {
        if (mouseDownObj != null && mouseUpObj != null)
        {
            if (mouseDownObj.name == "Source" && mouseUpObj.name == "Reostat")
            {
                sourceToReostatWire.SetActive(true);
            }
            else if (mouseDownObj.name == "Reostat" && mouseUpObj.name == "Ampermeter")
            {
                reostatToAmpermeterWire.SetActive(true);
            }
            else if (mouseDownObj.name == "Ampermeter" && mouseUpObj.name == "Resistor")
            {
                ampermeterToResistorWire.SetActive(true);
            }
            else if (mouseDownObj.name == "Resistor" && mouseUpObj.name == "Key")
            {
                resitorToKeyWire.SetActive(true);
            }
            else if (mouseDownObj.name == "Key" && mouseUpObj.name == "Source")
            {
                keyToSourceWire.SetActive(true);
            }
            else if (mouseDownObj.name == "Ampermeter" && mouseUpObj.name == "Voltmeter")
            {
                toVoltmeterWire.SetActive(true);
            }
            else if (mouseDownObj.name == "Voltmeter" && mouseUpObj.name == "Key")
            {
                fromVoltmeterWire.SetActive(true);
            }
        }
    }
}
