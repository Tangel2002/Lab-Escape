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
        body.AddForce(startPoint.right * 50f);
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }
        
        //float distance = 10f * Time.deltaTime;

        //transform.Translate(target.normalized * distance, Space.World);
    }

    void Hit()
    {
    }
}