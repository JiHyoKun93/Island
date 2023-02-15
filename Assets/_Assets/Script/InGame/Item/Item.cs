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

public class Item : MonoBehaviour {
    ItemData itemData;
    SpriteRenderer spriteRenderer;
    private void Start() {
        spriteRenderer.sprite = itemData.spriteImage;
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        // «√∑π¿ÃæÓ∞° ¥Íæ“¿∏∏È æ∆¿Ã≈€ »πµÊ
    }
}