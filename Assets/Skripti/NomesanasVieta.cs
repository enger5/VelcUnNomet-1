﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class NomesanasVieta : MonoBehaviour, IDropHandler {
	//Uzglabās velkamā objekta un nomešanas lauka z rotāciju,
	// kāarī rotācijas un izmēru pieļaujamo starpību
	private float vietasZrot, velkObjZrot, rotacijasStarpiba, xIzmeruStarp, yIzmeruStarp;
	private Vector2 vietasIzm, velkObjIzm;
	//Norāde uz Objekti skriptu
	public Objekti objektuSkripts;

	//Nostrādās, ja objektu cenšas nomest uz jebkuras nomešanas  vietas
	public void OnDrop(PointerEventData notikums){
		//Pārbauda vai tika vilkts un atlaists vispār kāds objekts
		if (notikums.pointerDrag != null) {
			//Ja nomešanas vietas tags sakrīt ar vilktā objekta tagu
			if (notikums.pointerDrag.tag.Equals (tag)) {
				//Iegūst objekta rotāciju grādos
				vietasZrot = notikums.pointerDrag.GetComponent<RectTransform> ().eulerAngles.z;
				velkObjZrot = GetComponent<RectTransform> ().eulerAngles.z;
				//Aprēkina abu objektu z rotācijas starpību
				rotacijasStarpiba = Mathf.Abs (vietasZrot - velkObjZrot);
				//Līdzīgi kā ar Z rotāciju, jāpiefiksē objektu izmēri pa x un y asīm, kā arī starpība
				vietasIzm = notikums.pointerDrag.GetComponent<RectTransform> ().localScale;
				velkObjIzm = GetComponent<RectTransform> ().localScale;
				xIzmeruStarp = Mathf.Abs (vietasIzm.x - velkObjIzm.x);
				yIzmeruStarp = Mathf.Abs (vietasIzm.y - velkObjIzm.y);


				//Pārbauda vai objektu rotācijas un izmēru starpība ir pieļaujamajās robēžās
				if ((rotacijasStarpiba <= 6 || (rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360))
				   && (xIzmeruStarp <= 0.1 && yIzmeruStarp <= 0.1)) {
					objektuSkripts.vaiIstajaVieta = true;
					//Noliktais objekts smuki iecentrējas nomešanas laukā
					notikums.pointerDrag.GetComponent<RectTransform> ().anchoredPosition 
								= GetComponent<RectTransform> ().anchoredPosition;
					//Rotācijai
					notikums.pointerDrag.GetComponent<RectTransform> ().localRotation
								= GetComponent<RectTransform> ().localRotation;
					//Izsmēram
					notikums.pointerDrag.GetComponent<RectTransform> ().localScale
					= GetComponent<RectTransform> ().localScale;

					//Pārbauda tagu un atskaņo atbilstošo skaņas efektu
					switch (notikums.pointerDrag.tag) {
					case "Atkritumi":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [1]);
						break;

					case "Slimnica":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [2]);
						break;

					case "Skola":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [3]);
						break;
					case "b2tag":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [4]);
						break;
					case "Cementatag":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [5]);
						break;
					case "e46tag":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [6]);
						break;
					case "esktag":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [7]);
						break;
					case "poltag":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [8]);
						break;
					case "trak1tag":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [9]);
						break;
					case "trak5tag":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [10]);
						break;
					case "Ugunstag":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [11]); 
						break;

					default:
						Debug.Log ("Nedefinēts tags!");
						break;
					}

				}
			
				//Ja objekts nomests nepareizajā laukā
			} else {
				objektuSkripts.vaiIstajaVieta = false;
				objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [0]);

				//Objektu aizmet uz sākotnējo pozīciju
				switch (notikums.pointerDrag.tag) {
				case "Atkritumi":
					objektuSkripts.atkritumuMasina.GetComponent<RectTransform> ().localPosition 
							= objektuSkripts.atkrKoord;
					break; 

				case "Slimnica":
					objektuSkripts.atraPalidziba.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.atroKoord;
					break;

				case "Skola":
					objektuSkripts.autobuss.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.bussKoord;
					break;
				case "b2tag":
					objektuSkripts.b2.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.b2Koord;
					break;
				case "Cementatag":
					objektuSkripts.cementa.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.cementaKoord;
					break;
				case "e46tag":
					objektuSkripts.e46.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.e46Koord;
					break;
				case "esktag":
					objektuSkripts.esk.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.eskKoord;
					break;
				case "poltag":
					objektuSkripts.pol.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.polKoord;
					break;
				case "trak1tag":
					objektuSkripts.trak1.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.trak1Koord;
					break;
				case "trak5tag":
					objektuSkripts.trak5.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.trak5Koord;
					break;
				case "Ugunstag":
					objektuSkripts.uguns.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.ugunsKoord;
					break;

				default:
					Debug.Log ("Nedefinēts tags!");
					break;
				}

			}
		}
	}
}