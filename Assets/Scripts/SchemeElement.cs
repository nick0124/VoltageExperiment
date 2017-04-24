using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchemeElement : MonoBehaviour {

    public bool isDragging;
    public ElementCreator elementCreator;
    private Vector2 mouseWorldPos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if(Input.GetMouseButtonUp(0))
            isDragging = false;

        if(isDragging)
        {
            Vector3 mouseWorldPos3D = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPos = new Vector2(mouseWorldPos3D.x, mouseWorldPos3D.y);

            transform.position = new Vector3(mouseWorldPos.x, mouseWorldPos.y, transform.position.z);
        }
	}

    void OnMouseDown()
    {
        isDragging = true;
    }

    public void Delete()
    {
        elementCreator.elementsCount++;
        elementCreator.UpdateText();
        Destroy(gameObject);
    }
}
