#region Usings...

//C# 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Project
using BeerPubProject.Model;

#endregion

namespace BeerPubProject.GUI
{
    public partial class BeerPubForm : Form
    {        
        Pub pub = new Pub("BridgeWaters Pub");

        public BeerPubForm()
        {
            InitializeComponent();

            RefreshList();
        }


        public void RefreshList()
        {
            lbBeersInPub.Items.Clear(); //clear GUI list so we dont have duplicates

            pub.GetBeers.Sort(); //use default sort (price)

            foreach (Beer b in pub.GetBeers)
                lbBeersInPub.Items.Add(b);
        }

        private void btnCheapestBeer_Click(object sender, EventArgs e)
        {
            Beer cheapestBeer = pub.FindCheapestBeer(); //get cheapest beer from pub object and store it in temp variable

            if (cheapestBeer != null)
            {
                foreach (Beer b in pub.GetBeers)
                    if (b.Name == cheapestBeer.Name)
                        lbBeersInPub.SelectedItem = b;
            }
        }

        private void lbBeersInPub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBeersInPub.SelectedItem != null) //make sure that something is selected :)
            {
                Beer selectedBeer = lbBeersInPub.SelectedItem as Beer; //cast selected item as beer

                //map it to textboxes
                txtName.Text = selectedBeer.Name;
                txtVolume.Text = Convert.ToString(selectedBeer.Volume);
                txtPrice.Text = Convert.ToString(selectedBeer.Price);             
            }
        }

        private void btnCreateBeer_Click(object sender, EventArgs e)
        {
            //create new beer object
            Beer newBeer = new Beer(txtName.Text, Convert.ToInt32(txtVolume.Text), Convert.ToInt32(txtPrice.Text));

            //tell pub object to add beer
            pub.Add(newBeer);
                        
            RefreshList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbBeersInPub.SelectedItem != null) //make sure that something is selected :)
            {
                Beer selectedBeer = lbBeersInPub.SelectedItem as Beer; //cast selected item as beer

                //tell pub object to remove beer
                pub.Remove(selectedBeer);

                RefreshList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lbBeersInPub.SelectedItem != null) //make sure that something is selected :)
            {
                Beer selectedBeer = lbBeersInPub.SelectedItem as Beer; //cast selected item as beer

                selectedBeer.Volume = Convert.ToInt32(txtVolume.Text);
                selectedBeer.Price = Convert.ToInt32(txtPrice.Text);             
                
                //tell pub object to update beer         
                pub.Update(selectedBeer);

                RefreshList();
            }
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPrice.Text = "";
            txtVolume.Text = "";

            lbBeersInPub.SelectedIndex = -1;
        }        
    }
}
