using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRTest : MonoBehaviour
{
    public void Print(string message) => print(message);

    public void FirstSelectEnterEvent(SelectEnterEventArgs args)
    {
        print($"{args.interactableObject.transform.name}" + 
            $"first selected by {args.interactableObject.transform.parent.name}");
    }
    public void LastSelectEnterEvent(SelectExitEventArgs args)
    {
        print($"{args.interactableObject.transform.name}" +
            $"´Â {args.interactableObject.transform.parent.name} ¿¡°Ô ¸¶Áö¸·À¸·Î ¼±ÅÃÇØÁ¦ µÊ");
    }
    public void SelectEnterEvent(SelectEnterEventArgs args)
    {
        print($"{args.interactableObject.transform.name}" +
            $"´Â {args.interactableObject.transform.parent.name} ¿¡°Ô ¼±ÅÃµÊ");
    }
    public void SelectExitEvent(SelectExitEventArgs args)
    {
        print($"{args.interactableObject.transform.name}" +
            $"´Â {args.interactableObject.transform.parent.name} ¿¡°Ô ¼±ÅÃÇØÁ¦ µÊ");
    }

    public void ActivateEvent(BaseInteractionEventArgs args)
    {
        if (args.GetType() == typeof(ActivateEventArgs))
        {
            print("»§");
        }
        else if(args.GetType() == typeof(DeactivateEventArgs))
        {
            print("ÂûÄ¬");
        }
        else
        {
            print("¸Å¤Ó·Õ");
        }
    }
}
