using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementScript : MonoBehaviour
{
//     public Transform target;
//     //public Transform player;
//     private Rigidbody2D rb;
//     private Vector2 moveDirection;
//     private GameObject ems;
//     public float moveSpeed = 0.5f;
//     public Animator animator;
//     PlantingPatchScript pps;
//     public GameObject gms2;
//     public GameObject sps;
//     public Transform NewTarget;
//     public bool canMove;
//    // public EnemyStats es;
//     // Start is called before the first frame update
//     void Awake()
//     {
//         rb = GetComponent<Rigidbody2D>();
//     }

//     public void Start() 
//     {
//         target = GameObject.Find("Player").transform;
//         gms2 = GameObject.Find("GameManager");
//         sps = GameObject.Find("ChangingPatches");
//        // ems = GameObject.Find("EnemyPH");
//         //pps.plantedPatchP = GameObject.Find("Player").transform;
//         canMove = true;
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         //moveDirection.x = Input.GetAxisRaw("Horizontal");
//         //moveDirection.y = Input.GetAxisRaw("Vertical");

//         animator.SetFloat("Horizontal", moveDirection.x);
//         animator.SetFloat("Vertical", moveDirection.y);
//         animator.SetFloat("Speed", moveDirection.sqrMagnitude);

//         if (canMove == true)
//         {
//             rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * moveSpeed;
//         }
        
       

       

//         if(gms2.GetComponent<GameManagerScript>().plusOneCounted >= 1)
//         {
//             target = sps.GetComponent<SpawnPatchScript>().ActivatedPatch();

//         }
//         if (gms2.GetComponent<GameManagerScript>().plusOneCounted <= 0)
//         {
//             target = GameObject.Find("Player").transform;
//         }

//        // if(gms2.GetComponent<GameManagerScript>().plusOneCounted == 0)

//         if(target)
//         {
//             Vector3 direction = (target.position - transform.position).normalized;
//             float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
//             //rb.rotation = angle;
//             moveDirection = direction;
            
//         }

//         // if(ems.GetComponent<EnemyStats>().enemyHealth <= 0)
//         // {
//         //     this.moveSpeed = 0f;
//         // }

        
//     }

    // private void FixedUpdate() 
    // {

       
        
    //     //rb.MovePosition(rb.position + moveDirection * moveSpeed * Time.fixedDeltaTime);
    // }

    // private void OnTriggerEnter2D(Collider2D other)
    // {
    //     if(other.CompareTag("Enemy"))
    //     {
            
    //         Debug.Log("Enemy touched enemy");
    //         target = GameObject.Find("Player").transform;
           


    //     }
    // }

    
}
