using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MenuController : MonoBehaviour
{

    [SerializeField] private List<MenuItem> resourcesList;

    private Renderer leftRenderer;
    private Renderer rightRenderer;
    private int contador = 0;

    void Start()
    {
        leftRenderer = GameObject.Find("Left").GetComponent<Renderer>();
        rightRenderer = GameObject.Find("Right").GetComponent<Renderer>();


        leftRenderer.material = Resources.Load(resourcesList[0].leftResource.name, typeof(Material)) as Material;
        rightRenderer.material = Resources.Load(resourcesList[0].rightResource.name, typeof(Material)) as Material;
    }


    public void LeftButton()
    {
        contador--;
        if (contador < 0)
        {
            contador = resourcesList.Count - 1;
        }
        leftRenderer.material = Resources.Load(resourcesList[contador].leftResource.name, typeof(Material)) as Material;
        rightRenderer.material = Resources.Load(resourcesList[contador].rightResource.name, typeof(Material)) as Material;
    }

    public void RightButton()
    {
        contador++;
        if (contador >= resourcesList.Count)
        {
            contador = 0;
        }

        leftRenderer.material = Resources.Load(resourcesList[contador].leftResource.name, typeof(Material)) as Material;
        rightRenderer.material = Resources.Load(resourcesList[contador].rightResource.name, typeof(Material)) as Material;
    }
}
