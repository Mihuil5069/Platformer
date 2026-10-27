using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed = 20;
    public int force = 7;
    private SpriteRenderer sprite;
    private Rigidbody2D rb;
    public bool OnGround;
    private AudioSource audioSource;
    public AudioClip Sound_01;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * Time.deltaTime * speed * horizontal);
        sprite.flipX = horizontal < 0;
        if (Input.GetKeyDown(KeyCode.Space) && OnGround == true)
        {
            rb.AddForce(Vector2.up * force, ForceMode2D.Impulse);
            OnGround = false;
            audioSource.PlayOneShot(Sound_01, 1f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            OnGround = true;
        }
    }
    

    


}