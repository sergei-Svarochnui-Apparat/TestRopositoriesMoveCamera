using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMouseControl : MonoBehaviour
{
    private Vector2 XYRotation;
    [SerializeField] private Transform _playerCamera;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 MoveInput = new Vector2
        {
            x = Input.GetAxis("Mouse X"),
            y = Input.GetAxis("Mouse Y")
        };
        XYRotation.x -= MoveInput.y;
        XYRotation.y += MoveInput.x;

        transform.eulerAngles = new Vector3(0, XYRotation.y,0);
        _playerCamera.localEulerAngles = new Vector3(XYRotation.x, 0, 0);
    }
}
