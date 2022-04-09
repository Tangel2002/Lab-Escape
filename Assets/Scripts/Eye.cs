using UnityEngine;

public class Eye : MonoBehaviour
{

    public Transform target;
    public Transform eye;

    void Update()
    {
        Vector2 Direction = target.position - transform.position;
        float angle = Mathf.Atan2(Direction.y, Direction.x) * Mathf.Rad2Deg;
        Quaternion lookRot = Quaternion.AngleAxis(angle, Vector3.forward);
        eye.rotation = Quaternion.Slerp(transform.rotation, lookRot, 20f * Time.deltaTime);
    }
}
