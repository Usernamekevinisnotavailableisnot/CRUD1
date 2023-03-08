using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CRUD1.Form1;

namespace CRUD1
{
    public partial class Form1 : Form
    {
        #region dichiarazioni
        public struct Prodotti
        {
            public string nome;
            public float prezzo;
        }
        public Prodotti[] prodotti;
        public int dimensione, posizione;
      
        public Form1()
        {
            InitializeComponent();
            prodotti= new Prodotti[100];
            dimensione = 0;
        }
        #endregion
        #region Spazzatura
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion 
        #region Funzioni di servizio
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            prodotti[dimensione].nome = textBox1.Text;
            prodotti[dimensione].prezzo = float.Parse(textBox2.Text);
            dimensione++;
            listView1.Clear();
            Visualizza(prodotti);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
        private void Visualizza(Prodotti[] prodotto)
        {
            listView1.Items.Clear();
            for (int i = 0; i < dimensione; i++)
            {
                listView1.Items.Add(ProdString(prodotti[i]));
            }
        }
        public string ProdString(Prodotti prodotto)
        {
            return "Nome: " + prodotto.nome + " Prezzo: " + prodotto.prezzo.ToString("0.00") + "€";
        }

        private void Ricerca(Prodotti[] prodotto)
        {
            for(int i = 0; i < dimensione; i++)
            {
                if (textBox3.Text == prodotto[i].nome)
                {
                    posizione = dimensione;
                }
            }
            
        }

        public void Modifica(Prodotti[] prodotto)
        {
            prodotto[posizione].nome = textBox1.Text;

        }

        private void eliminazione(Prodotti[] prodotto)
        {
            for(int i = 0; i < dimensione; i++)
            {
                if(textBox4.Text== prodotto[i].nome)
                {
                    prodotti[i].nome = "";
                }
            }

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Modifica(prodotti);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            eliminazione(prodotti);
        }
        #endregion

    }
}
