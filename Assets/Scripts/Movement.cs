using UnityEngine;

public class Movement : MonoBehaviour
{
    Transform target;
    public float speed = 20f;
    public SpriteRenderer flip;
    public Collider2D playerCollider;
    ContactFilter2D contactFilter;
    public Rigidbody2D rb;
    private void Start()
    {
        target = this.transform;
        contactFilter.SetLayerMask(LayerMask.GetMask("GroundCheck"));
    }
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float force = inputX * speed;
        Vector3 move = new Vector3(speed * inputX, 0, 0);
        if (move.x < 0)
        {
            flip.flipX = true;
        }
        if (move.x > 0)
        {
            flip.flipX = false;
        }
        //move *= Time.deltaTime;

        if (Input.GetKey("a"))
        {
            rb.velocity = new Vector2(force, rb.velocity.y);
        }
        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector2(force, rb.velocity.y);
        }
        //target.Translate(move);

        if (Input.GetButtonDown("Jump") && playerCollider.IsTouching(contactFilter))
        {
            target.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,speed * 100));
        }
    }
}
