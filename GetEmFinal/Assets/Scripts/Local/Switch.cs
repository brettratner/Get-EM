using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {



	public bool switch1Pressed = false;
	public bool switch2Pressed = false;
	public bool switch3Pressed = false;
	public bool switch4Pressed = false;
	public GameObject switch1;
	public GameObject switch2;
	public GameObject switch3;
	public GameObject switch4;
	public bool switch1on = false;
	public bool switch2on;
	public bool switch3on;
	public bool switch4on;
	public double counter;
	public double counter2;
	public double counter3;
	public double counter4;


	//switch one walls disapear
	public GameObject wall_48; //also wall four replace
	public GameObject wall_205;
	public GameObject wall_71;
	public GameObject wall_69;
	public GameObject wall_41; // also wall three dissapear
	public GameObject wall_163; //also wall four replace
	public GameObject wall_82; //also wall four replace
	public GameObject wall_136; //also wall four replace
	public GameObject wall_116;
	public GameObject wall_49; //also wall four replace


	//switch one walls replace

	public GameObject wall_132; // also wall four dissapear
	public GameObject wall_209;
	public GameObject wall_171; // also wall four dissapear
	public GameObject wall_l73;
	public GameObject wall_196; // also wall four dissapear
	public GameObject wall_183; // also wall four dissapear
	public GameObject wall_216;
	public GameObject wall_217;
	public GameObject wall_218;
	public GameObject wall_219;

	//switch two walls disapear
	public GameObject wall_157;
	public GameObject wall_96; // also wall three replace
	public GameObject wall_83;
	public GameObject wall_182; // also wall three replace
	public GameObject wall_206; // also wall three replace
	public GameObject wall_128; // also wall three replace
	public GameObject wall_79; // also wall three replace
	public GameObject wall_34;
	public GameObject wall_198;
	public GameObject wall_94; // also wall three replace

	//switch two walls replace
	public GameObject wall_210;
	public GameObject wall_59;  // also wall three dissapear
	public GameObject wall_125; // also wall three dissapear
	public GameObject wall_207; // also wall three dissapear
	public GameObject wall_86;  // also wall three dissapear
	public GameObject wall_30;  // also wall three dissapear
	public GameObject wall_222;
	public GameObject wall_223;
	public GameObject wall_224;
	//public GameObject wall_

	//switch three walls disapear 59,125,207,86,30,41
	public GameObject wall_57;
	public GameObject wall_168;
	public GameObject wall_156;
	public GameObject wall_151;

	//switch three walls replace    206, 96, 182, 128, 79, 94
	public GameObject wall_220;
	public GameObject wall_221;

	//swithc four walls disapear    132, 196, 171, 183
	public GameObject wall_68; 
	public GameObject wall_31;  
	public GameObject wall_12;  
	public GameObject wall_73;
	public GameObject wall_197;
	public GameObject wall_19;

	//swithc four walls replace   48, 163, 49, 82, 136
	public GameObject wall_211; 
	public GameObject wall_212;  
	public GameObject wall_213;  
	public GameObject wall_214;
	public GameObject wall_215;
	public GameObject wall_208;



	public float wallTimeout1 = 5;
	public float wallTimeout2 = 5;
	public float wallTimeout3 = 5;
	public float wallTimeout4 = 5;
	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		counter = 1;
		counter2 = 1;
		counter3 = 1;
		counter4 = 1;
		switch1.SetActive (true);
		switch2.SetActive (true);
		switch3.SetActive (true);
		switch4.SetActive (true);
		wall_208.SetActive (false);
		wall_209.SetActive (false);
		wall_210.SetActive (false);
		wall_211.SetActive (false);
		wall_212.SetActive (false);
		wall_213.SetActive (false);
		wall_214.SetActive (false);
		wall_215.SetActive (false);
		wall_216.SetActive (false);
		wall_217.SetActive (false);
		wall_218.SetActive (false);
		wall_219.SetActive (false);
		wall_220.SetActive (false);
		wall_221.SetActive (false);
		wall_222.SetActive (false);
		wall_223.SetActive (false);
		wall_224.SetActive (false);
		switch2on = false;
		switch3on = false;
		switch4on = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Debug.Log(counter);

		if (switch1Pressed == true) {
			if((counter % 2) == 0){
				//walls that are already visible
				wall_48.SetActive  (switch1on);
				wall_205.SetActive (switch1on);
				wall_71.SetActive  (switch1on);
				wall_69.SetActive  (switch1on);
				wall_41.SetActive  (switch1on);
				wall_163.SetActive (switch1on);
				wall_82.SetActive  (switch1on);
				wall_136.SetActive (switch1on);
				wall_116.SetActive (switch1on);
				wall_49.SetActive  (switch1on);
				//walls that are invisible 
				wall_216.SetActive (!switch1on);
				wall_132.SetActive (!switch1on);
				wall_171.SetActive (!switch1on);
				wall_73.SetActive  (!switch1on);
				wall_196.SetActive (!switch1on);
				wall_183.SetActive (!switch1on);
				wall_217.SetActive (!switch1on);
				wall_218.SetActive (!switch1on);
				wall_219.SetActive (!switch1on);
				wall_209.SetActive (!switch1on);
			}
			else if((counter % 2) == 1 ){
				//walls that are already visible
				wall_48.SetActive  (!switch1on);
				wall_205.SetActive (!switch1on);
				wall_71.SetActive  (!switch1on);
				wall_69.SetActive  (!switch1on);
				wall_41.SetActive  (!switch1on);
				wall_163.SetActive (!switch1on);
				wall_82.SetActive  (!switch1on);
				wall_136.SetActive (!switch1on);
				wall_116.SetActive (!switch1on);
				wall_49.SetActive  (!switch1on);
				//walls that are invisible 
				wall_216.SetActive (switch1on);
				wall_132.SetActive (switch1on);
				wall_171.SetActive (switch1on);
				wall_73.SetActive  (switch1on);
				wall_196.SetActive (switch1on);
				wall_183.SetActive (switch1on);
				wall_217.SetActive (switch1on);
				wall_218.SetActive (switch1on);
				wall_219.SetActive (switch1on);
				wall_209.SetActive (switch1on);


			}
			wallTimeout1 -= Time.deltaTime;
			//Debug.Log ("timeout is: " + wallTimeout1);
		if(wallTimeout1 < 0)
			{
				switch1Pressed = false;
				switch1.SetActive (true);
				wallTimeout1 = 5;
			}
		} 
		if (switch2Pressed == true) {
			if((counter2 % 2) == 0){
				//walls that are already visible
				wall_96.SetActive  (switch1on);
				wall_157.SetActive (switch1on);
				wall_83.SetActive  (switch1on);
				wall_182.SetActive (switch1on);
				wall_206.SetActive (switch1on);
				wall_128.SetActive (switch1on);
				wall_79.SetActive  (switch1on);
				wall_34.SetActive  (switch1on);
				wall_198.SetActive (switch1on);
				wall_94.SetActive  (switch1on);
				//walls that are invisible 
				wall_222.SetActive (!switch1on);
				wall_210.SetActive (!switch1on);
				wall_59.SetActive  (!switch1on);
				wall_125.SetActive (!switch1on);
				wall_207.SetActive (!switch1on);
				wall_86.SetActive  (!switch1on);
				wall_30.SetActive  (!switch1on);
				wall_223.SetActive (!switch1on);
				wall_224.SetActive (!switch1on);
			}
			else if((counter2 % 2) == 1 ){
				//walls that are invisible
				wall_96.SetActive  (!switch1on);	
				wall_157.SetActive (!switch1on);
				wall_83.SetActive  (!switch1on);
				wall_182.SetActive (!switch1on);
				wall_206.SetActive (!switch1on);
				wall_128.SetActive (!switch1on);
				wall_79.SetActive  (!switch1on);
				wall_34.SetActive  (!switch1on);
				wall_198.SetActive (!switch1on);
				wall_94.SetActive  (!switch1on);
				//walls that are already visible
				wall_222.SetActive (switch1on);
				wall_210.SetActive (switch1on);
				wall_59.SetActive  (switch1on);
				wall_125.SetActive (switch1on);
				wall_207.SetActive (switch1on);
				wall_86.SetActive  (switch1on);
				wall_30.SetActive  (switch1on);
				wall_223.SetActive (switch1on);
				wall_224.SetActive (switch1on);

			}
			wallTimeout2 -= Time.deltaTime;
			//Debug.Log ("timeout is: " + wallTimeout1);

			if(wallTimeout2 < 0)
			{

				switch2Pressed = false;
				switch2.SetActive (true);
				wallTimeout2 = 5;


			}
		}
		if (switch3Pressed == true) {
			if((counter3 % 2) == 0){
				//walls that are already visible
				wall_59.SetActive  (switch1on);
				wall_125.SetActive (switch1on);
				wall_57.SetActive  (switch1on);
				wall_168.SetActive (switch1on);
				wall_41.SetActive  (switch1on);
				wall_156.SetActive (switch1on);
				wall_207.SetActive (switch1on);
				wall_30.SetActive  (switch1on);
				wall_86.SetActive  (switch1on);
				wall_151.SetActive (switch1on);
				//walls taht are invisible
				wall_206.SetActive (!switch1on);
				wall_96.SetActive  (!switch1on);
				wall_182.SetActive (!switch1on);
				wall_128.SetActive (!switch1on);
				wall_79.SetActive  (!switch1on);
				wall_94.SetActive  (!switch1on);
				wall_207.SetActive (!switch1on);
				wall_220.SetActive (!switch1on);
				wall_221.SetActive (!switch1on);

			}
			else if((counter3 % 2) == 1 ){
				//walls that are invisible
				wall_59.SetActive (!switch1on);
				wall_125.SetActive(!switch1on);
				wall_57.SetActive (!switch1on);
				wall_168.SetActive(!switch1on);
				wall_41.SetActive (!switch1on);
				wall_156.SetActive(!switch1on);
				wall_207.SetActive(!switch1on);
				wall_30.SetActive (!switch1on);
				wall_86.SetActive (!switch1on);
				wall_151.SetActive(!switch1on);
				//walls that are already visible

				wall_206.SetActive (switch1on);
				wall_96.SetActive  (switch1on);
				wall_182.SetActive (switch1on);
				wall_128.SetActive (switch1on);
				wall_79.SetActive  (switch1on);
				wall_94.SetActive  (switch1on);
				wall_207.SetActive (switch1on);
				wall_220.SetActive (switch1on);
				wall_221.SetActive (switch1on);

			}
			wallTimeout3 -= Time.deltaTime;
			//Debug.Log ("timeout is: " + wallTimeout1);



			if(wallTimeout3 < 0)
			{

				switch3Pressed = false;
				switch3.SetActive (true);
				wallTimeout3 = 5;


			}
		}
		if (switch4Pressed == true) {
			if((counter4 % 2) == 0){
				//walls that are already visible
				wall_132.SetActive (switch1on);
				wall_196.SetActive (switch1on);
				wall_171.SetActive (switch1on);
				wall_68.SetActive  (switch1on);
				wall_31.SetActive  (switch1on);
				wall_12.SetActive  (switch1on);
				wall_73.SetActive  (switch1on);
				wall_197.SetActive (switch1on);
				wall_183.SetActive (switch1on);
				wall_19.SetActive  (switch1on);
				//walls taht are invisible

				wall_211.SetActive (!switch1on);
				wall_212.SetActive (!switch1on);
				wall_213.SetActive (!switch1on);
				wall_214.SetActive (!switch1on);
				wall_215.SetActive (!switch1on);
				wall_48.SetActive  (!switch1on);
				wall_163.SetActive (!switch1on);
				wall_49.SetActive  (!switch1on);
				wall_82.SetActive  (!switch1on);
				wall_136.SetActive (!switch1on);
			}
			else if((counter4 % 2) == 1 ){
				//walls taht are invisible
				wall_132.SetActive (!switch1on);
				wall_196.SetActive (!switch1on);
				wall_171.SetActive (!switch1on);
				wall_68.SetActive  (!switch1on);
				wall_31.SetActive  (!switch1on);
				wall_12.SetActive  (!switch1on);
				wall_73.SetActive  (!switch1on);
				wall_197.SetActive (!switch1on);
				wall_183.SetActive (!switch1on);
				wall_19.SetActive  (!switch1on);


				//walls that are already visible
				wall_211.SetActive (switch1on);
				wall_212.SetActive (switch1on);
				wall_213.SetActive (switch1on);
				wall_214.SetActive (switch1on);
				wall_215.SetActive (switch1on);
				wall_48.SetActive  (switch1on);
				wall_163.SetActive (switch1on);
				wall_49.SetActive  (switch1on);
				wall_82.SetActive  (switch1on);
				wall_136.SetActive (switch1on);
			}
			wallTimeout4 -= Time.deltaTime;
			//Debug.Log ("timeout is: " + wallTimeout1);



			if(wallTimeout4 < 0)
			{

				switch4Pressed = false;
				switch4.SetActive (true);
				wallTimeout4 = 5;


			}
		}
	
	}

void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == ("switch1")) {
			switch1Pressed = true;
			counter = counter + .5;
			switch1.SetActive (false);

//			switch1on = !switch1on;



		}

		if (col.gameObject.tag == ("switch2")) {

			switch2Pressed = true;
			counter2 = counter2 + .5;
			switch2.SetActive (false);

		}

		if (col.gameObject.tag == ("switch3")) {

			switch3Pressed = true;
			counter3 = counter3 + .5;
			switch3.SetActive (false);

		}

		if (col.gameObject.tag == ("switch4")) {

			switch4Pressed = true;
			counter4 = counter4 + .5;
			switch4.SetActive (false);

		}

	}

}
