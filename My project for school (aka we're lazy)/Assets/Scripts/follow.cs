using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class follow : MonoBehaviour
{
    public GameObject player;
    public float speed;
    private float distance;
    public Rigidbody2D rb;
    public Vector2 velocity;
    public Animator anim;
    public Transform objectTransform;
    private Vector3 previousPosition;
    private Quaternion initialRotation;

    // Start is called before the first frame update
    void Start()
    {
        previousPosition = objectTransform.position;
        velocity = rb.velocity;
        velocity.Normalize();
        initialRotation = Quaternion.Euler(0f, 0f, transform.rotation.eulerAngles.z);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = objectTransform.position;
        Vector3 displacement = currentPosition - previousPosition;
        Vector2 direction = displacement.normalized;
        previousPosition = currentPosition;
        velocity.x = Input.GetAxisRaw("Horizontal");
        velocity.y = Input.GetAxisRaw("Vertical");
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction2 = player.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);

        rb.velocity = velocity;

        if (direction.x > 0)
        {
            anim.SetBool("Right", true);
            anim.SetBool("Left", false);
        }
        else
        {
            anim.SetBool("Left", true);
            anim.SetBool("Right", false);
        }
        if (direction.y > 0)
        {
            anim.SetBool("Up", true);
            anim.SetBool("Down", false);
        }
        else
        {
            anim.SetBool("Down", true);
            anim.SetBool("Up", false);
        }
        rb.SetRotation(initialRotation);
    }
}
