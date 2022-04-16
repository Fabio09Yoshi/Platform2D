using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerObjective : MonoBehaviour
{
    [Header("Objetos Ativados")]
    [SerializeField]
    private GameObject[] objActivate;


    [Header("Objetos Desativados")]
    [SerializeField]
    private GameObject[] objDesactivate;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Activate()
    {
        for (int i = 0; i < objActivate.Length; i++)
        {
         objActivate[i].SetActive(true);
        }
        
 
    }

    public void Desactivate()
    {
        for (int i = 0; i < objDesactivate.Length; i++)
        {
            objDesactivate[i].SetActive(false);

        }

    }
  
    
}
