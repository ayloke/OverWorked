using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Movement movement;

    //проверка столкновения
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Enemy")
        {
            Debug.Log("hit");
        }
    }
}
