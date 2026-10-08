using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using UnityEngine.InputSystem;


public class movimiento : MonoBehaviour
{
    Vector2 moveInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        Debug.Log("Movimiento: " + moveInput);
        moveInput = moveInput.normalized * 0.02f;
        transform.position += new Vector3(moveInput.x, 0, 0);

    }
    public void OnMove1(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        Debug.Log("Movimiento: " + moveInput);
        moveInput = moveInput.normalized * 0.02f;
        transform.position += new Vector3(0, moveInput.y, 0);

    }
    /*public void OnMove2(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        Debug.Log("Movimiento: " + moveInput);
        moveInput = moveInput.normalized * 0.02f;
        transform.position += new Vector3(moveInput.x, 0, 0);
        transform.position += new Vector3(0, moveInput.y, 0);

    }
    public void OnMove3(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        Debug.Log("Movimiento: " + moveInput);
        moveInput = moveInput.normalized * 0.02f;
        transform.position += new Vector3(moveInput.x, 0, 0);
        transform.position += new Vector3(0, moveInput.y, 0);

    }*/
}
