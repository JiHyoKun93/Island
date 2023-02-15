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
[CreateAssetMenu(fileName = "CraftingData", menuName = "ScriptableObjects/CraftingScriptableObject", order = 2)]
public class CraftingData : ScriptableObject {

    public string itemName;
    public int maxHp = 3;

    public List<Sprite> spriteImage = new List<Sprite>();

    public string getName() {
        return itemName;
    }
    public Sprite getSprite(int index) {
        return spriteImage[index];
    }
}