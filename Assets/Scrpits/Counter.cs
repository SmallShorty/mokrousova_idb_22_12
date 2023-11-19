using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Counter : MonoBehaviour
{

    public int c = 0;
    public GameObject box;
    public float Speed = 10f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * 5 * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * 5 * Speed * Time.deltaTime);
        }




    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("CEN");
        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        GUICounter.Counter += 1;
        c++;
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("CEN");
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;

    }


}