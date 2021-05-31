using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryScript : MonoBehaviour
{
    public GameObject textPrefab;
    public GameObject inventoryPanel;
    public GameObject content;

    bool inventoryShowing = false;

    // ADD CODE HERE

    // END OF CODE

    void Start()
    {
        inventoryShowing = false;
        inventoryPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            if(inventoryShowing)
            {
                inventoryShowing = false;
                inventoryPanel.SetActive(false);
            }
            else
            {
                inventoryShowing = true;
                inventoryPanel.SetActive(true); 
                UpdateInventory();
            }
        }
    }

    public void DeleteOldItems()
    {
        var items = new List<GameObject>();
        foreach (Transform item in content.transform) items.Add(item.gameObject);
        items.ForEach(item => Destroy(item));
    }

    public void UpdateInventory()
    {
        DeleteOldItems();
        // ADD CODE HERE

        // END OF CODE
    }

    private void OnTriggerEnter(Collider other) 
    {
        // ADD CODE HERE

        // END OF CODE
    }
}
