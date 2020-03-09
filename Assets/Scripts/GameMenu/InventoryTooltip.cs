using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using System;

public class InventoryTooltip : MonoBehaviour
{
    TextMeshProUGUI ToolTipText;
    public GameObject currentSelection;

    private void Awake()
    {
        ToolTipText = GameObject.Find("ToolTipText").GetComponent<TextMeshProUGUI>();
    }
    private void OnEnable()
    {
        StartCoroutine(CheckCollisions());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    public void ShowToolTip()
    {
        if (!ToolTipText.gameObject.activeInHierarchy) ToolTipText.gameObject.SetActive(true);

        SetToolTipText();

        ToolTipText.gameObject.transform.position = Input.mousePosition;


    }

    private void SetToolTipText()
    {
        string information;
        try
        {
            information = currentSelection.GetComponent<IHaveStats>().GetStats();
            ToolTipText.SetText(information);
        }
        catch (Exception e)
        {
            Debug.Log(e.StackTrace);
            information = "Empty " + currentSelection.name;
        }

    }

    private void SetCurrentSelection(GameObject selected)
    {
        currentSelection = selected;
    }

    public void HideToolTip()
    {
        ToolTipText.SetText(string.Empty);
        ToolTipText.gameObject.SetActive(false);
    }

    
    private IEnumerator CheckCollisions()
    {
        while (true)
        {
            bool selectedCurrentFrame = false;

            PointerEventData cursor = new PointerEventData(EventSystem.current);                            // This section prepares a list for all objects hit with the raycast
            cursor.position = Input.mousePosition;
            List<RaycastResult> objectsHit = new List<RaycastResult>();
            EventSystem.current.RaycastAll(cursor, objectsHit);
            foreach (var h in objectsHit)
            {
                if (string.Equals(h.gameObject.tag, "InventorySlot"))
                {
                    selectedCurrentFrame = true;
                    currentSelection = h.gameObject;
                    ShowToolTip();
                    continue;
                }
            }
            if(!selectedCurrentFrame)
            {
            HideToolTip();
            currentSelection = null;
            }

            yield return new WaitForSeconds(.02f);
        }

    }
}
