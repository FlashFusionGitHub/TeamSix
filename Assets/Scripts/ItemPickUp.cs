using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPickUp : MonoBehaviour
{
    public Text KeysCollectedText;
    public Text AmmoText;
    public Text PickUpText;
    private int numberOfKeys = 1;
    private int ammoCount;
    private int maxAmmo = 30;
    bool Destroyed;

    void Start()
    {
        KeysCollectedText.text = "Keys Collected: 0";
        AmmoText.text = "Ammo: " + ammoCount;
        Destroyed = false;
    }

    void Update()
    {
        if (Destroyed == true)
        {
            numberOfKeys += 1;
            Destroyed = false;
        }

        Shoot();
    }


    void Shoot()
    {
        if(Input.GetMouseButtonDown(0) && ammoCount > 0)
        {
            ammoCount -= 1;
            AmmoText.text = "Ammo: " + ammoCount;
        }
        return;
    }

    void OnTriggerStay(Collider hit)
    {
        if (hit.tag == "Key")
        {
            PickUpText.text = "Press 'E' to collect key";
            if (Input.GetKey(KeyCode.E))
            {
                Destroy(hit.gameObject);
                Destroyed = true;
                KeysCollectedText.text = "Keys Collected: " + numberOfKeys;
                PickUpText.text = "";
            }
        }
    }

    void OnTriggerEnter(Collider hit)
    {
        if (hit.tag == "Ammo")
        {
            if (ammoCount < maxAmmo)
            {
                ammoCount += 6;

                if (ammoCount > maxAmmo)
                    ammoCount = maxAmmo;

                AmmoText.text = "Ammo: " + ammoCount;
                Destroy(hit.gameObject);
            }
            else
                return;
        }
    }

    void OnTriggerExit(Collider hit)
    {
        PickUpText.text = "";
    }
}
