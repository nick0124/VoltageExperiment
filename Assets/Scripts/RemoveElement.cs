using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveElement : MonoBehaviour {

    public bool removeEnable = false;

    public void ClickRemoveBtn()
    {
        removeEnable = !removeEnable;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && removeEnable)
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                hit.transform.GetComponent<SchemeElement>().Delete();
            }
        }
    }
}
