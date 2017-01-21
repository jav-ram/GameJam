using UnityEngine;
using System.Collections;

public class GenerateLevel : MonoBehaviour {

	public GameObject floor;
	public GameObject player;
	private float scale = 1f;

	private int width;
	private int height;
	private int direction;
	private int cX;
	private int cY;
	private int wX;
	private int wY;


	// Use this for initialization
	void Start(){

		width = (int)transform.localScale.x / (int)scale;
		height = (int)transform.localScale.y / (int)scale;
		cX = width / 2;
		cY = height / 2;
		int[,] grid = new int[width,height];

		for (int y =0; y < height; y++){
			for (int x = 0; x < width; x++){
				grid [x, y] = 0;
			}
		}

		for (int i = 0; i < 150; i++) {
			direction = Random.Range (1, 5);
			if (direction == 1) {
				cX += 1;
			} else if (direction == 2) {
				cX -= 1;
			} else if (direction == 3) {
				cY += 1;
			} else if (direction == 4) {
				cY -= 1;
			}
			grid [cX, cY] = 1;


		}

		int[,] gri = grid;

		for (int y = 1; y < height-1; y++){
			for (int x = 1; x < width-1; x++){
				if (gri [x, y] == 0) {
					if (gri [x + 1, y] > 0 || gri [x - 1, y] > 0  || gri [x, y + 1] > 0  || gri [x, y - 1] > 0 ) {
						if (gri [x + 1, y + 1] > 0  || gri [x + 1, y - 1] > 0 || gri [x - 1, y + 1] > 0 || gri [x - 1, y - 1] > 0 ) {
							grid [x, y] = 2;
						}
					}
				}
			}
		}



		GameObject tempFloor;
		for (int y = 0; y < height; y++){
			for (int x = 0; x < width; x++){
				if (x <= 50 && y <= 50) { //Cuadrante Superior izquierdo
					wX = -(50 - x);
					wY = 50 - y;
				} else if (x > 50 && y <= 50){ //Cuadrante Superior derecho
					wX = 50 - x;
					wY = 50 - y;
				} else if (x <= 50 && y > 50){ //Cuadrante Inferior izquierdo
					wX = -(50 - x);
					wY = -(50 - y);
				} else if (x > 50 && y > 50){ //Cuadrante Inferior derecho
					wX = 50 - x;
					wY = -(50 - y);
				}

				if (grid [x, y] == 2) {
					tempFloor = Instantiate(floor,new Vector3(wX*scale*2+width+1f,wY*scale*2-height-1f, 1), player.transform.rotation) as GameObject;
					tempFloor.transform.parent = GameObject.Find ("Wall").transform;
				}
				
			}
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
