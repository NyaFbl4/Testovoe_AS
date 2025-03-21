using System.Collections;
using System.Collections.Generic;
using Testovoe_AS;
using UnityEngine;

public class Figure : MonoBehaviour
{
    [SerializeField] private FigureType _figuresType;

    public FigureType FigureType => _figuresType;
}
