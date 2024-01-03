using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mentity1
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (PersoneloEntities pr = new PersoneloEntities())
            {
                var liste = pr.Tbl_Personel.ToList();
                foreach( var l in liste)
                {
                    ListViewItem ekle = new ListViewItem(l.Perid.ToString());
                    ekle.SubItems.Add(l.PerAd);
                    ekle.SubItems.Add(l.PerSoyad);
                    ekle.SubItems.Add(l.PerSehir);
                    ekle.SubItems.Add(l.PerMaas.ToString());
                    
                    if(l.PerDurum == true)
                    {
                        ekle.SubItems.Add("Evli");
                    }
                    else
                    {
                        ekle.SubItems.Add("Bekar");
                    }
                    ekle.SubItems.Add(l.PerYas);
                    metroListView1.Items.Add(ekle);
                }
            }
        }
    }
}
