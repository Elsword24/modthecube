using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private float axeX = 1;
    private float axeY = 1;
    private float axeZ = 1;
    public Vector3 scaleChange;
    private float directionchooser;
    
    void Start()
    {
        transform.position = new Vector3(Random.Range(axeX,5),Random.Range(axeY,5),Random.Range(axeZ,5));
        transform.localScale = Vector3.one *2f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
        scaleChange = new Vector3(0.1f,0.1f,0.1f);
        InvokeRepeating("GetBigger", 0, 1f);
        InvokeRepeating("directionChoose", 0, 3f);
    }
    
    void Update()
    {
        if (directionchooser == 1)
        {
            transform.Rotate(Random.Range(10,90) * Time.deltaTime, 0.0f, 0.0f);
        }
        if (directionchooser == 2)
        {
            transform.Rotate(0.0f, Random.Range(10, 90) * Time.deltaTime, 0.0f);
        }
        if (directionchooser == 3)
        {
            transform.Rotate(0.0f,0.0f,Random.Range(10, 90) *Time.deltaTime);
        }
        Material material = Renderer.material;
        material.color = new Color(Random.Range(0, 255), Random.Range(0, 255), Random.Range(0, 255), Random.Range(0f, 1f));

    }

    void GetBigger()
    {
        transform.localScale += scaleChange ;

    }

    void directionChoose()
    {
        directionchooser = Random.Range(1, 3); 
    }
}
