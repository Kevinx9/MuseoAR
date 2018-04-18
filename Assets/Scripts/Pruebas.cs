﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pruebas : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DatosUsuario.Instance.nombreUsuario="Andrés Sánchez";
		DatosUsuario.Instance.idUsuario="123";
		DatosUsuario.Instance.obras=new List<Obra>();

		DatosUsuario.Instance.obras.Add(new Obra("Amphitrite",1));
		DatosUsuario.Instance.obras[0].id=1;
		DatosUsuario.Instance.obras[0].nombre="Amphitrite";
		DatosUsuario.Instance.obras[0].calificada=false;
		DatosUsuario.Instance.obras[0].url="C:/Users/AndresFelipe/Documents/ProyectosTesis/ProyectosUnity/Prototipo3_Creacion/AssetBundles/StandaloneWindows/obra1";
		DatosUsuario.Instance.obras[0].tipo="escultura";
		DatosUsuario.Instance.obras[0].posicion=new Vector3(50,-35,50);
		DatosUsuario.Instance.obras[0].anguloRotacion=30;

		
		
		DatosUsuario.Instance.obras.Add(new Obra("Gioconda",10));
		DatosUsuario.Instance.obras[1].id=10;
		DatosUsuario.Instance.obras[1].nombre="Gioconda";
		DatosUsuario.Instance.obras[1].calificada=false;
		DatosUsuario.Instance.obras[1].url="C:/Users/AndresFelipe/Desktop/RecursosObras/Pinturas/La Gioconda.jpg";
		DatosUsuario.Instance.obras[1].tipo="pintura";
		DatosUsuario.Instance.obras[1].posicion=new Vector3(130,10,0);
		DatosUsuario.Instance.obras[1].anguloRotacion=90;

		DatosUsuario.Instance.obras.Add(new Obra("El Beso",3));
		DatosUsuario.Instance.obras[2].id=3;
		DatosUsuario.Instance.obras[2].nombre="El Beso";
		DatosUsuario.Instance.obras[2].calificada=false;
		DatosUsuario.Instance.obras[2].url="C:/Users/AndresFelipe/Desktop/RecursosObras/Pinturas/El beso.jpg";
		DatosUsuario.Instance.obras[2].tipo="pintura";
		DatosUsuario.Instance.obras[2].posicion=new Vector3(-75,-25,0);
		DatosUsuario.Instance.obras[2].anguloRotacion=-90;

		DatosUsuario.Instance.obras.Add(new Obra("El hijo del hombre",6));
		DatosUsuario.Instance.obras[3].calificada=false;
		DatosUsuario.Instance.obras[3].url="C:/Users/AndresFelipe/Desktop/RecursosObras/Pinturas/El hijo del hombre.jpg";
		DatosUsuario.Instance.obras[3].tipo="pintura";

		DatosUsuario.Instance.obras.Add(new Obra("El hijo del hombre",7));
		DatosUsuario.Instance.obras[4].calificada=false;
		DatosUsuario.Instance.obras[4].url="C:/Users/AndresFelipe/Desktop/RecursosObras/Pinturas/El hijo del hombre.jpg";
		DatosUsuario.Instance.obras[4].tipo="pintura";

		DatosUsuario.Instance.obras.Add(new Obra("El hijo del hombre",8));
		DatosUsuario.Instance.obras[5].calificada=false;
		DatosUsuario.Instance.obras[5].url="C:/Users/AndresFelipe/Desktop/RecursosObras/Pinturas/El hijo del hombre.jpg";
		DatosUsuario.Instance.obras[5].tipo="pintura";

				DatosUsuario.Instance.obras.Add(new Obra("El hijo del hombre",9));
		DatosUsuario.Instance.obras[6].calificada=false;
		DatosUsuario.Instance.obras[6].url="C:/Users/AndresFelipe/Desktop/RecursosObras/Pinturas/El hijo del hombre.jpg";
		DatosUsuario.Instance.obras[6].tipo="pintura";

		DatosUsuario.Instance.obras.Add(new Obra("Borghese vase",2));
		DatosUsuario.Instance.obras[7].calificada=false;
		DatosUsuario.Instance.obras[7].url="C:/Users/AndresFelipe/Documents/ProyectosTesis/ProyectosUnity/Prototipo3_Creacion/AssetBundles/StandaloneWindows/obra2";
		DatosUsuario.Instance.obras[7].tipo="escultura";


		GameObject acomodarObras = GameObject.Find ("AcomodarObras");
		AcomodarObras script=acomodarObras.GetComponent<AcomodarObras> ();
		StartCoroutine(script.acomodarObras());

		


	}
}
