using UnityEngine;
using UnityEngine.SceneManagement;
public class Door : MonoBehaviour
{
    public Collider2D hitbox;
    public string next;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            NextLevel(next);
        }
    }

    public void NextLevel(string level)
    {
        SceneManager.LoadScene(level);
    }
}
