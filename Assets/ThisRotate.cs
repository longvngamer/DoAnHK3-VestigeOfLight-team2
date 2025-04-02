using UnityEngine;

public class ThisRotate : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Vector3 thisRotate;
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate((thisRotate*Time.deltaTime));
    }
}
