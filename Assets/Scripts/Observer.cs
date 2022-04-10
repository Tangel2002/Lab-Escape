using UnityEngine;

public class Observer : MonoBehaviour
{
    bool status = false;
    bool animPlayed= false;
    public Sprite death;
   // public AnimationClip fade;
    private void Update()
    {
        //gameObject.GetComponent<Animation>().clip = fade;
        if (status)
        {
            gameObject.GetComponent<Animation>().Play("fade");
            status = false;
            animPlayed = true;
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
