
namespace Proyecto_Prim
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_prueba = new System.Windows.Forms.Button();
            this.lbl_enlace = new System.Windows.Forms.Label();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.lbl_peso_final = new System.Windows.Forms.Label();
            this.lbl_peso_minimo = new System.Windows.Forms.Label();
            this.lbl_ARISTAS = new System.Windows.Forms.Label();
            this.lbl_PESOS = new System.Windows.Forms.Label();
            this.pBx_GRAFO = new System.Windows.Forms.PictureBox();
            this.pBx_PLANO = new System.Windows.Forms.PictureBox();
            this.pBx_MATRIZ = new System.Windows.Forms.PictureBox();
            this.rbtn_MODELO1 = new System.Windows.Forms.RadioButton();
            this.rbtn_MODELO2 = new System.Windows.Forms.RadioButton();
            this.rbtn_MODELO3 = new System.Windows.Forms.RadioButton();
            this.pBx_MATRIZ_MST = new System.Windows.Forms.PictureBox();
            this.lbl_etiqueta_plano = new System.Windows.Forms.Label();
            this.lbl_etiqueta_grafo = new System.Windows.Forms.Label();
            this.lbl_etiqueta_matriz = new System.Windows.Forms.Label();
            this.lbl_etiqueta_matriz_final = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBx_GRAFO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBx_PLANO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBx_MATRIZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBx_MATRIZ_MST)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_prueba
            // 
            this.btn_prueba.BackColor = System.Drawing.SystemColors.InfoText;
            this.btn_prueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_prueba.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_prueba.Location = new System.Drawing.Point(1000, 11);
            this.btn_prueba.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_prueba.Name = "btn_prueba";
            this.btn_prueba.Size = new System.Drawing.Size(204, 95);
            this.btn_prueba.TabIndex = 0;
            this.btn_prueba.Text = "Aplicar Algoritmo";
            this.btn_prueba.UseVisualStyleBackColor = false;
            this.btn_prueba.Click += new System.EventHandler(this.btn_prueba_Click);
            // 
            // lbl_enlace
            // 
            this.lbl_enlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_enlace.Location = new System.Drawing.Point(1284, 162);
            this.lbl_enlace.Name = "lbl_enlace";
            this.lbl_enlace.Size = new System.Drawing.Size(197, 363);
            this.lbl_enlace.TabIndex = 9;
            this.lbl_enlace.Text = "Despliega aristas";
            this.lbl_enlace.Click += new System.EventHandler(this.lbl_enlace_Click);
            // 
            // lbl_peso
            // 
            this.lbl_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_peso.Location = new System.Drawing.Point(1549, 162);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(215, 374);
            this.lbl_peso.TabIndex = 10;
            this.lbl_peso.Text = "Despliega peso";
            // 
            // lbl_peso_final
            // 
            this.lbl_peso_final.AutoSize = true;
            this.lbl_peso_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_peso_final.Location = new System.Drawing.Point(1282, 486);
            this.lbl_peso_final.Name = "lbl_peso_final";
            this.lbl_peso_final.Size = new System.Drawing.Size(289, 49);
            this.lbl_peso_final.TabIndex = 11;
            this.lbl_peso_final.Text = "Distancia mín:";
            // 
            // lbl_peso_minimo
            // 
            this.lbl_peso_minimo.AutoSize = true;
            this.lbl_peso_minimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_peso_minimo.Location = new System.Drawing.Point(1547, 486);
            this.lbl_peso_minimo.Name = "lbl_peso_minimo";
            this.lbl_peso_minimo.Size = new System.Drawing.Size(286, 39);
            this.lbl_peso_minimo.TabIndex = 12;
            this.lbl_peso_minimo.Text = "Muestra peso min";
            // 
            // lbl_ARISTAS
            // 
            this.lbl_ARISTAS.AutoSize = true;
            this.lbl_ARISTAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_ARISTAS.Location = new System.Drawing.Point(1284, 98);
            this.lbl_ARISTAS.Name = "lbl_ARISTAS";
            this.lbl_ARISTAS.Size = new System.Drawing.Size(145, 49);
            this.lbl_ARISTAS.TabIndex = 13;
            this.lbl_ARISTAS.Text = "Nodos";
            // 
            // lbl_PESOS
            // 
            this.lbl_PESOS.AutoSize = true;
            this.lbl_PESOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_PESOS.Location = new System.Drawing.Point(1548, 98);
            this.lbl_PESOS.Name = "lbl_PESOS";
            this.lbl_PESOS.Size = new System.Drawing.Size(198, 49);
            this.lbl_PESOS.TabIndex = 14;
            this.lbl_PESOS.Text = "Distancia";
            // 
            // pBx_GRAFO
            // 
            this.pBx_GRAFO.Location = new System.Drawing.Point(660, 162);
            this.pBx_GRAFO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pBx_GRAFO.Name = "pBx_GRAFO";
            this.pBx_GRAFO.Size = new System.Drawing.Size(544, 406);
            this.pBx_GRAFO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBx_GRAFO.TabIndex = 15;
            this.pBx_GRAFO.TabStop = false;
            // 
            // pBx_PLANO
            // 
            this.pBx_PLANO.Location = new System.Drawing.Point(51, 162);
            this.pBx_PLANO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pBx_PLANO.Name = "pBx_PLANO";
            this.pBx_PLANO.Size = new System.Drawing.Size(544, 780);
            this.pBx_PLANO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBx_PLANO.TabIndex = 17;
            this.pBx_PLANO.TabStop = false;
            // 
            // pBx_MATRIZ
            // 
            this.pBx_MATRIZ.Location = new System.Drawing.Point(660, 607);
            this.pBx_MATRIZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pBx_MATRIZ.Name = "pBx_MATRIZ";
            this.pBx_MATRIZ.Size = new System.Drawing.Size(544, 334);
            this.pBx_MATRIZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBx_MATRIZ.TabIndex = 18;
            this.pBx_MATRIZ.TabStop = false;
            // 
            // rbtn_MODELO1
            // 
            this.rbtn_MODELO1.AutoSize = true;
            this.rbtn_MODELO1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_MODELO1.Location = new System.Drawing.Point(51, 11);
            this.rbtn_MODELO1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_MODELO1.Name = "rbtn_MODELO1";
            this.rbtn_MODELO1.Size = new System.Drawing.Size(235, 52);
            this.rbtn_MODELO1.TabIndex = 19;
            this.rbtn_MODELO1.TabStop = true;
            this.rbtn_MODELO1.Text = "Modelo #1";
            this.rbtn_MODELO1.UseVisualStyleBackColor = true;
            this.rbtn_MODELO1.CheckedChanged += new System.EventHandler(this.rbtn_MODELO1_CheckedChanged);
            // 
            // rbtn_MODELO2
            // 
            this.rbtn_MODELO2.AutoSize = true;
            this.rbtn_MODELO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_MODELO2.Location = new System.Drawing.Point(351, 11);
            this.rbtn_MODELO2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_MODELO2.Name = "rbtn_MODELO2";
            this.rbtn_MODELO2.Size = new System.Drawing.Size(235, 52);
            this.rbtn_MODELO2.TabIndex = 20;
            this.rbtn_MODELO2.TabStop = true;
            this.rbtn_MODELO2.Text = "Modelo #2";
            this.rbtn_MODELO2.UseVisualStyleBackColor = true;
            this.rbtn_MODELO2.CheckedChanged += new System.EventHandler(this.rbtn_MODELO2_CheckedChanged);
            // 
            // rbtn_MODELO3
            // 
            this.rbtn_MODELO3.AutoSize = true;
            this.rbtn_MODELO3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_MODELO3.Location = new System.Drawing.Point(660, 11);
            this.rbtn_MODELO3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_MODELO3.Name = "rbtn_MODELO3";
            this.rbtn_MODELO3.Size = new System.Drawing.Size(235, 52);
            this.rbtn_MODELO3.TabIndex = 21;
            this.rbtn_MODELO3.TabStop = true;
            this.rbtn_MODELO3.Text = "Modelo #3";
            this.rbtn_MODELO3.UseVisualStyleBackColor = true;
            this.rbtn_MODELO3.CheckedChanged += new System.EventHandler(this.rbtn_MODELO3_CheckedChanged);
            // 
            // pBx_MATRIZ_MST
            // 
            this.pBx_MATRIZ_MST.Location = new System.Drawing.Point(1291, 607);
            this.pBx_MATRIZ_MST.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pBx_MATRIZ_MST.Name = "pBx_MATRIZ_MST";
            this.pBx_MATRIZ_MST.Size = new System.Drawing.Size(544, 334);
            this.pBx_MATRIZ_MST.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBx_MATRIZ_MST.TabIndex = 22;
            this.pBx_MATRIZ_MST.TabStop = false;
            // 
            // lbl_etiqueta_plano
            // 
            this.lbl_etiqueta_plano.AutoSize = true;
            this.lbl_etiqueta_plano.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_etiqueta_plano.Location = new System.Drawing.Point(46, 131);
            this.lbl_etiqueta_plano.Name = "lbl_etiqueta_plano";
            this.lbl_etiqueta_plano.Size = new System.Drawing.Size(105, 29);
            this.lbl_etiqueta_plano.TabIndex = 23;
            this.lbl_etiqueta_plano.Text = "PLANO:";
            // 
            // lbl_etiqueta_grafo
            // 
            this.lbl_etiqueta_grafo.AutoSize = true;
            this.lbl_etiqueta_grafo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_etiqueta_grafo.Location = new System.Drawing.Point(655, 131);
            this.lbl_etiqueta_grafo.Name = "lbl_etiqueta_grafo";
            this.lbl_etiqueta_grafo.Size = new System.Drawing.Size(200, 29);
            this.lbl_etiqueta_grafo.TabIndex = 24;
            this.lbl_etiqueta_grafo.Text = "GRAFO INICIAL:";
            // 
            // lbl_etiqueta_matriz
            // 
            this.lbl_etiqueta_matriz.AutoSize = true;
            this.lbl_etiqueta_matriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_etiqueta_matriz.Location = new System.Drawing.Point(655, 576);
            this.lbl_etiqueta_matriz.Name = "lbl_etiqueta_matriz";
            this.lbl_etiqueta_matriz.Size = new System.Drawing.Size(255, 36);
            this.lbl_etiqueta_matriz.TabIndex = 25;
            this.lbl_etiqueta_matriz.Text = "MATRIZ INICIAL:";
            // 
            // lbl_etiqueta_matriz_final
            // 
            this.lbl_etiqueta_matriz_final.AutoSize = true;
            this.lbl_etiqueta_matriz_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_etiqueta_matriz_final.Location = new System.Drawing.Point(1284, 585);
            this.lbl_etiqueta_matriz_final.Name = "lbl_etiqueta_matriz_final";
            this.lbl_etiqueta_matriz_final.Size = new System.Drawing.Size(236, 36);
            this.lbl_etiqueta_matriz_final.TabIndex = 26;
            this.lbl_etiqueta_matriz_final.Text = "MATRIZ FINAL:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1885, 998);
            this.Controls.Add(this.lbl_etiqueta_matriz_final);
            this.Controls.Add(this.lbl_etiqueta_matriz);
            this.Controls.Add(this.lbl_etiqueta_grafo);
            this.Controls.Add(this.lbl_etiqueta_plano);
            this.Controls.Add(this.pBx_MATRIZ_MST);
            this.Controls.Add(this.rbtn_MODELO3);
            this.Controls.Add(this.rbtn_MODELO2);
            this.Controls.Add(this.rbtn_MODELO1);
            this.Controls.Add(this.pBx_MATRIZ);
            this.Controls.Add(this.pBx_PLANO);
            this.Controls.Add(this.pBx_GRAFO);
            this.Controls.Add(this.lbl_PESOS);
            this.Controls.Add(this.lbl_ARISTAS);
            this.Controls.Add(this.lbl_peso_minimo);
            this.Controls.Add(this.lbl_peso_final);
            this.Controls.Add(this.lbl_peso);
            this.Controls.Add(this.lbl_enlace);
            this.Controls.Add(this.btn_prueba);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = " Proyecto PRIM  -  HERRADA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBx_GRAFO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBx_PLANO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBx_MATRIZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBx_MATRIZ_MST)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_prueba;
        private System.Windows.Forms.Label lbl_enlace;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.Label lbl_peso_final;
        private System.Windows.Forms.Label lbl_peso_minimo;
        private System.Windows.Forms.Label lbl_ARISTAS;
        private System.Windows.Forms.Label lbl_PESOS;
        private System.Windows.Forms.PictureBox pBx_GRAFO;
        private System.Windows.Forms.PictureBox pBx_PLANO;
        private System.Windows.Forms.PictureBox pBx_MATRIZ;
        private System.Windows.Forms.RadioButton rbtn_MODELO1;
        private System.Windows.Forms.RadioButton rbtn_MODELO2;
        private System.Windows.Forms.RadioButton rbtn_MODELO3;
        private System.Windows.Forms.PictureBox pBx_MATRIZ_MST;
        private System.Windows.Forms.Label lbl_etiqueta_plano;
        private System.Windows.Forms.Label lbl_etiqueta_grafo;
        private System.Windows.Forms.Label lbl_etiqueta_matriz;
        private System.Windows.Forms.Label lbl_etiqueta_matriz_final;
    }
}

