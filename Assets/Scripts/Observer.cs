using UnityEngine;

public class Observer : MonoBehaviour
{
    public bool status = false;
    public bool animPlayed= false;
    public Sprite death;
    private void Update()
    {
        if (status)
        {
            gameObject.GetComponent<Animation>().Play("fade");
            status = false;
            animPlayed = true;
            gameObject.tag = "Died";
        }
        
        if (animPlayed)
        {
            if (!gameObject.GetComponent<Animation>().isPlaying)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = death;
                this.enabled = false;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Laser")
        {
            status = true;
        }
    }

}
