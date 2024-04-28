using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PersonajeMovimiento : MonoBehaviour
{

    GameObject inventario_com;
    private bool InventoryVisible = false;

    [SerializeField] private float velocidad;
    public bool EnMovimiento => _direccionMovimiento.magnitude > 0f;

    public Vector2 DireccionMovimiento => _direccionMovimiento;

    //private PersonajeVida _personajeVida; 

    private Rigidbody2D _rigidbody2D;
    private Vector2 _direccionMovimiento;
    private Vector2 _Ultima_diracion;
    private Vector2 _input;
    public Animator _animator;
    public BoxCollider2D Enpujara_Caja_Derecha;
    public BoxCollider2D Enpujara_Caja_Izquierda;
    public bool Estatico;
    public bool Ariva;
    public bool Abajo;
    public bool Derecha;
    public bool Izquierda;
    public bool ultima_Ariva;
    public bool ultima_Abajo;
    public bool ultima_Derecha;
    public bool ultima_Izquierda;
    public float ultima_direcion = 0;
    public bool Encendido = false;
    public GameObject linterna;
    public GameObject Cono_de_la_linterna;
    public GameObject Cono_Ariva;
    public GameObject Cono_Abajo;
    public GameObject Cono_Derecha;
    public GameObject Cono_Izquierda;
    public int Grado = 0;

    //private readonly int direccionY = Animator.StringToHash("Y");
    //private readonly int direccionX = Animator.StringToHash("X");
    //private readonly int derrotado  = Animator.StringToHash("Derrotado");


    void Start()
    {
        inventario_com = GameObject.FindGameObjectWithTag("inventario-com");
        inventario_com.SetActive(false);
    }


    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        //_personajeVida = GetComponent<PersonajeVida>();
    }

    private void FixedUpdate()
    {
        _rigidbody2D.MovePosition(_rigidbody2D.position + _direccionMovimiento * velocidad * Time.fixedDeltaTime);
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.I))
        {
            if (!InventoryVisible)
            {
                InventoryVisible = true;
                inventario_com.SetActive(InventoryVisible);
                GameObject.FindGameObjectWithTag("GenerarEventos").GetComponent<InventoryController>().showInventory();
            }
            else
            {
                InventoryVisible = false;
                inventario_com.SetActive(InventoryVisible);
            }
        }


        //if(_personajeVida.Derrotado)
        //{
        //    _direccionMovimiento = Vector2.zero;
        //    return;
        //}  

        _input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (Encendido == false)
            {
                Cono_de_la_linterna.SetActive(true);
                Encendido = true;

                if (Grado == 90)
                {
                    Cono_Izquierda.SetActive(true);
                }

                if (Grado == -90)
                {
                    Cono_Derecha.SetActive(true);
                }

                if (Grado == 0)
                {
                    Cono_Ariva.SetActive(true);
                }

                if (Grado == 180)
                {
                    Cono_Abajo.SetActive(true);
                }

                _animator.SetBool("Linterna", true);
            }
            else
            {
                Cono_de_la_linterna.SetActive(false);
                Encendido = false;
                _animator.SetBool("Linterna", false);
                Cono_Abajo.SetActive(false);
                Cono_Ariva.SetActive(false);
                Cono_Derecha.SetActive(false);
                Cono_Izquierda.SetActive(false);
            }
        }

        //eje x//
        if (_input.x > 0.1f)
        {
            _direccionMovimiento.x = 1f;
            _Ultima_diracion.y = 0f;
            Derecha = true;
            Izquierda = false;
            Estatico = false;
            _Ultima_diracion.x = 1f;
            //ultima_direcion = 1;
            //-0.284

            if (Grado != -90)
            {
                if (Grado == 90)
                {
                    //linterna.transform.Rotate(0f,0f,-180);
                    Cono_Izquierda.SetActive(false);
                    Cono_Derecha.SetActive(true);
                }

                if (Grado == 180)
                {
                    //linterna.transform.Rotate(0f,0f,-270);
                    Cono_Abajo.SetActive(false);
                    Cono_Derecha.SetActive(true);
                }

                if (Grado == 0)
                {
                    //linterna.transform.Rotate(0f,0f,-90);
                    //linterna.gameObject.transform.Translate(0.284f, 0f, 0f);
                    Cono_Ariva.SetActive(false);
                    Cono_Derecha.SetActive(true);
                }

                Grado = -90;

            }
        }
        else if (_input.x < 0f)
        {
            _direccionMovimiento.x = -1f;
            _Ultima_diracion.y = 0f;
            _Ultima_diracion.x = -1f;
            Derecha = false;
            Izquierda = true;
            Estatico = false;
            //ultima_direcion = 2;

            if (Grado != 90)
            {
                if (Grado == -90)
                {
                    //linterna.transform.Rotate(0f,0f, 180);
                    Cono_Derecha.SetActive(false);
                    Cono_Izquierda.SetActive(true);
                }

                if (Grado == 180)
                {
                    //linterna.transform.Rotate(0f,0f, -90);
                    Cono_Abajo.SetActive(false);
                    Cono_Izquierda.SetActive(true);
                }

                if (Grado == 0)
                {
                    //linterna.transform.Rotate(0f,0f, 90);
                    //linterna.gameObject.transform.Translate(0.284f, 0f, 0f);
                    Cono_Ariva.SetActive(false);
                    Cono_Izquierda.SetActive(true);
                }

                Grado = 90;
            }
        }
        else
        {
            _direccionMovimiento.x = 0f;
            Derecha = false;
            Izquierda = false;
        }


        //eje y//
        if (_input.y > 0.1f)
        {
            _direccionMovimiento.y = 1f;
            _direccionMovimiento.x = 0f;
            _Ultima_diracion.y = 1f;
            Ariva = true;
            Abajo = false;
            Estatico = false;
            //ultima_direcion = 3;

            if (Grado != 0)
            {

                if (Grado == 90)
                {
                    //linterna.transform.Rotate(0f,0f,-90);
                    //linterna.gameObject.transform.Translate(-0.284f, 0f, 0f);
                    Cono_Ariva.SetActive(true);
                    Cono_Izquierda.SetActive(false);
                }

                if (Grado == -90)
                {
                    //linterna.transform.Rotate(0f,0f,90);
                    //linterna.gameObject.transform.Translate(-0.284f, 0f, 0f);
                    Cono_Ariva.SetActive(true);
                    Cono_Derecha.SetActive(false);
                }

                if (Grado == 180)
                {
                    //linterna.transform.Rotate(0f,0f,-180);
                    Cono_Ariva.SetActive(true);
                    Cono_Abajo.SetActive(false);
                }

                Grado = 0;

            }
        }
        else if (_input.y < 0f)
        {
            _direccionMovimiento.y = -1f;
            _direccionMovimiento.x = 0f;
            _Ultima_diracion.y = -1f;
            Ariva = false;
            Abajo = true;
            Estatico = false;
            //ultima_direcion = 4;

            if (Grado != 180)
            {
                if (Grado == 90)
                {
                    Cono_Abajo.SetActive(true);
                    Cono_Izquierda.SetActive(false);
                }

                if (Grado == -90)
                {
                    //linterna.transform.Rotate(0f,0f,270);
                    Cono_Abajo.SetActive(true);
                    Cono_Derecha.SetActive(false);
                }

                if (Grado == 0)
                {
                    //linterna.transform.Rotate(0f,0f,180);
                    Cono_Abajo.SetActive(true);
                    Cono_Ariva.SetActive(false);
                }

                Grado = 180;
            }
        }
        else
        {
            _direccionMovimiento.y = 0f;
            Abajo = false;
            Ariva = false;
        }


        if (_direccionMovimiento.x == 0f)
        {
            if (_direccionMovimiento.y == 0f)
            {
                Estatico = true;

            }
        }

        if (Estatico == true)
        {
            _animator.SetBool("Estatico", true);
        }
        else
        {
            _animator.SetBool("Estatico", false);
        }

        /*
        if (Grado == 0)
        {}
        if (Grado == 90)
        {}
        if (Grado == -90)
        {}
        if (Grado == 180)
        {}*/
        _animator.SetFloat("DirecionX", _direccionMovimiento.x);
        _animator.SetFloat("DirecionY", _direccionMovimiento.y);
        _animator.SetFloat("Ultima_DirecionX", _Ultima_diracion.x);
        _animator.SetFloat("Ultima_DirecionY", _Ultima_diracion.y);

        //_animator.SetFloat("Ultima_Direcion", ultima_direcion);
    }
}

