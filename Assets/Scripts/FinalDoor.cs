using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalDoor : MonoBehaviour
{
    public Collider2D hitbox;
    float countdown = 5;
    bool gone = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            gone = true;
        }
    }

    private void Update()
    {
        if (gone)
        {
            countdown -= Time.deltaTime;
        }
        if(countdown <= 0)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
