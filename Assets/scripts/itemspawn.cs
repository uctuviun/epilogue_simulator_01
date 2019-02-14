using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class itemspawn : MonoBehaviour {

	public bool flatbreads, canteen, panpipes, knife, seedling, rival_vessel, player_vessel,
	root_puzzle, chain_release, alpha_gene, fortuneteller, bridge_log, reliquary_bone, nulla_card,
	source_token, release_chain, apex_lantern, raincatcher, chasm_log, reliquary_halo, omne_card;
	public GameObject rosetta, map, releasing, win_screen, loss_screen, reset, fishes, minigame,
	fort1, fort2, fort3, fort4, fort5, fort6, fort7, fort8, fort9, fort10, fort11, fort12, fort13;
	AudioSource audiosource;

	// Use this for initialization
	void Start () {
		audiosource = GetComponent<AudioSource>();
		StartCoroutine(Activate());
	}

	// Update is called once per frame
	void Update () {

	}

	IEnumerator Activate(){
		if(PlayerPrefs.GetInt("soundOn") == 0){
			audiosource.enabled = false;
		}
		if(reliquary_bone == true){
			PlayerPrefs.SetInt("boneZone", 1);
		}
		if(reliquary_halo == true){
			PlayerPrefs.SetInt("haloZone", 1);
		}
		if(omne_card == true){
			PlayerPrefs.SetInt("whiteCardUsing", 1);
		}
		if(nulla_card == true){
			PlayerPrefs.SetInt("blackCardUsing", 1);
		}
		if(seedling == true){
			PlayerPrefs.SetInt("seedlingUsing", 1);
		}
		if(raincatcher == true){
			PlayerPrefs.SetInt("pouring", 1);
			Debug.Log("pouring");
			Scene currentScene = SceneManager.GetActiveScene();
			string sceneName = currentScene.name;
			if(sceneName == "world10(stairsmoss)" && PlayerPrefs.GetInt("elementOn") == 3){
				PlayerPrefs.SetInt("vesselFull", 1);
				Debug.Log("full");
			}
		}
		PlayerPrefs.SetInt("menuKill", 1);
		yield return new WaitForSeconds((this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length) -0.1f);
		if(apex_lantern == true){
			PlayerPrefs.SetInt("gameLight", 3);
			PlayerPrefs.SetInt("gameTuning", 3);
		}
		if(chain_release == true){
			SceneManager.LoadScene(Random.Range(1, 22));
			PlayerPrefs.SetInt("sendTo", (Random.Range(1, 4)));
		}
		if(root_puzzle == true){
			Instantiate(minigame, new Vector2(-275, -275), Quaternion.identity);
		}
		if(release_chain == true){
			PlayerPrefs.SetInt("releasedMode", 1);
			PlayerPrefs.SetInt("gameOver", 1);
			Instantiate(releasing, (new Vector2(PlayerPrefs.GetFloat("playerX") -.025f,
				PlayerPrefs.GetFloat("playerY"))), Quaternion.identity);
		}
		if(chasm_log == true){
			Instantiate(rosetta, new Vector2(-100, -100), Quaternion.identity);
		}
		if(bridge_log == true){
			Instantiate(map, new Vector2(-100, -100), Quaternion.identity);
		}
		if(source_token == true){
			SceneManager.LoadScene(0);
		}
		if(reliquary_bone == true){
			PlayerPrefs.SetInt("boneZone", 0);
		}
		if(reliquary_halo == true){
			PlayerPrefs.SetInt("haloZone", 0);
		}
		if(omne_card == true){
			PlayerPrefs.SetInt("whiteCardUsing", 0);
		}
		if(nulla_card == true){
			PlayerPrefs.SetInt("blackCardUsing", 0);
		}
		if(seedling == true){
			PlayerPrefs.SetInt("seedlingUsing", 0);
		}
		if(raincatcher == true){
			PlayerPrefs.SetInt("pouring", 0);
		}
		if(alpha_gene == true){
			Scene currentScene = SceneManager.GetActiveScene();
			string sceneName = currentScene.name;
			if(PlayerPrefs.GetInt("totalPillars") >= 8 && sceneName == "world2(savannahbasic)" &&
			PlayerPrefs.GetInt("fishesBorn") == 0){
				Instantiate(fishes, new Vector2(0,0), Quaternion.identity);
				PlayerPrefs.SetInt("fishesBorn", 1);
			}
		}
		if(fortuneteller == true){
			if(PlayerPrefs.GetInt("totalPillars") == 1){
				Instantiate(fort1, new Vector2(250,250), Quaternion.identity);
			}
			if(PlayerPrefs.GetInt("totalPillars") == 2){
				Instantiate(fort2, new Vector2(250,250), Quaternion.identity);
			}
			if(PlayerPrefs.GetInt("totalPillars") == 3){
				Instantiate(fort3, new Vector2(250,250), Quaternion.identity);
			}
			if(PlayerPrefs.GetInt("totalPillars") == 4){
				Instantiate(fort4, new Vector2(250,250), Quaternion.identity);
			}
			if(PlayerPrefs.GetInt("totalPillars") == 5){
				Instantiate(fort5, new Vector2(250,250), Quaternion.identity);
			}
			if(PlayerPrefs.GetInt("totalPillars") == 6){
				Instantiate(fort6, new Vector2(250,250), Quaternion.identity);
			}
			if(PlayerPrefs.GetInt("totalPillars") == 7){
				Instantiate(fort7, new Vector2(250,250), Quaternion.identity);
			}
			if(PlayerPrefs.GetInt("totalPillars") == 8){
				Instantiate(fort8, new Vector2(250,250), Quaternion.identity);
			}
			if(PlayerPrefs.GetInt("totalPillars") == 9){
				Instantiate(fort9, new Vector2(250,250), Quaternion.identity);
			}
			if(PlayerPrefs.GetInt("totalPillars") == 10){
				Instantiate(fort10, new Vector2(250,250), Quaternion.identity);
			}
			if(PlayerPrefs.GetInt("totalPillars") == 11){
				Instantiate(fort11, new Vector2(250,250), Quaternion.identity);
			}
			if(PlayerPrefs.GetInt("totalPillars") == 12){
				Instantiate(fort12, new Vector2(250,250), Quaternion.identity);
			}
			if(PlayerPrefs.GetInt("totalPillars") == 13){
				Instantiate(fort13, new Vector2(250,250), Quaternion.identity);
			}
		}
		if(player_vessel == true){
			Instantiate(loss_screen, new Vector2(-100, -100), Quaternion.identity);
			PlayerPrefs.SetInt("freeze", 1);
			PlayerPrefs.SetInt("gameOver", 1);
			Instantiate(reset, new Vector2 (-200, -200), Quaternion.identity);
		}
		if(rival_vessel == true){
			Scene currentScene = SceneManager.GetActiveScene();
			string sceneName = currentScene.name;
			if(sceneName == "world1(grassbasic)"){
				Instantiate(win_screen, new Vector2(-100, -100), Quaternion.identity);
				PlayerPrefs.SetInt("freeze", 1);
				PlayerPrefs.SetInt("gameOver", 1);
				Instantiate(reset, new Vector2 (-200, -200), Quaternion.identity);
			}
		}
		PlayerPrefs.SetInt("menuKill", 0);
		Destroy(gameObject);

	}
}
