using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class EventTest : MonoBehaviour
{
    private XRBaseControllerInteractor interactor;
    private void Awake()
    {
        int count = 0;
        interactor = GetComponent<XRBaseControllerInteractor>();
        interactor.selectEntered.AddListener
            (
                (args) => {
                    XREventCall(args, count++);
                }
            );
    }

    public void XREventCall(BaseInteractionEventArgs args, int count) //args -> arguments�� ����
    {
        print($"{args.interactableObject.transform.name} �� {count} �� ȣ�� ��.");
    }
}
