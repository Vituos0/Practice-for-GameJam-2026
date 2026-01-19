using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{


    [Header("Settings")]

    [SerializeField] private float ascentForece = 15f; //force to pull player up when using anti-gravity suit
  //  [SerializeField] private float maxAscentSpeed = 10f; //max fly up speed
  //  [SerializeField] private float heavyGravity = 5f;   //gravity when using gravity enhancer
    [SerializeField] private float normalGravity = 1f;  //normal gravity
   // private bool isUsingGravityEnhancer = false;
    private bool isUsingAGSuit = false;

    [Header("Components")]
    private Rigidbody2D rb;

    private void Awake()
    {
    }



    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        rb.gravityScale= normalGravity;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void FixedUpdate()
    {
        Movement();
    }

    private void LateUpdate()
    {
        
    }

    private void Movement()
    {
        if (isUsingAGSuit) //using Anti-gravity suit
        {
            rb.gravityScale = .25f;
          //  if(rb.velocity.y < maxAscentSpeed)
            rb.AddForce(Vector2.up * ascentForece, ForceMode2D.Force);  //player is pulled up

        }
        else   //not using gravity enhancer
        {
            rb.gravityScale = normalGravity;                            //give back normal gravity
        }
    }


    public void MouseDownCallBack()
    {
        isUsingAGSuit = true;
    }
    public void MouseDragCallBack()
    {

    }
    public void MouseUpCallBack()
    {
        isUsingAGSuit = false;
    }

}
