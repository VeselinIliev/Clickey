using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BottomMenuButtons : MonoBehaviour
{
    private Button inventory;
    private Button skills;
    private Button powers;
    private Button info;

    public GameObject inventoryContainer;
    public GameObject skillsContainer;
    public GameObject powersContainer;
    public GameObject playerInfoContainer;



    private void Start()
    {
        inventory = GameObject.Find("Inventory").GetComponent<Button>();
        skills = GameObject.Find("Skills").GetComponent<Button>();
        powers = GameObject.Find("Powers").GetComponent<Button>();
        info = GameObject.Find("PlayerInfo").GetComponent<Button>();

        inventory.onClick.AddListener(() => EnableOnlyOneContainer(inventoryContainer));
        skills.onClick.AddListener(() => EnableOnlyOneContainer(skillsContainer));
        powers.onClick.AddListener(() => EnableOnlyOneContainer(powersContainer));
        info.onClick.AddListener(() => EnableOnlyOneContainer(playerInfoContainer));
        
        //DisableAllContainers();

    }

    
    private void EnableOnlyOneContainer(GameObject container)
    {
        bool state = container.activeInHierarchy;
        DisableAllContainers();
        container.SetActive(!state);
    }

    private void DisableAllContainers()
    {

        inventoryContainer.SetActive(false);
        skillsContainer.SetActive(false);
        powersContainer.SetActive(false);
        playerInfoContainer.SetActive(false);
    }

}
