using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Dialogues dialogues;

    public void TriggerDialogues()
    {
        DialogManager.Instance.StartDialogs(dialogues);
    }
}
