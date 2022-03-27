using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	//Uzglabā ainā esošo kanvu
	public Canvas kanva;
	//GameObject, kas uzglabās velkamos objektus
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	public GameObject b2;
	public GameObject cementa;
	public GameObject e46;
	public GameObject esk;
	public GameObject pol;
	public GameObject trak1;
	public GameObject trak5;
	public GameObject uguns;

	//Uzglabā velakmo objektu sākotnējās atrašanās vietas koordinātas
	[HideInInspector]
	public Vector2 atkrKoord;
	[HideInInspector]
	public Vector2 atroKoord;
	[HideInInspector]
	public Vector2 bussKoord;
	[HideInInspector]
	public Vector2 b2Koord;
	[HideInInspector]
	public Vector2 cementaKoord;
	[HideInInspector]
	public Vector2 e46Koord;
	[HideInInspector]
	public Vector2 eskKoord;
	[HideInInspector]
	public Vector2 polKoord;
	[HideInInspector]
	public Vector2 trak1Koord;
	[HideInInspector]
	public Vector2 trak5Koord;
	[HideInInspector]
	public Vector2 ugunsKoord;

	//Uzglabās audio avotu, kurā atskaņot attēlu skaņas efektus
	public AudioSource skanasAvots;
	//Masīvs, kas uzglabā visas iespējamās skaņas
	public AudioClip[] skanaKoAtskanot;
	//Mainīgais piefiksē vai objekts nolikts īstajāvietā (true/false)
	[HideInInspector]
	public bool vaiIstajaVieta = false;
	//Uzglabās pēdējo objektu, kurš pakustināts
	public GameObject pedejaisVIlktais = null;

	// Use this for initialization
	void Start () {
		atkrKoord = atkritumuMasina.GetComponent<RectTransform> ().localPosition;
		atroKoord = atraPalidziba.GetComponent<RectTransform> ().localPosition;
		bussKoord = autobuss.GetComponent<RectTransform> ().localPosition;
		b2Koord = b2.GetComponent<RectTransform> ().localPosition;
		cementaKoord = cementa.GetComponent<RectTransform> ().localPosition;
		e46Koord = e46.GetComponent<RectTransform> ().localPosition;
		eskKoord = esk.GetComponent<RectTransform> ().localPosition;
		polKoord = pol.GetComponent<RectTransform> ().localPosition;
		trak1Koord = trak1.GetComponent<RectTransform> ().localPosition;
		trak5Koord = trak5.GetComponent<RectTransform> ().localPosition;
		ugunsKoord = uguns.GetComponent<RectTransform> ().localPosition;
	}
}
