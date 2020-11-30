using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Slot : MonoBehaviour, IPointerClickHandler
{
    public GameObject item;
    public Transform slotIcon;
    public int ID;
    public string descrip;
    public string type;
    public bool empty;
    public Sprite icon;

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        UseItem();
    }

    public void Start()
    {
        slotIcon = transform.GetChild(0);
    }

    public void UpdateSlot()
    {
        slotIcon.GetComponent<Image>().sprite = icon;

    }

    public void UseItem()
    {
        item.GetComponent<Item>().ItemUsage();
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
