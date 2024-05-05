using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScannedItemsManager : MonoBehaviour
{
    public List<GameObject> scannedItems = new List<GameObject>();
    public Text scannedItemsText;

    public void AddScannedItem(GameObject item)
    {
        scannedItems.Add(item);
        UpdateScannedItemsText();
    }

    void UpdateScannedItemsText()
    {
        string text = "Scanned Items:\n";
        foreach (var item in scannedItems)
        {
            text += "- " + item.name + "\n";
        }
        scannedItemsText.text = text;
    }
}