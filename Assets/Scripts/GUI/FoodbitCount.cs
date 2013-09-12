using UnityEngine;
using System.Collections;

public class FoodbitCount : MonoBehaviour {

	public Ether eth;
	Settings settings;
	Logger lg;
	
	float log_time;
	string filename;
	
	void Start() {
		name = "FoodbitCount";
		eth = Ether.getInstance();
		settings = Settings.getInstance();
		lg = Logger.getInstance();
		
		log_time = float.Parse( settings.contents["config"]["log_time"].ToString() );
		filename = "footbits-"+Utility.UnixTimeNow().ToString();
		lg.write( log_time.ToString(), filename );
		InvokeRepeating("log",0,log_time);
	}

	void Update ()	{
		guiText.text = "Foodbits: " + eth.foodbit_count;
	}
	
	void log () {
		lg.write( ","+eth.foodbit_count.ToString(), filename );
	}
}
