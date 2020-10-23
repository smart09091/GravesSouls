﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GravesSouls{
    public class PlayerInventory : MonoBehaviour
    {
        WeaponSlotManager weaponSlotManager;
        public WeaponItem rightWeapon;
        public WeaponItem leftWeapon;

        void Awake(){
            weaponSlotManager = GetComponentInChildren<WeaponSlotManager>();
        }

        void Start(){
            weaponSlotManager.LoadWeaponOnSlot(rightWeapon, false);
            weaponSlotManager.LoadWeaponOnSlot(leftWeapon, true);
        }
    }
}
