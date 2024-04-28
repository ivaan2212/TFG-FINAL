using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DireccionMovimiento
{
    Horizontal,
    Vertical
}




public class WaypointMovimiento : MonoBehaviour
{
    
    [SerializeField] private float velocidad;

    protected Waypoint _waypoint;

    public int contador = 0;


    protected int puntoActualIndex;
    protected Vector3 ultimaPosicion;
    protected Animator _animator;

    public Vector3 PosicionActual => _waypoint.ObtenerPosicionMovimiento(puntoActualIndex);


    void Start()
    {
        puntoActualIndex = 0;
        _animator = GetComponent<Animator>();
        _waypoint = GetComponent<Waypoint>();
    }

    // Update is called once per frame
    void Update()
    {
        RotarVertical();
        RotarPersonaje();
        MoverPersonaje();
        if(ComprobarPuntoActualAlcanzado())
        {
            ActualizarIndexMovimiento();
        }
    }
    private void MoverPersonaje()
    {
        transform.position = Vector3.MoveTowards(transform.position, PosicionActual,
            velocidad * Time.deltaTime);
    }
    private bool ComprobarPuntoActualAlcanzado()
    {
        float distanciaHaciaPuntoActual = (transform.position - PosicionActual).magnitude;
        if(distanciaHaciaPuntoActual < 0.1f)
        {
            ultimaPosicion = transform.position;
            return true;
        }
        return false;
    }
    private void ActualizarIndexMovimiento()
    {
        if(puntoActualIndex == _waypoint.Puntos.Length - 1)
        {
            puntoActualIndex = 0;

            contador = 0;
        }
        else
        {
            if(puntoActualIndex < _waypoint.Puntos.Length - 1)
        {
            puntoActualIndex++;
                contador++;
        } 
        }
    }
    protected virtual void RotarPersonaje()
    {
        
    }

    protected virtual void RotarVertical()
    {

    }





















}
