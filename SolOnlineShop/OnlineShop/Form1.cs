using OnlineShop.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Web.Script.Serialization;
using System.IO;

namespace OnlineShop
{
    public partial class Form1 : Form
    {
            private List<clsDesktop> Racunar = new List<clsDesktop>();
        public Form1()
        {
            InitializeComponent();
    }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {

                //Dohvatanje svih vrednosti iz forme
                string Cena = txtCena.Text;
                string Marka = txtMarka.Text;
                string Model = txtModel.Text;
                string Procesor = txtProcesor.Text;
                string Ram = txtRam.Text;
                string OperativniSistem = txtOperativniSistem.Text;
                string NacinUnosa = txtNacinUnosa.Text;
                string Napajanje = txtNapajanje.Text;
                string Kuciste = txtKuciste.Text;


                //Kreiranje Objekta tipa clsDesktop
                clsDesktop desk = new clsDesktop();
                desk.Cena = Convert.ToDouble(Cena);
                desk.Marka = Marka;
                desk.Model = Model;
                desk.Procesor = Convert.ToDouble(Procesor);
                desk.Ram = Convert.ToDouble(Ram);
                desk.OperativniSistem = OperativniSistem;
                desk.NacinUnosa = NacinUnosa;
                desk.Napajanje = Convert.ToInt32(Napajanje);
                desk.Kuciste = Kuciste;

                //Dodavanje Racunara u listu racnuara koriscenjem istance objekta
                Racunar.Add(desk);
                MessageBox.Show("Uspesno ste dodali racunar na list", "Uredjaj uspesno dodat", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Ciscenje svih polja iz forme
                txtCena.Clear();
                txtCena.Clear();
                txtMarka.Clear();
                txtModel.Clear();
                txtProcesor.Clear();
                txtRam.Clear();
                txtOperativniSistem.Clear();
                txtNacinUnosa.Clear();
                txtNapajanje.Clear();
                txtKuciste.Clear();

            }
            //U slucaju greske prikazujemo gresku
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Desila se greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Dugme za cuvanje u JSON tip objekta
        private void btnSaveJson_Click(object sender, EventArgs e)
        {
            //Ukoliko je lista prazna prikazujemo korisniku gresku
            if(Racunar.Count == 0)
            {
                MessageBox.Show("Lista je prazna", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Filtriranje i kreiranje ekstenzije za cuvanje
            sacuvajJson.Title = "Sacuvaj JSON fajl";
            sacuvajJson.Filter = "JSON |*.json";
            sacuvajJson.DefaultExt = ".json";


            //Ukoliko je proces cuvanja prekinut vracamo korisnika na pocetnu formu
            if (sacuvajJson.ShowDialog() == DialogResult.Cancel) return;

            //Kreiramo try blok gde pokusavamo da upisemo JSON u fajl
            try
            {
                //Kreiranje serilizatora preko javascript-a
                JavaScriptSerializer js = new JavaScriptSerializer();

                //Pretvaramo objekat koji nam se nalazi u listi u json
                string toJson = js.Serialize(Racunar);

                //Koriscenjem stream writera upisujemo u zeljeni fajl
                using (StreamWriter sw = new StreamWriter(sacuvajJson.FileName))
                {
                    sw.WriteLine(toJson + '\n');
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
