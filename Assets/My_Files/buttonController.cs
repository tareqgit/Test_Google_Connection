using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class buttonController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public int i = 0;
        bool _pressed = false;
    public float multiplier;
    public GameObject any;

        public void OnPointerDown(PointerEventData eventData)
        {
            _pressed = true;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            _pressed = false;
        }

        void Update()
        {
            if (!_pressed)
                return;
       
        i++;
      any.transform.Translate( Vector3.right *multiplier*Time.deltaTime);
     //  float a=Time.deltaTime;
      //a = Mathf.Clamp(a, -Screen.width / 2, Screen.width / 2);
        //any.transform.position += new Vector3( a, any.transform.position.y, any.transform.position.z);
        Debug.Log("clicked");
            // DO SOMETHING HERE
        }
    
}
