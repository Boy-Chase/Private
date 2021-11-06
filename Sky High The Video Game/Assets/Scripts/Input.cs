using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Input : MonoBehaviour
{
    private Vector2 playerInput;
    public Vector2 willPos;

    // Start is called before the first frame update
    void Start()
    {
        willPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (0 < playerInput.x)
        {
            // right
            willPos = (new Vector2(-0.1f, 0f));
        }
        else if (playerInput.x < 0)
        {
            // left
            willPos = (new Vector2(0.1f, 0f));
        }

        if (0 < playerInput.y)
        {
            willPos = (new Vector2(0f, 0.1f));
        }
        else if (playerInput.y < 0)
        {
            willPos = (new Vector2(0f, -0.1f));
        }

        transform.position = willPos;
    }


    public void OnMove(InputValue value)
    {
        playerInput = value.Get<Vector2>();
    }
}
