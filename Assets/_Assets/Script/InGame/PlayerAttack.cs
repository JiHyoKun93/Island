using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;
using DG.Tweening;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class PlayerAttack : Player{
    
    float attackTime;

    void Update(){
        if (Input.GetKeyUp(KeyCode.Space)) {
            InputAttack();
        }
    }

    void FixedUpdate() {
        Debug.Log(weapon.ToString());
    }

    void InputAttack() {
        
		switch (weapon) {
			case PlayerWeapon.SWORD: {
					animator.SetTrigger("sword");
					break;
				}
			case PlayerWeapon.PICK: {
					animator.SetTrigger("pick");
					break;
				}
			case PlayerWeapon.AXE: {
					animator.SetTrigger("axe");
					break;
				}
			case PlayerWeapon.FISHING: {

					break;
				}
			case PlayerWeapon.SHOVEL: {
					animator.SetTrigger("dig");
					break;
				}
			case PlayerWeapon.WATER: {
					animator.SetTrigger("water");
					break;
				}
			default: {
					break;
				}
		}
	}

}