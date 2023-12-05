using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManagement : MonoBehaviour
{
    void Start()
    {
        // Ensure the cursor is unlocked and visible when entering any scene
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
