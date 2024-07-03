using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LauncherAnimation : MonoBehaviour
{
    public Transform trigger;

    public void TriggerActivate(bool isPush)
    {
        trigger.transform.Rotate(0, 0, isPush ? 10 : -10);
    }
}
