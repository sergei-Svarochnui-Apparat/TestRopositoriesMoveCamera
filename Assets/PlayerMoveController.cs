using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveController : MonoBehaviour
{
    public int MoveSpeed;
    private CharacterController characterController;
    private Vector3 _currentVelocity;
    private Vector3 smoothDamp;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
       
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 PlayerInput = new Vector3(x, 0f, z);

        Vector3 moveVector = transform.TransformDirection(PlayerInput).normalized;

        _currentVelocity = Vector3.SmoothDamp(_currentVelocity, moveVector * MoveSpeed, ref smoothDamp);

        characterController.Move(moveVector * Time.timeScale );
        //print(Input.GetAxisRaw("Horizontal"));
    }
}
