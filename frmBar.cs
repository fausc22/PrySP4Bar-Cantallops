using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrySP4Bar_Cantallops
{
    public partial class frmBar : Form
    {
        //declaro la matriz y vector para cargar los datos
        public int[,] MatMozos = new int[5, 4];
        public int[] VecTotales = new int[10];


        public frmBar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Agrego los mozos en las filas
            int i;
            for (i= 0; i < 5; i++)
            {
                dgvMozos.Rows.Add();
            }
            dgvMozos.Rows[0].Cells[0].Value = "Julio";
            dgvMozos.Rows[1].Cells[0].Value = "Esteban";
            dgvMozos.Rows[2].Cells[0].Value = "Javier";
            dgvMozos.Rows[3].Cells[0].Value = "Gonzalo";
            dgvMozos.Rows[4].Cells[0].Value = "Alberto";
            dgvMozos.Columns[0].ReadOnly = true;

        }


            

        private void btnValidar_Click(object sender, EventArgs e)
        {
            int fila = 0; 
            int col = 1;  
            int i = 0;  
            int colmat = 0;

            while (fila <= 4)
            {
                while (col <= 4)
                {
                    if (dgvMozos.Rows[fila].Cells[col].Value == null || dgvMozos.Rows[fila].Cells[col].Value == "") //condicion para que se verifiquen los valores numericos
                    {
                        i++;
                    }
                    col++;
                }
                col = 1;
                fila++;
            }

            if (i == 0)
            {
                btnMozo.Enabled = true;
                btnTotales.Enabled = true; //si se escribieron valores numericos se validan los datos y se activan los botones

                fila = 0;
                col = 1;

                while (fila <= 4)
                {
                    while (col <= 4 && colmat <= MatMozos.GetLength(1))
                    {
                        MatMozos[fila, colmat] = Convert.ToInt32(dgvMozos.Rows[fila].Cells[col].Value); //se escriben los valores en la matriz
                        col++;
                        colmat++;
                    }
                    col = 1;
                    colmat = 0;
                    fila++;
                }
            }
            else
            {
                btnMozo.Enabled = false;
                btnTotales.Enabled = false;
                MessageBox.Show("Solo deben ingresarse valores númericos",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);  //si no se cumple el i = 0 se bloquean los botones y salen un mensaje
            }
        }

        private void btnMozo_Click(object sender, EventArgs e)
        {
            int col = 0;
            int fila = 0;
            int Suma = 0;
            int Mayor = 0;
            int Mozo = 0;

            while (fila < MatMozos.GetLength(0))
            {
                while (col < MatMozos.GetLength(1))
                {
                    Suma = Suma + MatMozos[fila, col];  // gira la matriz sumando los importes de los mozos
                    col++;
                }
                VecTotales[fila] = Suma;
                col = 0;
                fila++;
                Suma = 0;
            }

            fila = 0;
            Mayor = VecTotales[0];
            while (fila <= 4) //gira alrededor de los 5 mozos
            {
                if (VecTotales[fila] >= Mayor)  //si el valor del vector es mas grande que MAYOR se encuentra la condicion
                {
                    Mayor = VecTotales[fila]; //el valor del vector se convierte en el mayor
                    Mozo = fila;  //el valor del vector es el total del mozo x
                }
                fila++;
            }

            if (Mozo == 0) //segun la posicion de la variable mozo se va a escribir el mozo con importe mayor
            {
                txtNombreMozo.Text = "Julio";
                txtImporteMozo.Text = Mayor.ToString();
            }
            if (Mozo == 1)
            {
                txtNombreMozo.Text = "Esteban";
                txtImporteMozo.Text = Mayor.ToString();
            }
            if (Mozo == 2)
            {
                txtNombreMozo.Text = "Javier";
                txtImporteMozo.Text = Mayor.ToString();
            }
            if (Mozo == 3)
            {
                txtNombreMozo.Text = "Gonzalo";
                txtImporteMozo.Text = Mayor.ToString();
            }
            if (Mozo == 4)
            {
                txtNombreMozo.Text = "Alberto";
                txtImporteMozo.Text = Mayor.ToString();
            }






        }

        private void btnTotales_Click(object sender, EventArgs e)
        {
            int fila = 0;
            int col = 0;
            int i = 5; 
            int Suma = 0;
            int Total = 0;

            while (col < MatMozos.GetLength(1) && i <= 9) //gira en la matriz para ir sumando los importes
            {
                Suma = 0; //reinicia cada categoria
                while (fila < MatMozos.GetLength(0))
                {
                    Suma = Suma + MatMozos[fila, col]; //suma el valor de la matriz
                    fila++;
                }
                VecTotales[i] = Suma; //escribe el vector con el valor de la matriz
                Total = Total + Suma; //suma el valor a la variable TOTAL
                fila = 0;
                col++;
                i++; //gira en las demas posiciones del vector VecTotales
            }

            VecTotales[9] = Total; //en la ultima posicion se escribe el importe FINAL

            txtComida.Text = Convert.ToString(VecTotales[5]);
            txtBebidasin.Text = Convert.ToString(VecTotales[6]);
            txtBebidacon.Text = Convert.ToString(VecTotales[7]);
            txtPostre.Text = Convert.ToString(VecTotales[8]);
            txtTotal.Text = Convert.ToString(VecTotales[9]);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
