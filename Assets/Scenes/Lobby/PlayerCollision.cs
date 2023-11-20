using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Movement movement;
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "TableMenu")
        {
            Debug.Log("hit");
        }
    }
}
