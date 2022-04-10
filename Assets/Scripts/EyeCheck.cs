using UnityEngine;

public class EyeCheck : MonoBehaviour
{

    public Collider2D door;
    public GameObject eye;

    private void Update()
    {
        if(eye != null)
        {
            door.enabled = false;
        }
        else
            door.enabled = true;
    }

}
