using UnityEngine;
public class MouseManager : MonoBehaviour
{
    private void OnApplicationFocus(bool focus)
    {
        Cursor.visible = focus;

        if (focus) Cursor.lockState = CursorLockMode.Locked;
        else Cursor.lockState = CursorLockMode.None;
    }
}
