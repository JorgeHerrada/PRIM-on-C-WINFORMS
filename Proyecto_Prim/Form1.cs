using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Prim
{
    public partial class Principal : Form
    {
        bool algoritmo_aplicado = false;
        public Principal()
        {
            InitializeComponent();
        }
        
        private void btn_prueba_Click(object sender, EventArgs e)
        {
            // AVOID REPEATING THE ALGORITHM
            if (algoritmo_aplicado == true)
            {
                MessageBox.Show("Ya se ha aplicado el algoritmo.","ATENCIÓN",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
                        

            int nodos = 0;

            // CLEAN ALL THE LABELS
            lbl_peso_minimo.Text = "";
            lbl_peso.Text = "";
            lbl_enlace.Text = "";
            pBx_MATRIZ_MST.Show();

            // GRAPHS POSSIBILITIES
            if (rbtn_MODELO1.Checked == true)
            {
                // ENTER YOUR GRAPH         //A   B   C   D   E   F   G
                int[,] graph = new int[,] { { 0,  0,  5,  0,  0,  8,  2  }, //A
                                            { 0,  0,  5,  7,  0,  0,  8  }, //B
                                            { 5,  5,  0,  3,  4,  0,  10 }, //C
                                            { 0,  7,  3,  0,  6,  0,  0  }, //D
                                            { 0,  0,  4,  6,  0,  4,  0  }, //E
                                            { 8,  0,  0,  0,  4,  0,  0  }, //F
                                            { 2,  8, 10,  0,  0,  0,  0  }  //G
                                          };

                nodos = 7;
                
                // GET THE MINIMUM SPANNING TREE
                primMST(graph, nodos);

                // SHOW THE NEW GRAPH AND MATRIX WITH MINIMUM SPANNING TREE
                pBx_GRAFO.Image = Image.FromFile("casa_1_GRAFO_MST.png");
                pBx_MATRIZ_MST.Image = Image.FromFile("casa_1_matriz_MST.jpg");

                // UPDATE LABEL
                lbl_etiqueta_grafo.Text = "GRAFO CON AEM";
                lbl_etiqueta_matriz_final.Show();

                // TRUE, SO IT DOES NOT REPEAT
                algoritmo_aplicado = true;
            }
            else if (rbtn_MODELO2.Checked == true)
            {
                // ENTER YOUR GRAPH         //A   B   C   D   E   F   G
                int[,] graph = new int[,] { { 0,  5,  2,  8, 10,  0,  0  }, //A
                                            { 5,  0,  2,  0,  0,  0,  0  }, //B
                                            { 2,  2,  0,  6,  0,  0,  12 }, //C
                                            { 8,  0,  6,  0,  8,  5,  3  }, //D
                                            { 10, 0,  0,  8,  0,  2,  0  }, //E
                                            { 0,  0,  0,  5,  2,  0,  5  }, //F
                                            { 0,  0, 12,  3,  0,  5,  0  }  //G
                                          };

                nodos = 7;

                // GET THE MINIMUM SPANNING TREE
                primMST(graph, nodos);

                // SHOW THE NEW GRAPH AND MATRIX WITH MINIMUM SPANNING TREE
                pBx_GRAFO.Image = Image.FromFile("casa_2_GRAFO_MST.png");
                pBx_MATRIZ_MST.Image = Image.FromFile("casa_2_matriz_MST.jpg");

                // UPDATE LABEL
                lbl_etiqueta_grafo.Text = "GRAFO CON AEM";
                lbl_etiqueta_matriz_final.Show();

                // TRUE, SO IT DOES NOT REPEAT
                algoritmo_aplicado = true;
            }
            else if (rbtn_MODELO3.Checked == true)
            {
                // ENTER YOUR GRAPH         //A   B   C   D   E   F   G    H   I
                int[,] graph = new int[,] { {  0,  4, 12,  0,  0,  0, 14,  3,  5  }, //A
                                            {  4,  0,  2,  0,  0,  0,  0,  7,  0  }, //B
                                            { 12,  2,  0,  5,  0,  0,  0,  0,  0  }, //C
                                            {  0,  0,  5,  0, 10, 14,  0,  5,  0  }, //D
                                            {  0,  0,  0, 10,  0,  3, 10,  8,  0  }, //E
                                            {  0,  0,  0, 14,  3,  0,  4,  3,  0  }, //F
                                            { 14,  0,  0,  0, 10,  4,  0,  5,  6  }, //G
                                            {  3,  7,  0,  5,  8,  3,  5,  0,  4  }, //H
                                            {  5,  0,  0,  0,  0,  0,  6,  4,  0  }  //I
                                          };

                nodos = 9;

                // GET THE MINIMUM SPANNING TREE
                primMST(graph, nodos);

                // SHOW THE NEW GRAPH AND MATRIX WITH MINIMUM SPANNING TREE
                pBx_GRAFO.Image = Image.FromFile("casa_3_GRAFO_MST.png");
                pBx_MATRIZ_MST.Image = Image.FromFile("casa_3_matriz_MST.jpg");

                // UPDATE LABEL
                lbl_etiqueta_grafo.Text = "GRAFO CON AEM";
                lbl_etiqueta_matriz_final.Show();

                // TRUE, SO IT DOES NOT REPEAT
                algoritmo_aplicado = true;
            }
            else
            {
                MessageBox.Show("Primero selecciona un modelo al cual aplicar el algoritmo.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            

            // SHOW ALL THE LABELS
            lbl_ARISTAS.Show();
            lbl_PESOS.Show();
            lbl_peso_final.Show();
            lbl_peso_minimo.Show();
        }

        // A utility function to find the vertex with minimum key
        // value, from the set of vertices not yet included in MST
        int minKey(int[] key, bool[] mstSet, int V)
        {

            // Initialize min value
            int min = int.MaxValue, min_index = -1;

            for (int v = 0; v < V; v++)
                if (mstSet[v] == false && key[v] < min)
                {
                    min = key[v];
                    min_index = v;
                }

            return min_index;
        }


        // A utility function to print the constructed MST stored in parent[]
        void printMST(int[] parent, int[,] graph, int V)
        {
            int contador = 0;
            Console.WriteLine("Edge \tWeight");
            for (int i = 1; i < V; i++)
            {
                lbl_enlace.Text = lbl_enlace.Text + int_to_char(parent[i]) + " < --- > " + int_to_char(i) + "\n";
                lbl_peso.Text = lbl_peso.Text + graph[i, parent[i]].ToString() + " mts\n";
                contador += graph[i, parent[i]];
            }
            lbl_peso_minimo.Text = contador.ToString();
        }


        // Function to construct and print MST for a graph represented using adjacency matrix representation
        void primMST(int[,] graph, int V)
        {
            int[] parent = new int[V];// ARRAY TO STORE THE CONSTRUCTED MST
            int[] key = new int[V];// Key values used to pick minimum weight edge in cut
            bool[] mstSet = new bool[V];// To represent set of vertices included in MST

            // Initialize all keys as INFINITE
            for (int i = 0; i < V; i++){
                key[i] = int.MaxValue; // ALL KEYS TO MAX VALUE
                mstSet[i] = false; // SO NON VERTICES ARE ON THE MST
            }
            // Always include first 1st vertex in MST. Make key 0 so that this vertex is
            // picked as first vertex First node is always root of MST
            key[0] = 0;
            parent[0] = -1;
            // The MST will have V vertices
            for (int count = 0; count < V - 1; count++){
                int u = minKey(key, mstSet,V);// Pick the minimum key vertex from the set of vertices not yet included in MST
                mstSet[u] = true;// Add the picked vertex to the MST Set
                // Update key value and parent index of the adjacent vertices of the picked vertex. Consider
                // only those vertices which are not yet included in MST
                for (int v = 0; v < V; v++){
                    // graph[u][v] is non zero only for adjacent vertices of m mstSet[v] is false for vertices
                    // not yet included in MST Update the key only if graph[u][v] is smaller than key[v]
                    if (graph[u, v] != 0 && mstSet[v] == false && graph[u, v] < key[v]){
                        parent[v] = u;
                        key[v] = graph[u, v];
                    }
                }
            }
            printMST(parent, graph,V);// print the constructed MST
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // CLEAN ALL LABELS THAT ARE NOT NECCESARY
            lbl_enlace.Text = "";
            lbl_peso.Text = "";
            lbl_ARISTAS.Hide();
            lbl_PESOS.Hide();
            lbl_peso_final.Hide();
            lbl_peso_minimo.Hide();
            lbl_etiqueta_grafo.Hide();
            lbl_etiqueta_matriz.Hide();
            lbl_etiqueta_matriz_final.Hide();
            lbl_etiqueta_plano.Hide();
        }

        private void lbl_enlace_Click(object sender, EventArgs e)
        {
            // NO CODE
        }


        private void rbtn_MODELO1_CheckedChanged(object sender, EventArgs e)
        {
            // SHOW THE PLANS, GRAPH AND MATRIX ASSOCIATED TO PROYECT
            if (rbtn_MODELO1.Checked == true)
            {
                pBx_PLANO.Image = Image.FromFile("casa_1.jpg");
                pBx_GRAFO.Image = Image.FromFile("casa_1_GRAFO_.png");
                pBx_MATRIZ.Image = Image.FromFile("casa_1_matriz.jpg");
                algoritmo_aplicado = false;

                //SHOW LABELS
                lbl_etiqueta_grafo.Show();
                lbl_etiqueta_matriz.Show();
                lbl_etiqueta_grafo.Text = "GRAFO INICIAL";
                lbl_etiqueta_plano.Show();

                // CLEAN THE LABELS AND PICTUREBOX
                lbl_enlace.Text = "";
                lbl_peso.Text = "";
                lbl_ARISTAS.Hide();
                lbl_PESOS.Hide();
                lbl_peso_final.Hide();
                lbl_peso_minimo.Hide();
                lbl_etiqueta_matriz_final.Hide();
                pBx_MATRIZ_MST.Hide();
            }
        }

        private void rbtn_MODELO2_CheckedChanged(object sender, EventArgs e)
        {
            // SHOW THE PLANS, GRAPH AND MATRIX ASSOCIATED TO PROYECT
            if (rbtn_MODELO2.Checked == true)
            {
                pBx_PLANO.Image = Image.FromFile("casa_2.jpg");
                pBx_GRAFO.Image = Image.FromFile("casa_2_GRAFO_.png");
                pBx_MATRIZ.Image = Image.FromFile("casa_2_matriz.jpg");
                algoritmo_aplicado = false;

                //SHOW LABELS
                lbl_etiqueta_grafo.Show();
                lbl_etiqueta_grafo.Text = "GRAFO INICIAL";
                lbl_etiqueta_matriz.Show();
                lbl_etiqueta_plano.Show();

                // CLEAN THE LABELS AND PICTUREBOX
                lbl_enlace.Text = "";
                lbl_peso.Text = "";
                lbl_ARISTAS.Hide();
                lbl_PESOS.Hide();
                lbl_peso_final.Hide();
                lbl_peso_minimo.Hide();
                pBx_MATRIZ_MST.Hide();
                lbl_etiqueta_matriz_final.Hide();
            }
        }

        private void rbtn_MODELO3_CheckedChanged(object sender, EventArgs e)
        {
            // SHOW THE PLANS, GRAPH AND MATRIX ASSOCIATED TO PROYECT
            if (rbtn_MODELO3.Checked == true)
            {
                pBx_PLANO.Image = Image.FromFile("casa_3.jpg");
                pBx_GRAFO.Image = Image.FromFile("casa_3_GRAFO_.png");
                pBx_MATRIZ.Image = Image.FromFile("casa_3_matriz.jpg");
                algoritmo_aplicado = false;

                //SHOW LABELS
                lbl_etiqueta_grafo.Show();
                lbl_etiqueta_grafo.Text = "GRAFO INICIAL";
                lbl_etiqueta_matriz.Show();
                lbl_etiqueta_plano.Show();

                // CLEAN THE LABELS AND PICTUREBOX
                lbl_enlace.Text = "";
                lbl_peso.Text = "";
                lbl_ARISTAS.Hide();
                lbl_PESOS.Hide();
                lbl_peso_final.Hide();
                lbl_peso_minimo.Hide();
                pBx_MATRIZ_MST.Hide();
                lbl_etiqueta_matriz_final.Hide();
            }
        }

        // FUNCTION TO PRINT THE CHACTERS ASSOCIATED WITH EACH INTEGER
        private string int_to_char(int number)
        {
            switch (number)
            {
                case 0:
                    return "A";
                case 1:
                    return "B";
                case 2:
                    return "C";
                case 3:
                    return "D";
                case 4:
                    return "E";
                case 5:
                    return "F";
                case 6:
                    return "G";
                case 7:
                    return "H";
                case 8:
                    return "I";
                case 9:
                    return "J";
                default:
                    return "-1";
            }
        }
    }
}
