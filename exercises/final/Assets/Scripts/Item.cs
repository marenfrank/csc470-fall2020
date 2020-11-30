using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int ID;
    public string descrip; 
    public string type;
    public Sprite icon;
    public bool pickedUp;

    [HideInInspector]
    public bool equipped;

    
    [HideInInspector]
    public GameObject weapon;

    [HideInInspector]
    public GameObject weaponManager; 

    public bool playersWeapon;

    

    public void Start()
    {
        weaponManager = GameObject.FindWithTag("WeaponManager");

        if (!playersWeapon)
        {
            int allWeapons = weaponManager.transform.childCount;
            for(int i = 0; i < allWeapons; i++)
            {
                if(weaponManager.transform.GetChild(i).gameObject.GetComponent<Item>().ID == ID)
                {
                    weapon = weaponManager.transform.GetChild(i).gameObject;
                }
            }
        }
    }

    public void Update()
    {
        if(equipped)
        {
            //weapon actions here
            // this.gameObject.SetActive(true);

            if (Input.GetKeyDown(KeyCode.G))
            {
                equipped = false;
            }

            if(equipped == false)
            {
                this.gameObject.SetActive(false);
            }
        }
    }

    public void ItemUsage()
    {
        //weapon
        if (type == "weapon")
        {
            weapon.gameObject.SetActive(true);
            weapon.GetComponent<Item>().equipped = true;

        }


        //health

        //protection


    }
}
