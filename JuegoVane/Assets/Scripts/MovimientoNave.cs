using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNave : MonoBehaviour
{

    public float velocidad = 14.5f;

    public float movimientoRight;
    public float movimientoUp;

    // public GameObject rayoLaser;
    public float velocidadNave;
    private bool poderVelocidad = false;

    // Start is called before the first frame update
    void Start()
    {
        velocidadNave = 15.0f;
    }

    // Update is called once per frame
    void Update()
    {
        /* desplazamientoNave();
         disparar();*/

        float Horizontal = Input.GetAxis("Horizontal") * velocidadNave * Time.deltaTime;
        print(Horizontal);
        transform.Translate(Horizontal, 0, 0);
        aumentarVelocidad();
    }
    void aumentarVelocidad()
    {

        float horizontal = Input.GetAxis("Horizontal");

        if (poderVelocidad == true)
        {

            transform.Translate(Vector3.right * velocidadNave * 5.0f * horizontal * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.right * velocidadNave * horizontal * Time.deltaTime);


        }

    }

    public void Poweer()
    {
        poderVelocidad = true;
        StartCoroutine(powerDown());
    }

    IEnumerator powerDown()
    {
        yield return new WaitForSeconds(5.0f);
        poderVelocidad = false;
    }
    /*void desplazamientoNave()
    {
        movimientoRight = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * velocidad * movimientoRight);

        movimientoUp = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * Time.deltaTime * velocidad * movimientoUp);

        if (transform.position.x >= -1.34)
        {
            transform.position = new Vector3(-1.34f, transform.position.y, -2.48f);
        }
        else if (transform.position.x <= -9.43)
        {
            transform.position = new Vector3(-9.43f, transform.position.y, -2.48f);
        }

        else if (transform.position.y >= 2.36)
        {
            transform.position = new Vector3(transform.position.x, 2.36f, -2.48f);
        }
        else if (transform.position.y <= -1.21)
        {
            transform.position = new Vector3(transform.position.x, -1.21f, -2.48f);
        }
    }
    void disparar()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(rayoLaser, transform.position + new Vector3(0, 0.5f, -1.16f), Quaternion.identity);
        }
        else if (Input.GetKey(KeyCode.T))
        {
            Instantiate(rayoLaser, transform.position + new Vector3(0, 0.5f, -1.16f), Quaternion.identity);
            Instantiate(rayoLaser, transform.position + new Vector3(0.2f, 0.8f, -1.16f), Quaternion.identity);
            Instantiate(rayoLaser, transform.position + new Vector3(-0.2f, 0.8f, -1.16f), Quaternion.identity);
        }
    }*/
}
