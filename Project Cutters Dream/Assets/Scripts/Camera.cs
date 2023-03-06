using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    public float mouseSent = 2f;
    float cameraVerRo = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Mouse X") * mouseSent;
        float inputY = Input.GetAxis("Mouse Y") * mouseSent;

        cameraVerRo -= inputY;
        cameraVerRo = Mathf.Clamp(cameraVerRo, -90f, 90f);
        transform.localEulerAngles = Vector3.right * cameraVerRo;

        player.Rotate(Vector3.up * inputX);
    }
}
