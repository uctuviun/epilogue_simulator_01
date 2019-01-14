using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class itemspawn : MonoBehaviour {

	public bool flatbreads, canteen, panpipes, knife, seedling, rival_vessel, player_vessel,
	root_puzzle, chain_release, alpha_gene, fortuneteller, bridge_log, reliquary_bone, nulla_card,
	source_token, release_chain, apex_lantern, raincatcher, chasm_log, reliquary_halo, omne_card;
	public GameObject rosetta, map;
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
		if(release_chain == true){
			PlayerPrefs.SetInt("releasedMode", 1);
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
		PlayerPrefs.SetInt("menuKill", 0);
		Destroy(gameObject);

	}
}
