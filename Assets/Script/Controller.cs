using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject carro;
    // Start is called before the first frame update
    public void RotateLeft()
    {
        carro.transform.Rotate(0.0f, 10.0f, 0.0f, Space.Self);
    }
    public void RotateRight()
    {
        carro.transform.Rotate(0.0f, -10.0f, 0.0f, Space.Self);
    }
    public void TranslateUp()
    {
        carro.transform.Translate(Vector3.up * Time.deltaTime * 10, Space.World);
    }
    public void TranslateDown()
    {
        carro.transform.Translate(Vector3.down * Time.deltaTime * 10, Space.World);
    }
    public void TranslateLeft()
    {
        carro.transform.Translate(Vector3.left * Time.deltaTime * 10, Space.World);
    }
    public void TranslateRight()
    {
        carro.transform.Translate(Vector3.right * Time.deltaTime * 10, Space.World);
    }
    public void Scale(float magnitud)
    {
        Vector3 changerScale = new Vector3(magnitud, magnitud, magnitud);
        carro.transform.localScale += changerScale;
    }
    void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
