using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionManager : MonoBehaviour
{
	public Doggie selectedUnit;
	public Material selectedColor;
	public GameObject namePanel;
	public Text nameText;
	public MeterScript healthMeter;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                var selection = hit.transform;
                var selectionRenderer = selection.GetComponent<Renderer>();

                if (selectionRenderer != null)
                {
                    selectionRenderer.material = selectedColor;
                }
            }
        }
    }

	public void SelectDog(Doggie toSelect)
	{
		selectedUnit = toSelect;

		
		GameObject[] units = GameObject.FindGameObjectsWithTag("Dog");
		
		for (int i = 0; i < units.Length; i++)
		{
			Doggie unitScript = units[i].GetComponent<Doggie>();
			unitScript.selected = false;
			
		}


		if (toSelect != null)
		{
			// If there is a selected, mark it as selected, update its visuals, and update the UI elements.
			selectedUnit.selected = true;

			

			
		}
		else
		{
			// If we get in here, it means that the toSelect parameter was null, and that means that we 
			// should deactivate the namePanel.
			namePanel.SetActive(false);
		}
	}

	public void UpdateUI(UnitScript unit)
	{
		healthMeter.SetMeter(unit.health / 100f);
		nameText.text = unit.unitName;
		namePanel.SetActive(true);
	}
}

