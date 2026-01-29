using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fader : MonoBehaviour
{   
    private Animator animator;
    private int lvlToLoad;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void FadeToLevel(int levelIndex)
    {
        lvlToLoad = levelIndex;
        animator.SetTrigger("Fade");
    }
}
