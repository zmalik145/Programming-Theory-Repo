using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape // INHERITANCE
{
    // POLYMORPHISM
    public override void DisplayText()
    {
        displayText.text = "Cube\nColor Value:\n" + shapeColor.ToString();
    }
}
