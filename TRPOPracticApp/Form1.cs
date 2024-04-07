using System.Configuration;
using TRPOPractic.Lib;

namespace TRPOPracticApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                RasLib cn = new(
                    double.Parse(Vj_textBox.Text),
                    double.Parse(Pj_bol_textBox.Text),
                    double.Parse(a_textBox.Text),
                    double.Parse(dvh_textBox.Text),
                    double.Parse(Muj_textBox.Text),
                    byte.Parse(nf_textBox.Text),
                    double.Parse(np_textBox.Text),
                    double.Parse(pj_mal_textBox.Text),
                    double.Parse(dk_textBox.Text));

                textBoxOmegae.Text = cn.OmegaE.ToString();
                textBoxd0.Text = cn.d0.ToString();
                textBoxf.Text = cn.f.ToString();
                textBoxAf.Text = cn.Af.ToString();
                textBoxR.Text = cn.R.ToString();
                textBoxD.Text = cn.D.ToString();
                textBoxH.Text = cn.H.ToString();
                textBoxKf.Text = cn.Kf.ToString();
                textBoxVf.Text = cn.Vf.ToString();
                textBoxNf.Text = cn.Nf.ToString();;
                textBoxNfr.Text = cn.Nfr.ToString();
                textBoxNfreal.Text = cn.Nfreal.ToString();
                textBoxNfrreal.Text = cn.Nfrreal.ToString();
                textBoxVfreal.Text = cn.Vfreal.ToString();

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                if (config.AppSettings.Settings["_textBox_Vj"] != null)
                {
                    config.AppSettings.Settings["_textBox_Vj"].Value = Vj_textBox.Text;
                }
                else
                {
                    config.AppSettings.Settings.Add("_textBox_Vj", Vj_textBox.Text);
                }

                if (config.AppSettings.Settings["_Pj_bol_textBox"] != null)
                {
                    config.AppSettings.Settings["_Pj_bol_textBox"].Value = Pj_bol_textBox.Text;
                }
                else
                {
                    config.AppSettings.Settings.Add("_Pj_bol_textBox", Pj_bol_textBox.Text);
                }

                if (config.AppSettings.Settings["_a_textBox"] != null)
                {
                    config.AppSettings.Settings["_a_textBox"].Value = a_textBox.Text;
                }
                else
                {
                    config.AppSettings.Settings.Add("_a_textBox", a_textBox.Text);
                }

                if (config.AppSettings.Settings["_dvh_textBox"] != null)
                {
                    config.AppSettings.Settings["_dvh_textBox"].Value = dvh_textBox.Text;
                }
                else
                {
                    config.AppSettings.Settings.Add("_dvh_textBox", dvh_textBox.Text);
                }

                if (config.AppSettings.Settings["_Muj_textBox"] != null)
                {
                    config.AppSettings.Settings["_Muj_textBox"].Value = Muj_textBox.Text;
                }
                else
                {
                    config.AppSettings.Settings.Add("_Muj_textBox", Muj_textBox.Text);
                }

                if (config.AppSettings.Settings["_nf_textBox"] != null)
                {
                    config.AppSettings.Settings["_nf_textBox"].Value = nf_textBox.Text;
                }
                else
                {
                    config.AppSettings.Settings.Add("_nf_textBox", nf_textBox.Text);
                }

                if (config.AppSettings.Settings["_np_textBox"] != null)
                {
                    config.AppSettings.Settings["_np_textBox"].Value = np_textBox.Text;
                }
                else
                {
                    config.AppSettings.Settings.Add("_np_textBox", np_textBox.Text);
                }

                if (config.AppSettings.Settings["_pj_mal_textBox"] != null)
                {
                    config.AppSettings.Settings["_pj_mal_textBox"].Value = pj_mal_textBox.Text;
                }
                else
                {
                    config.AppSettings.Settings.Add("_pj_mal_textBox", pj_mal_textBox.Text);
                }

                if (config.AppSettings.Settings["_dk_textBox"] != null)
                {
                    config.AppSettings.Settings["_dk_textBox"].Value = dk_textBox.Text;
                }
                else
                {
                    config.AppSettings.Settings.Add("_dk_textBox", dk_textBox.Text);
                }


                config.Save(ConfigurationSaveMode.Modified);
            }
            catch { MessageBox.Show("Все параметры должны быть больше 0"); }
        }
    }
}