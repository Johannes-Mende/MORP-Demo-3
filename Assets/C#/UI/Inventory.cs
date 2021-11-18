using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

    public struct Item
    {
        public string Name;
        public Sprite Picture;
        public  int Count;
        public string Content;
    }
    
    public int MaxCountInv = 10;
    public List<Item> Items = new List<Item>();
    public GameObject ItemPrefab;

    void Awake() 
    {
        ItemPrefab.SetActive(false);
        
    }

    public void Collect(Item i)
    {
        Items.Add(i);
        GameObject g = Instantiate(ItemPrefab, ItemPrefab.transform.parent);                //g ist eine temporäre Variable
        g.GetComponent<ItemPrefab>().ItemText.GetComponent<Text>().text  = i.Name;          //wir übergeben von g zu i
        g.GetComponent<ItemPrefab>().ItemImage.GetComponent<Image>().sprite = i.Picture;
        g.SetActive(true);
    }
}
