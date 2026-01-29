using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public static DialogManager Instance;

    private Queue<Dialogues> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<Dialogues>();
    }

    public void StartDialogs(Dialogues dialogues)
    {
        Debug.Log("Start conversation with" + dialogues.name);
    }

}
