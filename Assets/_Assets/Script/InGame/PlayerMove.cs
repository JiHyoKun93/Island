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

public class PlayerMove : Player {
	
    void Update() {
		Move();
    }

    void FixedUpdate() {
		rigidbody.velocity = MoveDir;
    }
	
	void Move() {
	
		float hor = Input.GetAxisRaw("Horizontal");
		float ver = Input.GetAxisRaw("Vertical");
	
		MoveDir.x = hor * Speed;
		MoveDir.y = ver * Speed;
	}
}