using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    GameObject spellContainer;

    private void Start()
    {
        spellContainer = GameObject.Find("SpellContainer");

        var spellButtons = spellContainer.GetComponentsInChildren<Button>();
        foreach(var s in spellButtons)
        {
            s.onClick.AddListener(s.gameObject.GetComponent<Spell>().Cast);
        }

    }




}
