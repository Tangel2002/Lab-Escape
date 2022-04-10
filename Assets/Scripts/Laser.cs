using UnityEngine;

public class Laser : MonoBehaviour
{
    public Rigidbody2D body;
    Vector2 target;
    Transform startPoint;

    public void Attack(Vector2 enemy, Transform eye)
    {
        target = enemy;
        startPoint = eye;
        body.AddForce(startPoint.right * 500f);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag != "Player")
        {
            Destroy(this.gameObject);
        }
        if(collision.gameObject.tag == "Eye")
        {
            Destroy(collision.gameObject);
        }
    }
    void Hit()
    {

    }
}