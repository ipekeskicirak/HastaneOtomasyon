using HastaneOtomasyon.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon
{
    public partial class YoneticiPanel : Form
    {
        public YoneticiPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YoneticiPanelHasta yoneticiHastaForm = new YoneticiPanelHasta();
            yoneticiHastaForm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YoneticiPanelDoktor yoneticiPanelForm = new YoneticiPanelDoktor();
            yoneticiPanelForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YoneticiPanelRandevu yoneticiPanelRandevu = new YoneticiPanelRandevu();
            yoneticiPanelRandevu.Show();
            this.Close();
        }
    }
}
