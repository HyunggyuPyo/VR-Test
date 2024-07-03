using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerAnimation : MonoBehaviour
{
    public Transform trigger;
    public Transform bumper;
    public Transform TumbA;
    public Transform TumbB;

    public void TriggerActivate(bool isPush)
    {
        trigger.transform.Rotate(isPush ? -10 : 10, 0, 0);

    }

    public void BumperActivate(InputAction.CallbackContext contex)
    {
        bumper.transform.Translate(contex.performed ? 0.002f : -0.002f, 0, 0);
    }

    public void BtnAActivate(InputAction.CallbackContext contex)
    {
        TumbA.transform.Translate(0, contex.performed ? 0.0011f : -0.0011f, 0);
    }

    public void BtnBActivate(InputAction.CallbackContext contex)
    {
        TumbB.transform.Translate(0, contex.performed ? 0.0011f : -0.0011f, 0);
    }
}