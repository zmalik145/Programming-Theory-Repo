using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour
{
    public Text displayText;
    protected Color shapeColor { get; private set; } // ENCAPSULATION
    private Renderer rend;

    // Start is called before the first frame update
    public void Start()
    {
        rend = GetComponent<Renderer>();
        shapeColor = rend.material.color;
    }

    private void OnMouseDown() {
        DisplayText(); // ABSTRACTION
    }
    
    public virtual void DisplayText() {
        displayText.text = shapeColor.ToString();
    }
}
