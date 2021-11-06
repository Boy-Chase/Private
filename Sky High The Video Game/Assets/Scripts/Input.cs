using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Input : MonoBehaviour
{
    private Vector2 playerInput;
    private bool onGround;
    
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        if (0 < playerInput.x)
        {
            // right
            transform.Translate(new Vector3(0.05f, 0.0f, 0.0f));       
        }
        else if (playerInput.x < 0)
        {
            // left
            transform.Translate(new Vector3(-0.05f, 0.0f, 0.0f));
        }

        if (0 < playerInput.y)
        {
            // right
            transform.Translate(new Vector3(0.0f, 0.05f, 0.0f));
        }
        else if (playerInput.y < 0)
        {
            // left
            transform.Translate(new Vector3(0.0f, -0.05f, 0.0f));
        }
    }


    public void OnMove(InputValue value)
    {
        playerInput = value.Get<Vector2>();
    }
}
