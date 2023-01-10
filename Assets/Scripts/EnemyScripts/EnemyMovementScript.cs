using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementScript : MonoBehaviour
{
    public Transform target;
    //public Transform player;
    private Rigidbody2D rb;
    private Vector2 moveDirection;
    public float moveSpeed = 0.5f;
    PlantingPatchScript pps;
    public GameObject gms2;
    public GameObject sps;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Start() 
    {
        target = GameObject.Find("Player").transform;
        gms2 = GameObject.Find("GameManager");
        sps = GameObject.Find("ChangingPatches");
        //pps.plantedPatchP = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(gms2.GetComponent<GameManagerScript>().plusOneCounted >= 1)
        {
            target = sps.GetComponent<SpawnPatchScript>().ActivatedPatch();

        }
        else if (gms2.GetComponent<GameManagerScript>().plusOneCounted <= 0)
        {
            target = GameObject.Find("Player").transform;
        }

        if(target)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rb.rotation = angle;
            moveDirection = direction;
        }
    }

    private void FixedUpdate() 
    {
        rb.velocity = new Vector2 (moveDirection.x, moveDirection.y) * moveSpeed;
    }

    
}
