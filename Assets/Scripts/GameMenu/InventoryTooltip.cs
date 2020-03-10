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

    private bool waitsForClick = false;


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
        if (currentSelection == null) return;
        string information;
        information = currentSelection.GetComponent<IBonusStats>().GetStats();
        ToolTipText.SetText(information);


    }

    public void HideToolTip()
    {
        ToolTipText.SetText(string.Empty);
        ToolTipText.gameObject.SetActive(false);
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            waitsForClick = false;
        }
        if(Input.touchCount != 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            waitsForClick = false;
        }

    }

    private IEnumerator CheckCollisions()
    {
        while (true)
        {
            while (waitsForClick) yield return null;
            bool selectedCurrentFrame = false;

            PointerEventData cursor = new PointerEventData(EventSystem.current)
            {
                position = Input.mousePosition
            };                            // This section prepares a list for all objects hit with the raycast
            List<RaycastResult> objectsHit = new List<RaycastResult>();
            EventSystem.current.RaycastAll(cursor, objectsHit);
            foreach (var h in objectsHit)
            {
                if (h.gameObject.CompareTag("InventorySlot"))
                {
                    selectedCurrentFrame = true;
                    if(ReferenceEquals(currentSelection, h.gameObject))
                    {
                        HideToolTip();
                        currentSelection = null;
                        waitsForClick = true;
                        continue;
                    }

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
            waitsForClick = true;
            yield return new WaitForSeconds(.02f);
        }

    }

}
