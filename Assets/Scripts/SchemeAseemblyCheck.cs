using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchemeAseemblyCheck : MonoBehaviour {

    public bool schemeIsCorrect;

    public List<GameObject> objectsToDisableWhenComplete;
    public List<GameObject> objectsToEnableWhenComplete;

    public List<GameObject> wires;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CheckScheme()
    {
        schemeIsCorrect = true;
        foreach (GameObject wire in wires)
        {
            if(wire.activeSelf == false)
            {
                schemeIsCorrect = false;
                break;
            }
        }

        if (schemeIsCorrect)
        {
            foreach (GameObject obj in objectsToDisableWhenComplete)
            {
                obj.SetActive(false);
            }
            foreach (GameObject obj in objectsToEnableWhenComplete)
            {
                obj.SetActive(true);
            }
        }
        else
        {
            Debug.Log("Scheme wrong");
        }
    }
}
