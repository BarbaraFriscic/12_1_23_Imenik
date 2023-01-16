using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_1_23_Imenik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Osoba x;
       List<Osoba> Imenik = new List<Osoba>();

        private void btnUnos_Click(object sender, EventArgs e)
        { 
            try
            {
                if (txtIme.Text != "" && txtPrezime.Text != "")
                {
                    x = new Osoba()
                    {
                        Ime = txtIme.Text, Prezime = txtPrezime.Text
                    };
                    for(int i = 0; i < Imenik.Count(); i++)
                    {
                        if (x.Ime == Imenik[i].Ime && x.Prezime == Imenik[i].Prezime)
                            throw new ArgumentException();
                    }    
                    Imenik.Add(x);
                    lstImenik.Items.Add(x);

                    txtIme.Clear();
                    txtPrezime.Clear();
                    txtIme.Focus();
                }
                else
                {
                    MessageBox.Show("Sva polja su obvezna!");
                    if (txtIme.Text == "")
                        txtIme.Focus();
                    else
                        txtPrezime.Focus();
                }
                    
            }
            catch (FormatException)
            {
                MessageBox.Show("Ispravite svoj unos!");
                txtIme.Focus();
            }
           catch (ArgumentException)
            {
                MessageBox.Show("Osoba već postoji u imeniku!");
                txtIme.Clear();
                txtPrezime.Clear();
                txtIme.Focus();
            }
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {   lstImenik.SelectedItems.Clear();
            bool pronadjen = false;
            for(int i = 0; i < lstImenik.Items.Count; i++)
            {
                Osoba temp = (Osoba)lstImenik.Items[i];
                if(temp.Ime == txtTrazi.Text || temp.Prezime == txtTrazi.Text || temp.ToString() == txtTrazi.Text)
                {
                    pronadjen = true;
                    lstImenik.SelectedItems.Add(temp);
                }
            }
            if(pronadjen == false)
            {
                MessageBox.Show("Tražena osoba nije pronađena.");
                txtTrazi.Focus();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtIme.Focus();
        }
    }
}
