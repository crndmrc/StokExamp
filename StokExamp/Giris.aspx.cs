using StokExamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StokExamp
{
    public partial class Giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            buttonEnableAyarla();
            if (IsPostBack) return;
            formuTemizle();
        }
        private void formuTemizle()
        {
            lblId.Text = "";
            txtAd.Text = "";
            txtTelefon.Text = "";
        }
        private void buttonEnableAyarla()
        {
            if (gvMusteri.SelectedIndex >= 0)
            {
                btnSil.Enabled = true;
            }
            else
            {
                btnSil.Enabled = false;
            }
        }
        protected void btnListele_Click(object sender, EventArgs e)
        {
            STOKEntities1 _context = new STOKEntities1();
            gvMusteri.DataSource = _context.tbl_Musteri.ToList();
            gvMusteri.DataBind();

            gvMusteri.SelectedIndex = -1;
            gvMusteri_SelectedIndexChanged(null, null);
        }

        protected void gvMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gvMusteri.SelectedIndex >= 0)
            {
                int seciliId = int.Parse(gvMusteri.SelectedValue.ToString());

                STOKEntities1 _context = new STOKEntities1();
                tbl_Musteri _musteri = _context.tbl_Musteri.Find(seciliId);

                lblId.Text = _musteri.id.ToString();
                txtAd.Text = _musteri.adi;
                txtTelefon.Text = _musteri.telefon.ToString();
            }
            else
            {
                formuTemizle();
            }
            buttonEnableAyarla();
        }

        protected void btnYeni_Click(object sender, EventArgs e)
        {
            gvMusteri.SelectedIndex = -1;
            formuTemizle();
            buttonEnableAyarla();
            txtAd.Focus();
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lblId.Text == "") 
            {
                STOKEntities1 _context = new STOKEntities1();
                tbl_Musteri _musteri = new tbl_Musteri();
                _musteri.adi = txtAd.Text;
                _musteri.telefon = int.Parse(txtTelefon.Text);

                _context.tbl_Musteri.Add(_musteri);
                _context.SaveChanges();

                btnListele_Click(null, null);
            }
            else
            {
                STOKEntities1 _context = new STOKEntities1();
                tbl_Musteri _musteri = _context.tbl_Musteri.Find(int.Parse(lblId.Text));
                _musteri.adi = txtAd.Text;
                _musteri.telefon = int.Parse(txtTelefon.Text);
                _context.SaveChanges();

                btnListele_Click(null, null);
            }

            buttonEnableAyarla();
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            if (lblId.Text != "")
            {
                STOKEntities1 _context = new STOKEntities1();
                tbl_Musteri _musteri = _context.tbl_Musteri.Find(int.Parse(lblId.Text));

                _context.tbl_Musteri.Remove(_musteri);
                _context.SaveChanges();
                btnListele_Click(null, null);
            }

            buttonEnableAyarla();
        }


    }
}