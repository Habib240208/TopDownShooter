using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
	public Transform player;
	Vector2 dir;
	public Rigidbody2D rb;
	public float speed = 2f;
	// Start is called before the first frame update
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		player = GameObject.Find("Player").transform;

	}
	private void Update()
	{
		if (player)
			dir = (player.position - transform.position).normalized;

		rb.velocity = dir * speed;
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		rb.rotation = angle;
	}

}
