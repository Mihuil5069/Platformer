using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class MonsterAI : MonoBehaviour
{
    public int speed = 3;
    private SpriteRenderer sprite;
    private int direction = -1;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        sprite.flipX = direction > 0;
    }

    void Update()
    {
        transform.Translate(Vector2.right * direction * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Border"))
        {
            direction *= -1;
            sprite.flipX = direction > 0;
        }
    }
}