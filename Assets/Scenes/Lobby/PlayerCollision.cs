using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Movement movement;
    public int hp = 100;
    //�������� ������������
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Enemy")
        {
            Debug.Log("hit");
            hp -- ;
        }
    }
}
