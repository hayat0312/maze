using System;
using System.Collections.Generic;
using UnityEngine;

public class CubeFactory : MonoBehaviour
{

    int Sti, Stj;
    bool Uavailable = true, Davailable = true, Lavailable = true, Ravailable = true;
    GameObject edge;
    int seed = Environment.TickCount;
    System.Random rnd = new System.Random();
    public GameObject m_CubeBase;
    GameObject[] tracks = new GameObject[0];
    int k = 1;
    Vector3 edgeV;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int N = 100;
        int i = N, j = N;
        //GameObject[] directions;

        GameObject[,] cubes = new GameObject[i, j];
        if (Input.GetKeyDown(KeyCode.A))
        {
            for (i = 1; i < N; i++)
            {
                for (j = 1; j < N; j++)
                {
                    Vector3 pos = new Vector3(i, 0, j);
                    // m_CubeBase を元にして新しいm_CubeBaseを作成
                    GameObject gameobject = Instantiate(m_CubeBase, pos, Quaternion.identity);
                    gameobject.name = "cubes[" + i + "," + j + "]";
                    if (j == 1 || j == N - 1 || i == 1 || i == N - 1)
                    {
                        gameobject.GetComponent<Renderer>().material.color = Color.gray;
                    }
                    else
                    {
                        gameobject.GetComponent<Renderer>().material.color = Color.white;
                    }
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            System.Random rnd = new System.Random();    // インスタンスを生成
            Sti = rnd.Next(1, N / 2 - 1) * 2 + 1;         //3～9に変換
            Stj = rnd.Next(1, N / 2 - 1) * 2 + 1;
            edge = GameObject.Find("cubes[" + Sti.ToString() + "," + Stj.ToString() + "]");
            edge.GetComponent<Renderer>().material.color = Color.red;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            InvokeRepeating("cal", 0.05f, 0.05f);
        }
    }


    void cal()
    {
        int dire = 0;
        GameObject[] directions = new GameObject[0];
        if (Uavailable || Davailable || Ravailable || Lavailable)
        {
            Debug.Log("A");

            GameObject gameObjectU = GameObject.Find("cubes[" + Sti.ToString() + "," + (Stj + 2).ToString() + "]");
            if (gameObjectU.GetComponent<Renderer>().material.color == Color.white)
            {
                Uavailable = true;
                dire++;
                Array.Resize(ref directions, directions.Length + 1);
                directions[directions.Length - 1] = gameObjectU;
                //Debug.Log("U");
            }

            GameObject gameObjectD = GameObject.Find("cubes[" + Sti.ToString() + "," + (Stj - 2).ToString() + "]");
            if (gameObjectD.GetComponent<Renderer>().material.color == Color.white)
            {
                Davailable = true;
                dire++;
                Array.Resize(ref directions, directions.Length + 1);
                directions[directions.Length - 1] = gameObjectD;
                //Debug.Log("D");
            }

            GameObject gameObjectL = GameObject.Find("cubes[" + (Sti - 2).ToString() + "," + Stj.ToString() + "]");
            if (gameObjectL.GetComponent<Renderer>().material.color == Color.white)
            {
                Lavailable = true;
                dire++;
                Array.Resize(ref directions, directions.Length + 1);
                directions[directions.Length - 1] = gameObjectL;
                //Debug.Log("L");
            }

            GameObject gameObjectR = GameObject.Find("cubes[" + (Sti + 2).ToString() + "," + Stj.ToString() + "]");
            if (gameObjectR.GetComponent<Renderer>().material.color == Color.white)
            {
                Ravailable = true;
                dire++;
                Array.Resize(ref directions, directions.Length + 1);
                directions[directions.Length - 1] = gameObjectR;
                //Debug.Log("R");
            }
        }

        if (dire != 0)   //edgeの移動
        {
            Debug.Log("B");
            int direction = rnd.Next(0, dire);

            //Debug.Log(direction);
            //Debug.Log("message = " + directions[direction]);
            directions[direction].GetComponent<Renderer>().material.color = Color.red;
            edge = directions[direction];
            edgeV = edge.transform.position;
            GameObject gap = GameObject.Find("cubes[" + ((Sti + (int)edgeV.x) / 2).ToString() + "," + ((Stj + (int)edgeV.z) / 2).ToString() + "]");
            gap.GetComponent<Renderer>().material.color = Color.red;

            Array.Resize(ref tracks, tracks.Length + 1);
            tracks[tracks.Length - 1] = edge;
            Debug.Log(tracks.Length);

            Sti = (int)edgeV.x;
            Stj = (int)edgeV.z;
            k = 0;
        }
        else
        {
            Debug.Log("C");
            var list = new List<GameObject>();
            list.AddRange(this.tracks);
            list.Remove(edge);
            tracks = list.ToArray();
            //Debug.Log(this.tracks.Length);
            k++;
            edge = this.tracks[this.tracks.Length - k];
            //Debug.Log("New edge is " + edge);
            edgeV = edge.transform.position;
            Sti = (int)edgeV.x;
            Stj = (int)edgeV.z;
            Debug.Log(this.tracks.Length - k);
        }
    }
}