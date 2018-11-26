using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opacity : MonoBehaviour {

	

    public float initvalue = 1f;
    public float finalvalue = 0f;
    
   
    private CanvasGroup trans;
    


    public void Start()
    {
        
      
       
    }
    public void fade()

    {
        trans = GetComponent<CanvasGroup>();
        trans.alpha = 0f;
        


    }


    public void buttonfade (){
        CanvasGroup fadebutton1 = GetComponent<CanvasGroup>();     //(assuming the script is attached to the same game object as the Canvas Group)

        fadebutton1.alpha = 0;
    }

    
    

	
	
}
