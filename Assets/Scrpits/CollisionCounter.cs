using UnityEngine;
using UnityEngine.UI;

public class CollisionCounter : MonoBehaviour
{
    public int counter = 10;

    void Start()
    {
        GetComponent<Text>().text = counter.ToString();
    }

    void OnCollisionEnter(Collision collision)
    {
        counter--;
        Debug.Log("Counter: " + counter);
        GetComponent<Text>().text = counter.ToString();
    }
}