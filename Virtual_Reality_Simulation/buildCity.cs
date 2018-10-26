using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildCity : MonoBehaviour {

	// Use this for initialization
	
		public GameObject[] buildings;
		public GameObject xStreet;
		public GameObject zStreet;
		public GameObject crossRoad;
		public GameObject car1;
		public GameObject car2;
		public GameObject car3;
		public GameObject rain;
		public GameObject tree1;
		public GameObject tree2;
		public GameObject streetLamp;
		public GameObject trashCan;
		public int[,] mapGrid;
		public int mapWidth = 20;
		public int mapheight = 20;
		public int footSpacing = 3;
		public int i=0,n=0;
	
	
	// Update is called once per frame
	void Start () {

		mapGrid = new int [mapWidth,mapheight];

		for(int h=0; h < mapheight; h++){
			for(int w=0; w < mapWidth ; w++ )
			{
				 mapGrid[w,h] = (int) (Mathf.PerlinNoise(w/10.0f,h/10.0f) * 10);
			}
		}
		int x=0;
		for(int n=0;n<50;n++){
			for(int h=0;h<mapheight;h++){
				mapGrid[x,h]=-1;
			}
			x+= Random.Range(2,10);
			if(x>=mapWidth)
			break;
		}
		int z=0;
		for(int n=0;n<20;n++){
			for(int j=0;j<mapWidth;j++){
				if(mapGrid[j,z]==-1)
				mapGrid[j,z]=-3;
				else
				mapGrid[j,z]=-2;
			}
			z+=Random.Range(4,20);
			if(z>=mapheight)
			break;
		}
		for(int h=0; h < mapheight; h++){
			for(int w=0; w < mapWidth ; w++ )
			{ 
				 int result = mapGrid[w,h];
				Vector3 pos = new Vector3(w * footSpacing,0,h * footSpacing);
				Vector3 pos1 = new Vector3(w* footSpacing-2,0,h* footSpacing);
				Vector3 pos2 = new Vector3(w* footSpacing,0,h*footSpacing-2);
				Vector3 pos3 = new Vector3(w* footSpacing+4,0,h* footSpacing);
				Vector3 pos4 = new Vector3(w* footSpacing,0,h*footSpacing+2);
				Vector3 pos5 = new Vector3(w* footSpacing-2,0,h* footSpacing-2);
				
				  if(result < -2){
				  Instantiate(crossRoad,pos,crossRoad.transform.rotation);
				  Instantiate(car1,pos,car1.transform.rotation);
				  Instantiate(trashCan,pos5	,trashCan.transform.rotation);
				  }
				  else if(result <-1){
				  	Instantiate(car2,pos,car2.transform.rotation);
				  	Instantiate(tree1,pos2,tree1.transform.rotation);
				    Instantiate(xStreet,pos,xStreet.transform.rotation);
				    Instantiate(streetLamp,pos4,streetLamp.transform.rotation);
				 }
				  else if(result < 0){
				  	Instantiate(car3,pos,car3.transform.rotation);
				  	Instantiate(tree2,pos1,tree2.transform.rotation);
				    Instantiate(zStreet,pos,zStreet.transform.rotation);
                    Instantiate(streetLamp,pos3,streetLamp.transform.rotation);
				    }
				  else if(result < 2)
				  Instantiate(buildings[0],pos,Quaternion.identity);
				  else if(result < 4)
				  Instantiate(buildings[1],pos,Quaternion.identity);
				  else if(result < 5)
				  Instantiate(buildings[2],pos,Quaternion.identity);
				  else if(result < 6)
				  Instantiate(buildings[3],pos,Quaternion.identity);
				  else if(result < 8)
				  Instantiate(buildings[4],pos,Quaternion.identity);
				  else if(result < 10)
				  Instantiate(buildings[5],pos,Quaternion.identity);


			}
		}
		
	}
	void Update () {
		


			
		
		
	}
}
