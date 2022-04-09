using UnityEngine;

public class Door : MonoBehaviour
{
    public Collider2D hitbox;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {

        }
    }
}
