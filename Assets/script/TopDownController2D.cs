using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController2D : MonoBehaviour
{
	Vector2 movement;
	Vector2 mousePos;
	public float moveSpeed = 3f;
	Rigidbody2D rb2d;
	// Update is called once per frame
	
	void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();
	}
	void Update()
	{
		movement.x = Input.GetAxisRaw("Horizontal");
		movement.y = Input.GetAxisRaw("Vertical");

		mousePos = Camera.main.ScreenPointToRay(Input.mousePosition).origin;
	}
	private void FixedUpdate()
	{
		rb2d.MovePosition(rb2d.position + movement * moveSpeed * Time.fixedDeltaTime);

		//Vector Math stuff ...
		Vector2 lookDir = mousePos - rb2d.position;
		float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
		rb2d.rotation = angle;
	}
}
