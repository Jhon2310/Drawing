using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorButton : MonoBehaviour
{

   [SerializeField] private GameObject _prifab;
   private GameObject prifab;
   public void ColorWhite()
   {
       if (prifab != null)
       {
           Destroy(prifab);
           prifab = Instantiate(_prifab);
           prifab.GetComponent<Renderer>().material.color = UnityEngine.Color.white;
       }
       else
       {
           prifab = Instantiate(_prifab);
           prifab.GetComponent<Renderer>().material.color = UnityEngine.Color.white;
       }
          
       
       
   }
   public void ColorRed()
   {
       if (prifab != null)
       {
           Destroy(prifab);
           prifab = Instantiate(_prifab);
           prifab.GetComponent<Renderer>().material.color = UnityEngine.Color.red;
       }
       else
       {
           prifab = Instantiate(_prifab);
           prifab.GetComponent<Renderer>().material.color = UnityEngine.Color.red;
           
       }
   }
   public void ColorBlue()
   {
       
       if (prifab != null)
       {
           Destroy(prifab);
           prifab = Instantiate(_prifab);
           prifab.GetComponent<Renderer>().material.color = UnityEngine.Color.blue;
       }
       else
       {
           prifab = Instantiate(_prifab);
           prifab.GetComponent<Renderer>().material.color = UnityEngine.Color.blue;
          
       }
   }
   public void ColorGreen()
   {
      
       if (prifab != null)
       {
           Destroy(prifab);
           prifab = Instantiate(_prifab);
           prifab.GetComponent<Renderer>().material.color = UnityEngine.Color.green;
       }
       else
       {
           prifab = Instantiate(_prifab);
           prifab.GetComponent<Renderer>().material.color = UnityEngine.Color.green;
          
       }
   }
   public void ColorYellow()
   {
       if (prifab != null)
       {
           Destroy(prifab);
           prifab = Instantiate(_prifab);
           prifab.GetComponent<Renderer>().material.color = UnityEngine.Color.yellow;
       }
       else
       {
           prifab = Instantiate(_prifab);
           prifab.GetComponent<Renderer>().material.color = UnityEngine.Color.yellow;
          
       }
   }
   public void ColorBlack()
   {
       if (prifab != null)
       {
           Destroy(prifab);
           prifab = Instantiate(_prifab);
           prifab.GetComponent<Renderer>().material.color = UnityEngine.Color.black;
       }
       else
       {
           prifab = Instantiate(_prifab);
           prifab.GetComponent<Renderer>().material.color = UnityEngine.Color.black;
          
       }
   }
   public void ColorCyan()
   {
       if (prifab != null)
       {
           Destroy(prifab);
           prifab = Instantiate(_prifab);
           prifab.GetComponent<Renderer>().material.color = UnityEngine.Color.cyan;
       }
       else
       {
           prifab = Instantiate(_prifab);
           prifab.GetComponent<Renderer>().material.color = UnityEngine.Color.cyan;
          
       }
   }
   public void ColorGray()
   {
       if (prifab != null)
       {
           Destroy(prifab);
           prifab = Instantiate(_prifab);
           prifab.GetComponent<Renderer>().material.color = UnityEngine.Color.gray;
       }
       else
       {
           prifab = Instantiate(_prifab);
           prifab.GetComponent<Renderer>().material.color = UnityEngine.Color.gray;
          
       }
   }

   
}
