using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;
using DG.Tweening;
using Unity.VisualScripting;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class Crafting : MonoBehaviour {
    public CraftingData craftData;
    SpriteRenderer spriterenderer;
    BoxCollider2D collider;

    public int hp;
    private void Start() {
        collider = GetComponent<BoxCollider2D>();
        spriterenderer = GetComponent<SpriteRenderer>();
        spriterenderer.sprite = craftData.getSprite(0);
        hp = craftData.maxHp;
    }
    void Damege() {
        Debug.Log("Ore Hit");
        hp--;

        if(hp <= 0) {
            gameObject.SetActive(false);
        }

        if (hp.Equals(1)) {
            spriterenderer.sprite = craftData.getSprite(2);
        }
        else if (hp != craftData.maxHp) {
            spriterenderer.sprite = craftData.getSprite(1);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Player")) {
            Damege();
        }
    }
}