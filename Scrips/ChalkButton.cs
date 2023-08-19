using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChalkButton : MonoBehaviour
{
    
   private LineRenderer _lineRenderer;
   private Camera _camera;
   
   [SerializeField] private float deep = 10;
   [SerializeField] private Renderer _renderer;
   private List<Vector3> _point = new List<Vector3>();
   private List<LineRenderer> _lineRenderers;
   
   private void Awake()
   {
       _lineRenderers = new List<LineRenderer>();
     _camera = Camera.main;
     
   }

   private void Update()
   {
       if (Input.GetMouseButton(0))
       {
           if (_lineRenderer == null)
           {
             
               CreateLine();
               _point.Clear();
               
           }
           var ray = _camera.ScreenPointToRay(Input.mousePosition);
           if (Physics.Raycast(ray, out var raycastHit))
           {

               var point = raycastHit.point;
               point.z = deep;
               _point.Add(point);
               _lineRenderer.positionCount = _point.Count;
               _lineRenderer.SetPosition(_lineRenderer.positionCount - 1, point);
           }
       }
       
       else if (Input.GetMouseButtonUp(0) && _lineRenderer)
       {
           _lineRenderer = null;
       }
   }
   private void CreateLine()
   {
       _lineRenderer = new GameObject("Line").AddComponent<LineRenderer>();
       _lineRenderer.tag = "Line";
       _lineRenderer.material = _renderer.material;
      
      _lineRenderer.SetPosition(0,new Vector3(10,10));
      _lineRenderer.SetPosition(1,new Vector3(10,10));
       _lineRenderer.endWidth = 0.1f;
       _lineRenderer.startWidth = 0.1f;
       _lineRenderer.useWorldSpace = true;
       _lineRenderer.numCapVertices = 50;
   }

   public void DestroyLine()
   {
   }
}
