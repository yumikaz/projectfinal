using System.Collections;

using UnityEngine;

public class PlayerController : MonoBehaviour {
    
    public int Speed = 5;
    public int RunSpeed = 10;
    private Vector3 DirectionDeplacement = Vector3.zero;
    private CharacterController player;
    //public int jump = 5;
    public int sensi;
    public int gravite = 20;
    private Animator Anim;
    // Update is called once per frame
    void Start()

    {
        player = GetComponent<CharacterController>();
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {


        

        DirectionDeplacement.z = Input.GetAxisRaw("Vertical");
        DirectionDeplacement.x = Input.GetAxisRaw("Horizontal");
       
        DirectionDeplacement = transform.TransformDirection(DirectionDeplacement);
        player.Move(DirectionDeplacement * Time.deltaTime * Speed);
        //transform.Rotate(0, Input.GetAxisRaw("Mouse x")* sensi, 0);

        // deplacement 

        if (Input.GetKey(KeyCode.LeftShift))
        {


            player.Move(DirectionDeplacement * Time.deltaTime * RunSpeed);

            }else
            {
                player.Move(DirectionDeplacement * Time.deltaTime * Speed);
            }

            // transform.Rotate(0, Input.GetAxisRaw("Mouse X") * sensi, 0);
            // saut


            // gravité

            if (player.isGrounded)

                DirectionDeplacement.y -= gravite * Time.deltaTime;

            // animation

            if (Input.GetKey(KeyCode.W))
            {
                Anim.SetBool("walk",true);
                Anim.SetBool("Run", false);

            }

            if (Input.GetKey(KeyCode.W) & Input.GetKey(KeyCode.LeftShift))
            {
                Anim.SetBool("walk", false);
                Anim.SetBool("Run", true);

            }



        }

    }

