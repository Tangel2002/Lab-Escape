using UnityEngine;

public class CircuitBox : MonoBehaviour
{
    bool status = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Laser")
        {
            status = false;
        }
    }
    public bool checkStatus()
    {
        return status;
    }
}
