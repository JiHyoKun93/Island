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

[CreateAssetMenu(fileName = "ItemData", menuName = "ScriptableObjects/ItemScriptableObject", order = 1)]
public class ItemData : ScriptableObject {
    public string itemName;

    public Sprite spriteImage;

    public string getName() {
        return itemName;
    }

}