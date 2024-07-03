using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

//컨트롤러 입력에 추가 액션을 하도록 만드는 컴포넌트
[RequireComponent(typeof(ActionBasedController))]
public class XRCustomController : MonoBehaviour
{
    private ActionBasedController targetCont;
    private InputActionReference activateRef; // 검지 트리거 버튼
    private InputActionReference selectRef; // 중지 범퍼 버튼
    private ControllerAnimation contAnim;

    public InputActionReference buttonA;
    public InputActionReference buttonB;

    private IEnumerator Start()
    {
        yield return new WaitForEndOfFrame();
        contAnim = GetComponentInChildren<ControllerAnimation>();

        activateRef = targetCont.activateAction.reference;
        selectRef = targetCont.selectAction.reference;

        activateRef.action.performed += delegate (InputAction.CallbackContext context)
        {
            contAnim.TriggerActivate(context.performed);
        };

        activateRef.action.canceled += delegate (InputAction.CallbackContext context)
        {
            contAnim.TriggerActivate(context.performed);
        };
        
        selectRef.action.performed += contAnim.BumperActivate;
        selectRef.action.canceled += contAnim.BumperActivate;

        buttonA.action.performed += contAnim.BtnAActivate;
        buttonA.action.canceled += contAnim.BtnAActivate;

        buttonB.action.performed += contAnim.BtnBActivate;
        buttonB.action.canceled += contAnim.BtnBActivate;
    }


    private void Awake()
    {
        targetCont = GetComponent<ActionBasedController>();
    }
}
