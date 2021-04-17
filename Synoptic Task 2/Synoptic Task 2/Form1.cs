using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Synoptic_Task_2
{
    


    public partial class Form1 : Form
    {   //Variables

        //room values
        double Rwidth;
        double Rlength;
        //placeholder
        double roomArea;

        //cutout 1
        double c1width;
        double c1length;
        //placeholder
        double Cutout1area;

        //cutout 2
        double c2width;
        double c2length;
        //placeholder
        double cutout2area;

        //The area which needs to be tiled
        double tileableArea;

        //tile size being used either 60x60 or 75x75
        double tilesize;

        //total tiles without offcuts
        double totaltiles;

        //total tiles with offcuts calcuated
        double fulltotaltiles;

        //offcut total
        double offcuts;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Calcuatebutton_Click(object sender, EventArgs e)
        {
            //Room Length:
            //Room values: turn text from textboxes into numbers
            Rlength = Convert.ToDouble(lengthbox.Text);
            Rwidth = Convert.ToDouble(widthbox.Text);

            //Room area (length x width) displayed to textbox, Doesnt calc the cutout areas
            Areatext.Text = Convert.ToString(Rwidth * Rlength);
            roomArea = (Rwidth * Rlength);

            //Cutout 1:
            //turns text from boxes into double
            c1width = Convert.ToDouble(cutout1Width.Text);
            c1length = Convert.ToDouble(cutout1Length.Text);
            
            //area length x width displayed to textbox
            cutout1total.Text = Convert.ToString(c1width * c1length);
            Cutout1area = (c1width * c1length);

            //Cutout 2:
            //turns text from boxes into double
            c2width = Convert.ToDouble(cutout2width.Text);
            c2length = Convert.ToDouble(cutout2length.Text);

            //area length x width displayed to textbox
            cutout2total.Text = Convert.ToString(c2width * c2length);
            cutout2area = (c2width * c2length);

            //room area subtract cutout areas
            tileableArea = (roomArea - Cutout1area - cutout2area);
            //displays the "tileable area"
            tileableAreatxt.Text = Convert.ToString(roomArea - Cutout1area - cutout2area);

            //radioboxes tile size
            if (radio60.Checked)
            {
                tilesize = 60 * 60;
                
            }

            if (radio75.Checked)
            {
                tilesize = 75 * 75;
            }

            //calcs how many tiles fit within the tileable area given
            totaltiles = tileableArea / tilesize;

            //rounds up value
            fulltotaltiles =  Math.Ceiling(totaltiles);

            //works out offcuts
            offcuts = fulltotaltiles - totaltiles;

            //outputs how many tiles needed to text box
            TotalTileBox.Text = Convert.ToString(fulltotaltiles);

            //outputs offcut total to text box
            offcutbox.Text = Convert.ToString(offcuts);

            //edgingstrip
            edgingstripbox.Text = Convert.ToString((Rlength * 2) + (Rwidth * 2));

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
