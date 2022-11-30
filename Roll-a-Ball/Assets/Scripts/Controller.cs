using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    private RigidBody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = getComponet... // we will continue tmr
    }
    void Onmove(InputValue movementValue)
    {
        // the Functions body move
        Vector2 movementValue = movementValue.Get<Vector2>();

    }
}
