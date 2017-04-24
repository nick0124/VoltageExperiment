using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElementCreator : MonoBehaviour {

    public GameObject elementPrefub;
    public int elementsCount;
    public Text elementsCountTxt;

    void Start()
    {
        UpdateText();
    }

    public void Create()
    {
        if (elementsCount > 0)
        {
            elementsCount--;
            UpdateText();

            GameObject go = (GameObject)Instantiate(elementPrefub);
            go.GetComponent<SchemeElement>().isDragging = true;
            go.GetComponent<SchemeElement>().elementCreator = this;
        }
    }

    public void UpdateText()
    {
        elementsCountTxt.text = elementsCount.ToString();
    }
}
