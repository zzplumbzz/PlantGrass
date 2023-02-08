using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{

    public float enemyHealth = 8f;
    public GameObject enemyPrefab;
    public PlayerStats ps;
    private GameObject healthBar;
    private GameObject player;
    public bool playerTakesDamage;
    private GameObject gm;
    private GameObject ems;
    public float deathTimer = 1f;
    public bool deathTimerOn = false;
    public bool deathTrue;
    public Animator animator;

    public Transform target;
    //public Transform player;
    public Rigidbody2D rb;
    private Vector2 moveDirection;
    //private GameObject ems;
    public float moveSpeed = 2f;
    public float deathSpeed = 0;
   // public Animator animator;
    PlantingPatchScript pps;
    public GameObject gms2;
    public GameObject sps;
    public Transform NewTarget;
    public bool canMove;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
        deathTimerOn = false;
        gm = GameObject.Find("GameManager");


        target = GameObject.Find("Player").transform;
        gms2 = GameObject.Find("GameManager");
        sps = GameObject.Find("ChangingPatches");
        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyHealth <= 0)
        {
            canMove = false;
            gm.GetComponent<GameManagerScript>().deathSound.Play();
           
            animator.SetBool("Death", deathTrue);
            Debug.Log("Enemy Dead");
            
            
            
            deathTrue = true;
            deathTimerOn = true;
            
            
        }

        if(deathTimerOn == true)
        {
            deathTimer -= Time.deltaTime;
        }

        if(deathTimer <=0)
        {
            Destroy(gameObject);
            
            deathTimer = 1f;
        }



        animator.SetFloat("Horizontal", moveDirection.x);
        animator.SetFloat("Vertical", moveDirection.y);
        animator.SetFloat("Speed", moveDirection.sqrMagnitude);

        if (canMove == true)
        {
            rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * moveSpeed;
        }

        if(canMove == false)
        {
            rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * deathSpeed;
        }
        if (gms2.GetComponent<GameManagerScript>().plusOneCounted >= 1)
        {
            target = sps.GetComponent<SpawnPatchScript>().ActivatedPatch();

        }
        if (gms2.GetComponent<GameManagerScript>().plusOneCounted <= 0)
        {
            target = GameObject.Find("Player").transform;
        }

        if (target)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            //rb.rotation = angle;
            moveDirection = direction;

        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PSprite"))
        {
            gm.GetComponent<GameManagerScript>().takesDamageSound.Play();
            playerTakesDamage = true;
            other.GetComponent<PlayerStats>().playerHealth -= 2;
            //healthBar.GetComponent<HealthBarScript>().SetHealth(float health);
           // gameObject.GetComponent<PlayerStats>().SetHealth(ps.GetComponent<PlayerStats>().playerHealth);
        }

       
    }
    private void OnTriggerExit2D(Collider2D other) 
    {
        if (other.CompareTag("PSprite"))
        {
            playerTakesDamage = false;
        }
    }
    
}
