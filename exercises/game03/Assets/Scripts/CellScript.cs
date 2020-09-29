using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellScript : MonoBehaviour
{
    Renderer rend;
    public Color aliveColor;
    public Color deadColor;
    public Color wasAliveColor;

    private int aliveCount;
    public int destroyCount;
    
    public bool wasAlive = false; 

    public int x = -1;
    public int y = -1;

    
    public bool nextAlive;
    private bool _alive = false;
    public bool Alive
    {
        get
        {
            return this._alive;

        }
        set
        {
            this._alive = value;

            if (this._alive)
            {
                aliveCount++;
                wasAlive = true;
                rend.material.color = aliveColor;
                

            } else {
                if (wasAlive)
                {
                    rend.material.color = wasAliveColor;

                }
                else {
                    rend.material.color = deadColor;
                }
                
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rend = gameObject.GetComponent<Renderer>();
        this.Alive = Random.value < 0.5f;
       

    }

    // Update is called once per frame
    void Update()
    {


    }

   
    void Destroyed()
    {
        if (aliveCount == 4)
        {
           Destroy(this.gameObject);
            destroyCount++;
        }
        
    }

    

    private void OnMouseDown()
    {
        this.Alive = !this.Alive;
        
    }



}
