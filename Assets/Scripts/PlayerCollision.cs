using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Movement movement;
    //проверка столкновения
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Door")
        {
            Debug.Log("hit");
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<BoxCollider>().enabled = false;
        }
        else
        {
            GetComponent<MeshRenderer>().enabled = true;
            GetComponent<BoxCollider>().enabled = true;
        }
    }
}
