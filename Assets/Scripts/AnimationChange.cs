using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationChange : MonoBehaviour
{
    public Animator Player;
    private bool OnGround;
    private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<PlayerController>();
        OnGround = playerController.OnGround;
    }

    // Update is called once per frame
    void Update()
    {
        OnGround = playerController.OnGround;
        if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A)) && OnGround == true)
        {
            Player.SetBool("Run", true);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Player.SetTrigger("Jump");
        }
        else
        {
            Player.SetBool("Run", false);
        }
    }
}
