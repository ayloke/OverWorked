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
    void FixedUpdate()//Эта функция вызывается с частотой фиксированных кадров (fixed framerate), если MonoBehaviour включен.
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
        //Ускорение (работает, но не правильно)
        //if (Input.GetKey("v"))//ускорение
        //{
        //    forwardForse = 2500;//как вставить сюда формулу 
        //}
        //else
        //{
         //   forwardForse = 500;//как присвоить сюда значение которое впсиал в unity
        //}

    }
}