using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DotSpatial.Plugins.MenuBar
{
    public partial class ZoomToCoordinatesDialog : Form
    {
        String regExpression = "(-?\\d{1,3})[\\.\\,°]{0,1}\\s*(\\d{0,2})[\\.\\,\']{0,1}\\s*(\\d*)[\\.\\,°]{0,1}\\s*([NSnsEeWw]?)";

        private double[] lat;
        private double[] lon;

        public double latCoor { get; set; }
        public double lonCoor { get; set; }

        public ZoomToCoordinatesDialog()
        {
            InitializeComponent();
            lonStatus1.Text = "";
            latStatus1.Text = "";

            lonStatus2.Text = "";
            latStatus2.Text = "";

            lonStatus3.Text = "";
            latStatus3.Text = "";

            lat = new double[3];
            lon = new double[3];
        }

        private void ZoomToCoordinatesDialog_Load(object sender, EventArgs e)
        {

        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (checkCoordinates())
            {
                latCoor = loadCoordinates(lat);
                lonCoor = loadCoordinates(lon);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool checkCoordinates()
        {
            //tabControl1
            int index = tabControl1.SelectedIndex;
            string strDJ = "";
            string strBW = "";
            switch(index)
            {
                case 0:
                    strDJ = tbDJ1.Text.ToString();
                    strBW = tbBW1.Text.ToString();
                    break;
                case 1:
                    strDJ = tbDJ2.Text.ToString();
                    strBW = tbBW2.Text.ToString();
                    break;
                case 2:
                    strDJ = tbDJ3.Text.ToString();
                    strBW = tbBW3.Text.ToString();
                    break;
                default:
                    break;
            }

            bool lonCheck = parseCoordinates(lon, strDJ);
            bool latCheck = parseCoordinates(lat, strBW);


            string lonstatus = "";
            string latstatus = "";

            if (!lonCheck) { lonstatus = "Invalid Longitude (Valid example: \"19.4908 E\")"; }
            else { lonstatus = ""; }

            if (!latCheck) { latstatus = "Invalid Latitude (Valid example: \"41.1939 N\")"; }
            else { latstatus = ""; }

            switch (index)
            {
                case 0:
                    lonStatus1.Text = lonstatus;
                    latStatus1.Text = latstatus;
                    break;
                case 1:
                    lonStatus2.Text = lonstatus;
                    latStatus2.Text = latstatus;
                    break;
                case 2:
                    lonStatus3.Text = lonstatus;
                    latStatus3.Text = latstatus;
                    break;
                default:
                    break;
            }

            //bool latCheck = parseCoordinates(lat, d1.Text.ToString());
            //bool lonCheck = parseCoordinates(lon, d2.Text.ToString());

            //if (!latCheck) { latStatus.Text = "Invalid Latitude (Valid example: \"41.1939 N\")"; }
            //else { latStatus.Text = ""; }
            //if (!lonCheck) { lonStatus.Text = "Invalid Longitude (Valid example: \"19.4908 E\")"; }
            //else { latStatus.Text = "";}




            return latCheck && lonCheck;
        }

        // Parse Coordinates will understand lat-lon coordinates in a variety of formats and separate them into Degrees, Minutes, and Seconds.
        // We could just accept a simple decimal value for the coordinates, but since users might be copying and pasting from a variety of sources
        // it makes it user friendly to be able to accept a number of different formats.
        private bool parseCoordinates(double[] values, String text)
        {
            Match match;
            GroupCollection groups;

            match = Regex.Match(text, regExpression);
            groups = match.Groups;
            try
            {  
                values[0] = Double.Parse(groups[1].ToString());
                if (groups[2].Length > 0)
                {
                    values[1] = Double.Parse(groups[2].ToString());
                    if (groups[2].Length == 1) values[1] *= 10;
                }
                if (groups[3].Length > 0)
                {
                    values[2] = Double.Parse(groups[3].ToString());
                    if (groups[3].Length == 1) values[2] *= 10;
                }
            }
            catch
            {
                return false;
            }

            if ((groups[4].ToString().Equals("S", StringComparison.OrdinalIgnoreCase)
                || groups[4].ToString().Equals("W", StringComparison.OrdinalIgnoreCase))
                && values[0] > 0)
            {
                values[0] *= -1;
            }

            return true;
        }

        // Take Degrees-Minutes-Seconds from ParseCoordinates and turn them into doubles.
        private double loadCoordinates(double[] values)
        {
            double coor;

            //Convert Degrees, Minutes, Seconds to x, y coordinates for both lat and long.
            coor = values[2] / 100;
            coor += values[1];
            coor = coor / 100;
            coor += Math.Abs(values[0]);

            //Change signs to get to the right quadrant.
            if (values[0] < 0) { coor *= -1; }

            return coor;
        }

        private void tbXian_Click(object sender, EventArgs e)
        {

        }
    }
}