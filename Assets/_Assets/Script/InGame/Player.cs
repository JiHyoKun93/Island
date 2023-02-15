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

public enum PlayerState {
	MOVE, MINING, DIG, DIE, STOP
}

public enum PlayerWeapon {
	NONE, SWORD, PICK, AXE, FISHING, SHOVEL, WATER
}

public class Player : Singleton<Player>{

	[Header("플레이어 컴포넌트")]
	protected SpriteRenderer renderer;
	protected Rigidbody2D rigidbody;
	protected Animator animator;

	protected Vector2 MoveDir;

	public PlayerState state;
	public PlayerWeapon weapon;

	[Header("플레이어 스탯")]
	[SerializeField] protected float Speed;

	private void Start() {
		rigidbody = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
		renderer = GetComponent<SpriteRenderer>();
	}



}