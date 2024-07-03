using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(ActionBasedController))]
public class RightLauncher : MonoBehaviour
{
    private ActionBasedController targetCont;
    private InputActionReference activateRef;
    private LauncherAnimation contAnim;

    private IEnumerator Start()
    {
        yield return new WaitForEndOfFrame();
        contAnim = GetComponentInChildren<LauncherAnimation>();

        activateRef = targetCont.activateAction.reference;

        activateRef.action.performed += delegate (InputAction.CallbackContext context)
        {
            contAnim.TriggerActivate(context.performed);
        };

        activateRef.action.canceled += delegate (InputAction.CallbackContext context)
        {
            contAnim.TriggerActivate(context.performed);
        };

    }

    private void Awake()
    {
        targetCont = GetComponent<ActionBasedController>();
    }
}
