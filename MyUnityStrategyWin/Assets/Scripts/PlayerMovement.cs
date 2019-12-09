using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Animations;


public  class PlayerMovement : MonoBehaviour
{
    public float speed = 60f, direction, verticalVelocity;
    Vector3 movement;

    Rigidbody playerRigidbody;
    int floorMask;
    float camRayLenght = 100f;
    bool canJump = false;
    public float jumpHeight;
    public bool isGrounded, isStrafing;
   // protected float groundDistance;
    //AnimatorTransition animatorTransition;
    //public AnimatorController animatorController;
    // // public AnimatorStateMachine aS;
    // public Avatar avatar;
    Animator animator;




    AnimatorController Ac;
    void Awake() 
    {
        animator = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody>();
	    floorMask = LayerMask.GetMask("Plane");
       
    }

	void FixedUpdate(){
        

    float h = Input.GetAxisRaw("Horizontal");
	float v = Input.GetAxisRaw("Vertical");

        salt();

        Move(h,v);
		  
//	Animating(h,v);
        //Turning();



        /*Input.GetAxisRaw("");
        Input.GetAxisRaw("Mouse ScrollWheel");
        Input.GetAxisRaw("MouseS");
        Input.("Jump")  ;
        Input.GetAxisRaw("Fire1") ;
        Input.GetAxisRaw("Fire2") ;
        Input.GetAxisRaw("Fire3") ;
        Input.GetAxisRaw("Submit");
        Input.GetAxisRaw("Cancel");*/

    }




        public virtual void Move(float h, float v)
    {
        animator.SetBool("IsStrafing", isStrafing);
        animator.SetBool("IsGrounded", isGrounded);

        movement.Set(h, 0f, v);
        movement = movement.normalized * speed * Time.deltaTime;
        playerRigidbody.MovePosition(transform.position + movement);


        //


        if (h == -1.00)
        {
            Debug.Log("izquierda");


        }

        if (h == 1.00)
        {
            Debug.Log("derecha");
            //rodar  playerRigidbody.AddForce(Vector3.right* 10.09f); 
            animator.SetFloat("Horizontal", direction, 0.1f, Time.deltaTime);
            //animator.SetTrigger("Horizontal");
        }

        if (v == 1.00)
        {
            Debug.Log("arriba");
            //animatorController.parameters.Length.ToString("Walking2");
            //animator.SetTrigger("Walking");
            //animator.SetFloat("Vertical", speed, 0.1f, Time.deltaTime);

            //animator.SetFloat("VerticalVelocity", verticalVelocity);
            //animatorController.GetInstanceID().ToString("Walk");



        }
        if (v == -1.00)
        {
            Debug.Log(" abajo");

        }
        if (v == -1.00 && h == -1.00)
        {
            Debug.Log(" abajo/izquierda");

        }
        if (v == -1.00 && h == 1.00)
        {
            Debug.Log(" abajo/derecha");

        }

        if (v == 1.00 && h == 1.00)
        {
            Debug.Log(" arriba/derecha");

        }

        if (v == 1.00 && h == -1.00)
        {
            Debug.Log(" arriba/izquierda");


        }

    }

    void salt()
    {
        if (Input.GetButtonDown("Jump")){
                   
            canJump = true;
            
            if (canJump == true){Debug.Log("salto");

                playerRigidbody.AddForce(Vector3.up * jumpHeight);

            }
        
        }
    }
}

/*if (v == 1.00)
   {
       Debug.Log("hay movimiento");
   }
   */
// playerRigidbody.MovePosition (transform.position + movement.normalized * speed * Time.deltaTime); //mode drinker





//	void Turning()
//{

//Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
//RaycastHit floorHit;

//if(Physics.Raycast(camRay, out floorHit, camRayLenght, floorMask))
//{
//Vector3 playerToMouse = floorHit.point - transform.position;
//playerToMouse.y = 0f; //Not Look Player to the floor

//Quaternion newRotation = Quaternion.LookRotation(playerToMouse);
//playerRigidbody.MoveRotation(newRotation);
//}
//    } 

//    void Animating(float h, float v)
// {
//	bool idle = ((v == 0) && (h == 0));
//	anim.SetBool("TransACWalkingBool", !idle);
//    //anim.SetTrigger("TransACDeadTrigger" , dead);
// }





