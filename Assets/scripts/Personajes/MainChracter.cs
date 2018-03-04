using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainChracter : MonoBehaviour {
    
    public KeyCode forward_key;
    public KeyCode backward_key;
    public KeyCode left_key;
    public KeyCode right_key;
    public int max_live;
    public float mov_speed;
    public GameObject camera;
    public GameObject cam_position;

    [Range(0.0f,1.0f)]//Decorador para poner tope al valor de la variable elasticidad
    public float elasticidad;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {  
        
        //Mueve al personaje según la tecla que se pulse
        if (Input.GetKey(forward_key)){
          
            transform.Translate(0, 0, mov_speed * Time.deltaTime);
            
        }
        else if (Input.GetKey(backward_key)){
            transform.Translate(0, 0, -mov_speed * Time.deltaTime);
        }
        else if (Input.GetKey(left_key)){
            transform.Translate(new Vector3(-1, 0, 0)*Time.deltaTime*mov_speed);
        }
        else if (Input.GetKey(right_key)) {
            transform.Translate(mov_speed * Time.deltaTime, 0, 0);
        }
        //Elasticidad de la camara
        camera.transform.position = Vector3.Lerp(camera.transform.position, cam_position.transform.position, elasticidad);
	}
}
