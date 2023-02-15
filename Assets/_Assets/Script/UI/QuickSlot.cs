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

public class QuickSlot : MonoBehaviour{

    Player player;

    void Start(){
        player = Player.Instance;
    }

    public void OnClickSowrd() {
		player.weapon = PlayerWeapon.SWORD;
	}
	public void OnClickPick() {
		player.weapon = PlayerWeapon.PICK;
	}
	public void OnClickAxe() {
		player.weapon = PlayerWeapon.AXE;
	}
	public void OnClickFishing() {
		player.weapon = PlayerWeapon.FISHING;
	}
	public void OnClickShovel() {
		player.weapon = PlayerWeapon.SHOVEL;
	}
	public void OnClickWater() {
		player.weapon = PlayerWeapon.WATER;
	}
}