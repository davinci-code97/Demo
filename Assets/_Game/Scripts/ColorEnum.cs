using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ColorByEnum {
    None = 0,
    Blue = 1,
    Red = 2,
    Green = 3,
}

[CreateAssetMenu(fileName = "ColorData", menuName = "Scriptable Objects/Color Data", order = 1)]
public class ColorEnum : ScriptableObject
{
    public List<Material> Materials;

    public Material GetMaterialByEnum(ColorByEnum colorByEnum) {
        int index = (int)colorByEnum;
        return Materials[index];
    }
}
