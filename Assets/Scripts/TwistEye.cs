using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TwistEye : MonoBehaviour
{

    public GameObject eye;
    public GameObject door;
    float wait = 5;
    float countdown = 3;
    bool start = false;
    bool sendBack = false;
    public Image black;
    // Update is called once per frame
    void Update()
    {
        if (eye == null)
        {
            door.GetComponent<Collider2D>().enabled = false;
            start = true;
        }
        if (start)
        {
            wait -= Time.deltaTime;
        }
        if (wait < 0)
        {
            black.gameObject.SetActive(true);
            sendBack = true;
        }
        if (sendBack)
        {
            countdown -= Time.deltaTime;
        }
        if(countdown < 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
