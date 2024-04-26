using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForse = 500f;

    // Start is called before the first frame update
    void Start()
    {
        //pupu
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey("d"))//движение вправо
        {
            rb.AddForce(forwardForse * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))//движение влево
        {
            rb.AddForce(-forwardForse * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))//движение вперёд
        {
            rb.AddForce(0, 0, forwardForse * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))//движение назад
        {
            rb.AddForce(0, 0, -forwardForse * Time.deltaTime, ForceMode.VelocityChange);
        }
        

    }
}